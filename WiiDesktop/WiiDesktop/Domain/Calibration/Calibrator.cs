using System;
using System.Collections.Generic;
using System.Text;
using WiiDesktop.Exceptions;
using WiiDesktop.Domain.Cursor;
using WiimoteLib;

namespace WiiDesktop.Domain.Calibration
{
    class Calibrator
    {
        private CalibrationData data;
        private WiimoteState lastState;
        private int screenWidth;
        private int screenHeight;
        private int pointsAdded;

        private const float CALIBRATION_MARGIN = .1f;
    
        public Calibrator(int screenWidth, int screenHeight)
        {
            data = new CalibrationData();
            lastState = new WiimoteState();

            pointsAdded = 0;
            this.screenHeight = screenHeight;
            this.screenWidth = screenWidth;
        }

        public bool calibrate(WiimoteState currentState)
        {
            if (currentState.IRState.Found1 && !lastState.IRState.Found1)
            {
                data.addPoint(currentState.IRState.RawX1, currentState.IRState.RawY1);
                Console.WriteLine("Punto " + (pointsAdded + 1) + " calibrado");

                if (++pointsAdded >= CalibrationData.CALIBRATION_POINTS)
                {
                    this.calibrate(data);
                    return true;
                }               
            }

            lastState.IRState.Found1 = currentState.IRState.Found1;

            return false;
        }

        public void calibrate(CalibrationData data)
        {
            CalibrationData dst = loadDestinationData();

            CursorWarper.setDestination(dst.X[0], dst.Y[0], dst.X[1], dst.Y[1], dst.X[2], dst.Y[2], dst.X[3], dst.Y[3]);
            CursorWarper.setSource(data.X[0], data.Y[0], data.X[1], data.Y[1], data.X[2], data.Y[2], data.X[3], data.Y[3]);
            CursorWarper.computeWarp();
        }

        private CalibrationData loadDestinationData()
        {
            CalibrationData dst = new CalibrationData();

            dst.addPoint(screenWidth * CALIBRATION_MARGIN, screenHeight * CALIBRATION_MARGIN);
            dst.addPoint(screenWidth * (1.0f - CALIBRATION_MARGIN), screenHeight * CALIBRATION_MARGIN);
            dst.addPoint(screenWidth * CALIBRATION_MARGIN, screenHeight * (1.0f - CALIBRATION_MARGIN));
            dst.addPoint(screenWidth * (1.0f - CALIBRATION_MARGIN), screenHeight * (1.0f - CALIBRATION_MARGIN));

            return dst;                                   
        }
    }
}
