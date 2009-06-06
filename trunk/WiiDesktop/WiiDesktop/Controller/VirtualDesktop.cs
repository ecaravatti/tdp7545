using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WiiDesktop.Exceptions;
using WiiDesktop.Domain.Calibration;
using WiimoteLib;

namespace WiiDesktop.Controller
{
    class VirtualDesktop
    {
        private Mutex mx;
        private bool isRunning;
        private bool isCalibrated;
        private Wiimote wiimote;
        private WiimoteController controller;
        private Calibrator calibrator;

        public VirtualDesktop()
        {
            isRunning    = true;
            isCalibrated = false;

            mx = new Mutex();

            //TODO Obtener width y height
            controller = new WiimoteController(1280, 800);
            calibrator = new Calibrator(1280, 800);

            wiimote = new Wiimote();
            wiimote.WiimoteChanged += new WiimoteChangedEventHandler(OnWiimoteChanged);
        }

        public void StartDesktop()
        {
            try
            {
                try
                {
                    CalibrationData data = CalibrationPersister.LoadCalibrationData();
                    calibrator.calibrate(data);
                    isCalibrated = true;
                }
                catch (CalibrationDataNotFoundException e)
                {
                    //No existe data de calibracion.
                }

                wiimote.Connect();
                wiimote.SetReportType(Wiimote.InputReport.IRAccel, true);
                wiimote.SetLEDs(true, false, false, false);

                while (isRunning) ;
            }
            catch (System.Exception x)
            {
                throw new UserTerminatedException("WiimoteLib.dll:" + x.Message + "\nWiimoteIRDetector: Failed while trying to connect to Wiimote.");
            }
        }

        private void OnWiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {
            mx.WaitOne();

            try
            {
                if (isCalibrated)
                {
                    controller.StartHandling(args.WiimoteState);
                }
                else
                {
                    isCalibrated = calibrator.calibrate(args.WiimoteState);
                }

            }
            catch (UserTerminatedException e)
            {
                wiimote.Disconnect();
                isRunning = false;
            }

            mx.ReleaseMutex();
        }
    }
}
