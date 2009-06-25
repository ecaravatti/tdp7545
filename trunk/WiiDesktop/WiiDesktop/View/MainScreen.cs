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

        public MainScreen(VirtualDesktop model)
        {
            this.model = model;
            InitializeComponent();
        }

        private void loadCalibration_Click(object sender, EventArgs e)
        {
            if (!model.LoadCalibration())
            {
                MessageBox.Show(ErrorMessages.CALIBRATION_FILE_NOT_FOUND, "Calibración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calibrate_Click(object sender, EventArgs e)
        {
            (new CalibrationScreen(model)).Show();
        }
    }
}