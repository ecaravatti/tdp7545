using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MouseGestures;
using System.Reflection;
using System.IO;
using WiiDesktop.Domain.Gestures;

namespace WiiDesktop.View
{
    public partial class GesturesScreen : Form
    {


        private PictureBox[] mouseGestureDisplay;

        public GesturesScreen()
        {
            InitializeComponent();
            mouseGestureDisplay = new PictureBox[16];

            pbUp.Tag = MouseGesture.Up;
            pbRight.Tag = MouseGesture.Right;
            pbDown.Tag = MouseGesture.Down;
            pbLeft.Tag = MouseGesture.Left;

            pbUpRight.Tag = MouseGesture.UpRight;
            pbUpDown.Tag = MouseGesture.UpDown;
            pbUpLeft.Tag = MouseGesture.UpLeft;

            pbRightUp.Tag = MouseGesture.RightUp;
            pbRightDown.Tag = MouseGesture.RightDown;
            pbRightLeft.Tag = MouseGesture.RightLeft;

            pbDownUp.Tag = MouseGesture.DownUp;
            pbDownRight.Tag = MouseGesture.DownRight;
            pbDownLeft.Tag = MouseGesture.DownLeft;

            pbLeftUp.Tag = MouseGesture.LeftUp;
            pbLeftRight.Tag = MouseGesture.LeftRight;
            pbLeftDown.Tag = MouseGesture.LeftDown;

            mouseGestureDisplay[0] = pbUp;
            mouseGestureDisplay[1] = pbRight;
            mouseGestureDisplay[2] = pbDown;
            mouseGestureDisplay[3] = pbLeft;

            mouseGestureDisplay[4] = pbUpRight;
            mouseGestureDisplay[5] = pbUpDown;
            mouseGestureDisplay[6] = pbUpLeft;

            mouseGestureDisplay[7] = pbRightUp;
            mouseGestureDisplay[8] = pbRightDown;
            mouseGestureDisplay[9] = pbRightLeft;

            mouseGestureDisplay[10] = pbDownUp;
            mouseGestureDisplay[11] = pbDownRight;
            mouseGestureDisplay[12] = pbDownLeft;

            mouseGestureDisplay[13] = pbLeftUp;
            mouseGestureDisplay[14] = pbLeftRight;
            mouseGestureDisplay[15] = pbLeftDown;
        }

        private void timerReset_Tick(object sender, EventArgs e)
        {
            //resets images to normal
            ResetImages();
//            timerReset.Stop();
        }
        
        private void ResetImages()
        {
            foreach (PictureBox pb in mouseGestureDisplay)
            {
                Stream a = Assembly.GetExecutingAssembly().GetManifestResourceStream(
                  getResourceName((MouseGesture)pb.Tag, false));
                pb.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(
                  getResourceName((MouseGesture)pb.Tag, false)));
            }
        }

        //Build full name of the resource
        private string getResourceName(MouseGesture mg, bool activeImage)
        {
            string active = "";
            if (activeImage)
                active = "A";

            string gestureName = Enum.GetName(typeof(MouseGesture), (MouseGesture)mg);
            string returnValue = "WiiDesktop.Resources.Images." + gestureName + active + ".png";
            return returnValue;
        }

        private void mouseGesturesTest_Gesture(object sender, MouseGestureEventArgs e)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = GestureConfiguration.Instance.ResolveCommand(e.Gesture);
                process.Start();
            }
            catch (Exception) {
                // No hay comando configurado para el gesto detectado
            }
            foreach (PictureBox pb in mouseGestureDisplay)
            {
                if ((MouseGesture)pb.Tag == e.Gesture)
                {
                    //load image from the resources
                    pb.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(
              getResourceName(e.Gesture, true)));
//                    timerReset.Start();
                    return;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetImages();
        }

        private void pbUp_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}