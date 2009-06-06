using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using WiiDesktop.Domain.Cursor;
using WiiDesktop.Exceptions;

namespace WiiDesktop.Domain.Calibration
{
    static class CalibrationPersister
    {
        private const string CALIBRATION_FILE_NAME = "calibration.dat";

        public static void SaveCalibrationData(CalibrationData data)
        {
            TextWriter tw = new StreamWriter(CALIBRATION_FILE_NAME);

            for (int i = 0; i < CalibrationData.CALIBRATION_POINTS; i++)
            {
                tw.WriteLine(data.X[i]);
                tw.WriteLine(data.Y[i]);
            }
            
            tw.Close();
        }

        public static CalibrationData LoadCalibrationData()
        {   
            try
            {
                CalibrationData data = new CalibrationData();

                TextReader tr = new StreamReader(CALIBRATION_FILE_NAME);

                for (int i = 0; i < CalibrationData.CALIBRATION_POINTS; i++)
                {
                    data.addPoint(float.Parse(tr.ReadLine()), float.Parse(tr.ReadLine()));
                }
                
                tr.Close();

                return data;
            }
            catch (Exception x)
            {
                throw new CalibrationDataNotFoundException("Calibration data not found", x);
            }
        }
    }
}
