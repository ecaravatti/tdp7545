using System;
using System.Collections.Generic;
using System.Text;
using WiiDesktop.Exceptions;
using WiiDesktop.Domain.Cursor;
using WiimoteLib;
using WiiDesktop.Common;
using WiiDesktop.Controller;

namespace WiiDesktop.Domain.Calibration
{
    class Calibrator : Subject
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

        public bool Calibrate(WiimoteState currentState)
        {
            if (currentState.IRState.Found1 && !lastState.IRState.Found1)
            {
                data.addPoint(currentState.IRState.RawX1, currentState.IRState.RawY1);
                Console.WriteLine("Punto " + (pointsAdded + 1) + " calibrado");
                Notify();

                if (++pointsAdded >= CalibrationData.CALIBRATION_POINTS)
                {
                    this.Calibrate(data);
                    //FIXME El Notify() se tiene que llamar después de llamar a este método!!
                    Notify();
                    return true;
                }               
            }

            lastState.IRState.Found1 = currentState.IRState.Found1;

            return false;
        }

        public void Calibrate(CalibrationData data)
        {
            CalibrationData dst = LoadDestinationData();

            CursorWarper.setDestination(dst.X[0], dst.Y[0], dst.X[1], dst.Y[1], dst.X[2], dst.Y[2], dst.X[3], dst.Y[3]);
            CursorWarper.setSource(data.X[0], data.Y[0], data.X[1], data.Y[1], data.X[2], data.Y[2], data.X[3], data.Y[3]);
            CursorWarper.computeWarp();
        }

        public float GetX()
        {
            return GetX(pointsAdded);
        }

        public float GetY()
        {
            return GetY(pointsAdded);
        }

        private CalibrationData LoadDestinationData()
        {
            CalibrationData dst = new CalibrationData();

            dst.addPoint(GetX(0), GetY(0));
            dst.addPoint(GetX(1), GetY(1));
            dst.addPoint(GetX(2), GetY(2));
            dst.addPoint(GetX(3), GetY(3));

            return dst;                                   
        }

        private float GetX(int step)
        {
            switch (step)
            {
                case 0:
                    return screenWidth * CALIBRATION_MARGIN;
                case 1:
                    return screenWidth * (1.0f - CALIBRATION_MARGIN);
                case 2:
                    return screenWidth * CALIBRATION_MARGIN;
                case 3:
                    return screenWidth * (1.0f - CALIBRATION_MARGIN);
                default:
                    return 0;
            }
        }

        private float GetY(int step)
        {
            switch (step)
            {
                case 0:
                    return screenHeight * CALIBRATION_MARGIN;
                case 1:
                    return screenHeight * CALIBRATION_MARGIN;
                case 2:
                    return screenHeight * (1.0f - CALIBRATION_MARGIN);
                case 3:
                    return screenHeight * (1.0f - CALIBRATION_MARGIN);
                default:
                    return 0;
            }
        }
    }
}
