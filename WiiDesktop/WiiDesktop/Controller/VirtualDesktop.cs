using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WiiDesktop.Exceptions;
using WiiDesktop.Domain.Calibration;
using WiimoteLib;
using WiiDesktop.View;
using System.Windows.Forms;
using WiiDesktop.Common;

namespace WiiDesktop.Controller
{
    class VirtualDesktop
    {
        private Mutex mx;
        private bool isCalibrated;
        private int screenWidth;
        private int screenHeight;
        private Wiimote wiimote;
        private WiimoteController controller;
        private Calibrator calibrator;

        private static VirtualDesktop instance;

        private VirtualDesktop()
        {
            isCalibrated = false;
            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;

            mx = new Mutex();

            //TODO Obtener width y height
            controller = new WiimoteController(screenWidth, screenHeight);
            

            wiimote = new Wiimote();
            wiimote.WiimoteChanged += new WiimoteChangedEventHandler(OnWiimoteChanged);
        }

        static public VirtualDesktop GetInstance()
        {
            if (instance == null)
                instance = new VirtualDesktop();

            return instance;
        }

        public Point Calibrate(Observer observer)
        {
            calibrator = new Calibrator(screenWidth, screenHeight);
            calibrator.AddObserver(observer);

            StartDesktop();

            //TODO Cambiar en toda la aplicación los (x,y) por Point!!
            return new Point(calibrator.GetX(), calibrator.GetY());
        }

        public Boolean LoadCalibration()
        {
            try
            {
                CalibrationData data = CalibrationPersister.LoadCalibrationData();
                calibrator.Calibrate(data);
                isCalibrated = true;
                return true;
            }
            catch (CalibrationDataNotFoundException e)
            {
                return false;
            }
        }

        public void StartDesktop()
        {
            try
            {
                wiimote.Connect();
                wiimote.SetReportType(Wiimote.InputReport.IRAccel, true);
                wiimote.SetLEDs(true, false, false, false);
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
                    isCalibrated = calibrator.Calibrate(args.WiimoteState);
                }

            }
            catch (UserTerminatedException e)
            {
                wiimote.Disconnect();
            }

            mx.ReleaseMutex();
        }

        public bool GetIsCalibrated()
        {
            return isCalibrated;
        }

    }
}
