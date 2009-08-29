using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WiiDesktop.Domain.Cursor
{ 
    static class CursorSmoother
    {
        private const int SMOOTHING_BUFFER_SIZE = 50;
        private const int SMOOTHING_AMOUNT = 20;

        private static PointF[] smoothingBuffer;

        private static int smoothingBufferIndex;
        public static int SmoothingBufferIndex { 
            get { return smoothingBufferIndex; } 
            set { smoothingBufferIndex = value;} 
        }

        static CursorSmoother()
        {
            smoothingBuffer = new PointF[SMOOTHING_BUFFER_SIZE];
            for (int i = 0; i < SMOOTHING_BUFFER_SIZE; i++)
                smoothingBuffer[i] = new PointF();

            smoothingBufferIndex = 0;
        }

        public static PointF getSmoothedCursor()
        {
            int start = smoothingBufferIndex - SMOOTHING_AMOUNT;
            if (start < 0)
                start = 0;
            PointF smoothed = new PointF(0, 0);
            int count = smoothingBufferIndex - start;
            for (int i = start; i < smoothingBufferIndex; i++)
            {
                smoothed.X += smoothingBuffer[i % SMOOTHING_BUFFER_SIZE].X;
                smoothed.Y += smoothingBuffer[i % SMOOTHING_BUFFER_SIZE].Y;
            }
            smoothed.X /= count;
            smoothed.Y /= count;
            return smoothed;
        }

        public static void smoothCursor(PointF warpedCoordinates)
        {
            smoothingBuffer[smoothingBufferIndex % SMOOTHING_BUFFER_SIZE].X = warpedCoordinates.X;
            smoothingBuffer[smoothingBufferIndex % SMOOTHING_BUFFER_SIZE].Y = warpedCoordinates.Y;
            smoothingBufferIndex++;
        }


    }
}
