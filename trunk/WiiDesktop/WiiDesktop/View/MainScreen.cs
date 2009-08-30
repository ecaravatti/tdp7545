using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WiiDesktop.Controller;

namespace WiiDesktop.View
{
    public partial class MainScreen : Form
    {
        private VirtualDesktop model;
        private Timer batteryTimer;

        public MainScreen(VirtualDesktop model)
        {
            this.model = model;
            this.batteryTimer = new Timer();
            InitializeComponent();
            SetBatteryCharge();
            batteryTimer.Interval = 1000*60*5; //5 min
            batteryTimer.Tick += new EventHandler(Timer_Tick);
            batteryTimer.Start();
        }

        private void loadCalibration_Click(object sender, EventArgs e)
        {
            if (!model.LoadCalibration())
            {
                MessageBox.Show(ErrorMessages.CALIBRATION_FILE_NOT_FOUND, "Calibración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(ErrorMessages.CALIBRATION_LOADED, "Calibración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void calibrate_Click(object sender, EventArgs e)
        {
            (new CalibrationScreen(model)).Show();
        }

        private void MainScreen_FormClosing(object sender, EventArgs e)
        {
            batteryTimer.Stop();
            model.StopDesktop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sender == batteryTimer)
            {
                SetBatteryCharge();
            }
        }

        private void SetBatteryCharge()
        {
            int batteryCharge = model.GetBatteryCharge();
            wiimoteBatteryBar.Value = batteryCharge;
            wiimoteBatteryLabel.Text = batteryCharge.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GesturesScreen()).Show();
        }
        
    }
}