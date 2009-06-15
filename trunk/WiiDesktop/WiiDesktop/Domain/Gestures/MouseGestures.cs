using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MouseGestures;
using MouseGestures.Common;

namespace MouseGestures
{
    [ToolboxBitmap(typeof(MouseGestures), "ComponentIcon")]
    public partial class MouseGestures : Component
    {



        /// <summary>
        /// Minimal length of MouseMoveSegment
        /// </summary>
        private const uint mouseMoveSegmentLength = 8;
        private GestureSegmentList gestureSegmentList;
        private IMouseMessageFilter mf;
        private Point lastPoint;
        private Point gestureStartLocation;

        #region Properties

        #region Enabled
        /// <summary>
        /// Gets or sets propery indicating whether component is enabled and
        /// will recognize mouse gestures
        /// </summary>
        [DefaultValue(true)]
        public bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
                mf.Enabled = value;
            }
        }
        private bool enabled = true;
        #endregion


        #region Working
        /// <summary>
        /// Gets value indicating whether component is capturing and recognizing
        /// mouse gesture
        /// </summary>

        [Category("Mouse Gestures")]
        public bool Working
        {
            get
            {
                return working;
            }
        }
        private bool working;
        #endregion

        #region MinGestureSize
        /// <summary>
        /// Gets or sets minimal gesture size in pixels
        /// </summary>
        [DefaultValue(30),
        Category("Mouse Gestures")]
        public int MinGestureSize
        {
            get
            {
                return minGestureSize;
            }
            set
            {
                if (value > 0)
                    minGestureSize = value;
            }
        }
        private int minGestureSize = 30;
        #endregion

        #endregion

        #region Constructor
        /// <summary>
        /// Generic constructor used by Visual Studio
        /// </summary>
        /// <param name="container"></param>
        public MouseGestures(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            gestureSegmentList = new GestureSegmentList();

            InitializeMessageFilter();
        }

        #endregion

        /// <summary>
        /// Installs MouseMessageFilter and hooks it's events
        /// </summary>
        private void InitializeMessageFilter()
        {
            mf = new ManagedMouseFilter();

            mf.Enabled = enabled;
            mf.RightButtonDown += new MouseFilterEventHandler(BeginGesture);
            mf.MouseMove += new MouseFilterEventHandler(AddToGesture);
            mf.RightButtonUp += new MouseFilterEventHandler(EndGesture);
        }

        #region Destructors
        ~MouseGestures()
        {

        }
        #endregion



        #region Mouse Events Handling
        /// <summary>
        /// Starts new mouse gesture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Mouse event data</param>
        /// <remarks>
        /// Functions is called on the RightButtonDown event of MouseMessageFilter.
        /// </remarks>
        public void BeginGesture(object sender, EventArgs e)
        {
            gestureSegmentList.Clear();
            working = true;
            gestureStartLocation = Cursor.Position;
            lastPoint = Cursor.Position;
        }




        /// <summary>
        /// Adds MouseMoveSegment to the current gesture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Mouse event data</param>
        /// <remarks>
        /// Function is called on the MouseMoveSegment of MouseMessageFilter
        /// The segment is added only when segment length is greater then 
        /// mouseMoveSegmentLength
        /// </remarks>
        public void AddToGesture(object sender, EventArgs e)
        {
            if (working)
            {
                if (Util.GetDistance(lastPoint, Cursor.Position) >= mouseMoveSegmentLength)
                {
                    MouseMoveSegment segment = new MouseMoveSegment(lastPoint, Cursor.Position);
                    gestureSegmentList.Add(segment);
                    lastPoint = Cursor.Position;
                }
            }
        }

        /// <summary>
        /// Stops mouse gesture recording and tries to recognize the gesture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Mouse event data</param>
        public void EndGesture(object sender, EventArgs e)
        {
            working = false;

            //check minimal length
            //TODO change minimal length checking  - does not work for gesture LeftRight, etc...
            if (gestureSegmentList.Count() * mouseMoveSegmentLength < minGestureSize)
            {
                //too short for mouse gesture - send regular right mouse click
                mf.Enabled = false;
                WinAPI.MouseInputEmulation.SendRightMouseClick();
                Application.DoEvents();
                mf.Enabled = true;

                return;
            }

            //try recognize mouse gesture
            MouseGesture gesture = gestureSegmentList.RecognizeGesture();
            if (gesture != MouseGesture.Unknown)
            {
                RaiseGestureEvents(gesture);
            }
        }
        #endregion

        #region MouseGesture Evetns

        /// <summary>
        /// Raises proper events
        /// </summary>
        /// <param name="gesture">Gesture performed.</param>
        private void RaiseGestureEvents(MouseGesture gesture)
        {
            if (gesture != MouseGesture.Unknown)
            {
                MouseGestureEventArgs eventArgs = new MouseGestureEventArgs(gesture, gestureStartLocation);

                //always raise general event
                RaiseGestureEvent(eventArgs);

                switch (gesture)
                {
                    case MouseGesture.Up:
                        RaiseGestureUpEvent(eventArgs);
                        break;
                    case MouseGesture.Right:
                        RaiseGestureRightEvent(eventArgs);
                        break;
                    case MouseGesture.Down:
                        RaiseGestureDownEvent(eventArgs);
                        break;
                    case MouseGesture.Left:
                        RaiseGestureLeftEvent(eventArgs);
                        break;
                }

                if (gestureSegmentList.EnableComplexGestures)
                {
                    switch (gesture)
                    {
                        case MouseGesture.UpDown:
                            RaiseGestureUpDownEvent(eventArgs);
                            break;
                        case MouseGesture.UpRight:
                            RaiseGestureUpRightEvent(eventArgs);
                            break;
                        case MouseGesture.UpLeft:
                            RaiseGestureUpLeftEvent(eventArgs);
                            break;

                        case MouseGesture.RightUp:
                            RaiseGestureRightUpEvent(eventArgs);
                            break;
                        case MouseGesture.RightDown:
                            RaiseGestureRightDownEvent(eventArgs);
                            break;
                        case MouseGesture.RightLeft:
                            RaiseGestureRightLeftEvent(eventArgs);
                            break;

                        case MouseGesture.DownUp:
                            RaiseGestureDownUpEvent(eventArgs);
                            break;
                        case MouseGesture.DownRight:
                            RaiseGestureDownRightEvent(eventArgs);
                            break;
                        case MouseGesture.DownLeft:
                            RaiseGestureDownLeftEvent(eventArgs);
                            break;

                        case MouseGesture.LeftUp:
                            RaiseGestureLeftUpEvent(eventArgs);
                            break;
                        case MouseGesture.LeftRight:
                            RaiseGestureLeftRightEvent(eventArgs);
                            break;
                        case MouseGesture.LeftDown:
                            RaiseGestureLeftDownEvent(eventArgs);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Represents the method that will handle MouseGesture events.
        /// </summary>
        /// <param name="sender">The source of event.</param>
        /// <param name="start">A MouseGestureEventArgs that contains event data.</param>
        public delegate void GestureHandler(object sender, MouseGestureEventArgs e);

        /// <summary>
        /// Occurs whether valid mouse gesture is performed.
        /// </summary>
        public event GestureHandler Gesture;
        private void RaiseGestureEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = Gesture;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        #region Simple Gesture Events

        /// <summary>
        /// Occurs whether GestureUp is performed.
        /// </summary>
        [Category("SimpleGestures")]
        public event GestureHandler GestureUp;
        private void RaiseGestureUpEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureUp;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureRight is performed.
        /// </summary>
        [Category("SimpleGestures")]
        public event GestureHandler GestureRight;
        private void RaiseGestureRightEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureRight;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureDown is performed.
        /// </summary>
        [Category("SimpleGestures")]
        public event GestureHandler GestureDown;
        private void RaiseGestureDownEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureDown;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureLeft is performed.
        /// </summary>
        [Category("SimpleGestures")]
        public event GestureHandler GestureLeft;
        private void RaiseGestureLeftEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureLeft;
            if (temp != null)
            {
                temp(this, e);
            }
        }
        #endregion

        #region Complex Gesture Events

        /// <summary>
        /// Occurs whether GestureUpRight is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureUpRight;
        private void RaiseGestureUpRightEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureUpRight;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureUpDown is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureUpDown;
        private void RaiseGestureUpDownEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureUpDown;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureUpLeft is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureUpLeft;
        private void RaiseGestureUpLeftEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureUpLeft;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureRightUp is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureRightUp;
        private void RaiseGestureRightUpEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureRightUp;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureRightDown is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureRightDown;
        private void RaiseGestureRightDownEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureRightDown;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureRightLeft is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureRightLeft;
        private void RaiseGestureRightLeftEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureRightLeft;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureDownUp is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureDownUp;
        private void RaiseGestureDownUpEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureDownUp;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureDownRight is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureDownRight;
        private void RaiseGestureDownRightEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureDownRight;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureDownLeft is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureDownLeft;
        private void RaiseGestureDownLeftEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureDownLeft;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureLeftUp is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureLeftUp;
        private void RaiseGestureLeftUpEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureLeftUp;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureLeftRight is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureLeftRight;
        private void RaiseGestureLeftRightEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureLeftRight;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        /// <summary>
        /// Occurs whether GestureLeftDown is performed.
        /// </summary>
        [Category("ComplexGestures")]
        public event GestureHandler GestureLeftDown;
        private void RaiseGestureLeftDownEvent(MouseGestureEventArgs e)
        {
            GestureHandler temp = GestureLeftDown;
            if (temp != null)
            {
                temp(this, e);
            }
        }

        #endregion

        #endregion
    }
}
