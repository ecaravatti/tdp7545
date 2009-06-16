using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WiiDesktop.Common;
using System.Drawing.Imaging;
using WiiDesktop.Domain.Calibration;
using WiiDesktop.Controller;

namespace WiiDesktop.View
{
    public partial class CalibrationScreen : Form, Observer
    {
        private Bitmap bCalibration;
        private Graphics gCalibration;

        public CalibrationScreen()
        {
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);

            InitializeComponent();

            this.Text = "Calibration - Working area:" + Screen.GetWorkingArea(this).ToString() + " || Real area: " + Screen.GetBounds(this).ToString();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyPress);
            
            bCalibration = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
            gCalibration = Graphics.FromImage(bCalibration);
            gCalibration.Clear(Color.White);
            
            pbCalibration.Left = 0;
            pbCalibration.Top = 0;
            pbCalibration.Size = new Size(rect.Width, rect.Height);
            
            WiiDesktop.Common.Point startingPoint = VirtualDesktop.GetInstance().Calibrate(this);
            DrawCalibrationPoint(startingPoint.GetX(), startingPoint.GetY(), gCalibration);
            BeginInvoke((MethodInvoker)delegate() { pbCalibration.Image = bCalibration; });
            
        }

        public void Update(object subject)
        {
            if (VirtualDesktop.GetInstance().GetIsCalibrated())
            {
                ((Subject)subject).RemoveObserver(this);
                this.Dispose();
            }
            else
            {
                gCalibration.Clear(Color.White);
                DrawCalibrationPoint(((Calibrator)subject).GetX(), ((Calibrator)subject).GetY(), gCalibration);
                BeginInvoke((MethodInvoker)delegate() { pbCalibration.Image = bCalibration; });
            }
        }

        private void OnKeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((int)(byte)e.KeyCode == (int)Keys.Escape)
            {
                this.Dispose(); // Esc was pressed
            }
        }

        private void DrawCalibrationPoint(float x, float y, Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Blue), x - 25, y - 25, 50, 50);
            g.DrawEllipse(new Pen(Color.Blue), x - 5, y - 5, 10, 10);
        }
    }
}