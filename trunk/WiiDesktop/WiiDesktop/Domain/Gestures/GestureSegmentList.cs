using System;
using System.Collections.Generic;
using System.Text;

namespace MouseGestures
{
    public class GestureSegmentList
    {
        private bool enableComplexGestures;
        private List<MouseMoveSegment> mouseMoveSegments;
        // Maximal ratio of unknown MouseMoveSegments it the gesture
        private const float maxUnknownSkipRatio = 0.35F;

        public GestureSegmentList()
        {
            mouseMoveSegments = new List<MouseMoveSegment>();
            enableComplexGestures = true;
        }

        public void Add(MouseMoveSegment segment)
        {
            mouseMoveSegments.Add(segment);
        }

        public int Count()
        {
            return mouseMoveSegments.Count;
        }

        public void Clear()
        {
            mouseMoveSegments.Clear();
        }


        #region EnableComplexGestures
        /// <summary>
        /// Gets or sets propery indicating whether component should recognize
        /// complex gestures
        /// </summary>
        public bool EnableComplexGestures
        {
            get
            {
                return enableComplexGestures;
            }
            set
            {
                enableComplexGestures = value;
            }
        }
        #endregion

        #region Helper Functions


        /// <summary>
        /// Counts segments in row with SegmentDirection. 
        /// Counting started at the index of mouseMoveSegments array.
        /// </summary>
        /// <param name="index">
        /// Index to start at. Index to start next search is passed to
        /// this var.
        /// </param>
        /// <param name="segmentDirection">The direction of segments to count.</param>
        /// <returns>Returns the number of segments with direction in the row.</returns>
        public int CountMouseMoveSegments(ref int index, MouseMoveSegment.SegmentDirection segmentDirection)
        {
            int count = 0;

            while (index < mouseMoveSegments.Count &&
                   mouseMoveSegments[index].Direction == segmentDirection)
            {
                index++;
                count++;
            }

            return count;
        }

        /// <summary>
        /// Counts segments with the same direction in mouseMoveSegments.
        /// Counting started at the index of mouseMoveSegments array and
        /// the direction of segments is passed to the segmentDirection
        /// </summary>
        /// <param name="index">
        /// Index to start at. Index to start next search is passed to
        /// this var.
        /// </param>
        /// <param name="segmentDirection">
        /// The direction of the segments is passed
        /// to this var.
        /// </param>
        /// <returns>Returns the number of segments with the same direction in the row.</returns>
        public int CountMouseMoveSegments(ref int index, out MouseMoveSegment.SegmentDirection segmentDirection)
        {
            int count = 0;
            segmentDirection = MouseMoveSegment.SegmentDirection.Unknown;

            if (index < mouseMoveSegments.Count)
            {
                segmentDirection = mouseMoveSegments[index].Direction;
            }
            else
                return 0;

            while (index < mouseMoveSegments.Count &&
              mouseMoveSegments[index].Direction == segmentDirection)
            {
                index++;
                count++;
            }

            return count;
        }
        #endregion


        #region Recognition Functions
        /// <summary>
        /// Tries to recognize simple mouse gesture
        /// </summary>
        /// <param name="unknownBefore">The number of segments with SegmentDirection.Unknown before the gesture</param>
        /// <param name="length">The number of segments of the gesture.</param>
        /// <param name="unknownAfter">The number of segments with SegmentDirection.Unknown after the gesture</param>
        /// <param name="direction">The direction of the gesture.</param>
        /// <returns>Returns the simple gesture or MouseGesture.Unknown if no gesture is recognized.</returns>
        protected MouseGesture RecognizeSimpleGesture(int unknownBefore, int length, int unknownAfter, MouseMoveSegment.SegmentDirection direction)
        {
            // max length of unknown segments before and after gesture
            double lengthTolerance = length * maxUnknownSkipRatio;
            // check unknown segments
            if ((unknownBefore < lengthTolerance) && (unknownAfter < lengthTolerance))
            {
                //according to the direction of the segment choose simple MouseGesture
                switch (direction)
                {
                    case MouseMoveSegment.SegmentDirection.Up:
                        return MouseGesture.Up;
                    case MouseMoveSegment.SegmentDirection.Right:
                        return MouseGesture.Right;
                    case MouseMoveSegment.SegmentDirection.Down:
                        return MouseGesture.Down;
                    case MouseMoveSegment.SegmentDirection.Left:
                        return MouseGesture.Left;
                }
            }

            return MouseGesture.Unknown;
        }

        /// <summary>
        /// Recognizes complex MouseGesture from two simple gestures
        /// </summary>
        /// <param name="firstGesture">First simple gesture.</param>
        /// <param name="secondGesture">Second simple gesture</param>
        /// <returns>Returns complex MouseGesture or MouseGesture.Unknown if no gesture is recognized.</returns>
        protected MouseGesture RecognizeComplexGeasture(MouseGesture firstGesture, MouseGesture secondGesture)
        {
            if (firstGesture == MouseGesture.Unknown || secondGesture == MouseGesture.Unknown)
                return MouseGesture.Unknown;

            //treats two simple gesture with the same direction with some unknown
            //segments between them as valid simple gesture
            //TODO consider disabling this
            if (firstGesture == secondGesture)
                return firstGesture;

            //see MouseGesture.cs for referecne how to compute complex gesture
            return (firstGesture | (MouseGesture)((int)secondGesture * 2));
        }

        /// <summary>
        /// Recognize gesture from the recorded data
        /// </summary>
        /// <returns>Returns MouseGesture or MouseGesture.Unknown if no gesture is recognized.</returns>
        /// <remarks>
        /// Funtion counts the number of unknown segments before the gestures,
        /// the number of segments in the gestures and the number of unknown segments
        /// after the gestures. These counts are keystone for the gesture recognition.
        /// </remarks>
        public MouseGesture RecognizeGesture()
        {
            int index = 0;
            int unknownSegmentsBefore = CountMouseMoveSegments(ref index, MouseMoveSegment.SegmentDirection.Unknown);
            MouseMoveSegment.SegmentDirection firstSegmentDirection;
            int firstGestureLenght = CountMouseMoveSegments(ref index, out firstSegmentDirection);
            int unknownSegmentsMiddle = CountMouseMoveSegments(ref index, MouseMoveSegment.SegmentDirection.Unknown);
            MouseMoveSegment.SegmentDirection secondSegmentDirection = MouseMoveSegment.SegmentDirection.Unknown;
            int secondGestureLength = 0;
            int unknownSegmentAfter = 0;

            //if complex gesture are enabled count segments for the second gesture
            if (enableComplexGestures)
            {
                secondGestureLength = CountMouseMoveSegments(ref index, out secondSegmentDirection);

                unknownSegmentAfter = CountMouseMoveSegments(ref index, MouseMoveSegment.SegmentDirection.Unknown);
            }

            //if there are some segments left, the recorded data does not contain valid mouse gesture
            MouseMoveSegment.SegmentDirection nextSegment;
            if (CountMouseMoveSegments(ref index, out nextSegment) > 0)
            {
                return MouseGesture.Unknown;
            }

            //recognize firs gesture
            MouseGesture firstGesture =
              RecognizeSimpleGesture(unknownSegmentsBefore, firstGestureLenght,
                                     unknownSegmentsMiddle, firstSegmentDirection);

            //if complex gesture are enabled continue with second gesture
            MouseGesture secondGesture;
            if ((enableComplexGestures) && (secondGestureLength > 0))
            {
                secondGesture = RecognizeSimpleGesture(unknownSegmentsMiddle, secondGestureLength,
                                                       unknownSegmentAfter, secondSegmentDirection);

                return RecognizeComplexGeasture(firstGesture, secondGesture);
            }
            else
                return firstGesture;
        }
        #endregion

    }
}
