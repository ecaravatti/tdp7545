using System;
using System.Collections.Generic;
using System.Text;

namespace WiiDesktop.Domain.Calibration
{
    class CalibrationData
    {
        public static int CALIBRATION_POINTS = 4;

        private int pointIndex;

        private float[] x;
        public float[] X
        {
            get { return x; }

            set
            {
                x = new float[CALIBRATION_POINTS];

                for (int i = 0; i < CALIBRATION_POINTS; i++)
                {
                    x[i] = value[i];
                }
            }
        }
        
        private float[] y;
        public float[] Y { 
            get { return y; }

            set
            {
                y = new float[CALIBRATION_POINTS];

                for (int i = 0; i < CALIBRATION_POINTS; i++)
                {
                    y[i] = value[i];
                }
            }
        }

        public CalibrationData(float[] x, float[] y)
        {
            this.X = x;
            this.Y = y;
            pointIndex = 0;
        }

        public CalibrationData()
        {
            x = new float[CALIBRATION_POINTS];
            y = new float[CALIBRATION_POINTS];
            pointIndex = 0;
        }

        public void addPoint(float x, float y)
        {
            if (pointIndex < CALIBRATION_POINTS)
            {
                this.x[pointIndex] = x;
                this.y[pointIndex++] = y;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
