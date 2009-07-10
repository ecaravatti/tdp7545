namespace WiiDesktop.View
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calibrate = new System.Windows.Forms.Button();
            this.wiimoteBattery = new System.Windows.Forms.GroupBox();
            this.wiimoteBatteryLabel = new System.Windows.Forms.Label();
            this.wiimoteBatteryBar = new System.Windows.Forms.ProgressBar();
            this.loadCalibration = new System.Windows.Forms.Button();
            this.wiimoteBattery.SuspendLayout();
            this.SuspendLayout();
            // 
            // calibrate
            // 
            this.calibrate.Location = new System.Drawing.Point(12, 61);
            this.calibrate.Name = "calibrate";
            this.calibrate.Size = new System.Drawing.Size(129, 40);
            this.calibrate.TabIndex = 0;
            this.calibrate.Text = "Calibrar";
            this.calibrate.UseVisualStyleBackColor = true;
            this.calibrate.Click += new System.EventHandler(this.calibrate_Click);
            // 
            // wiimoteBattery
            // 
            this.wiimoteBattery.Controls.Add(this.wiimoteBatteryLabel);
            this.wiimoteBattery.Controls.Add(this.wiimoteBatteryBar);
            this.wiimoteBattery.Location = new System.Drawing.Point(12, 12);
            this.wiimoteBattery.Name = "wiimoteBattery";
            this.wiimoteBattery.Size = new System.Drawing.Size(129, 43);
            this.wiimoteBattery.TabIndex = 1;
            this.wiimoteBattery.TabStop = false;
            this.wiimoteBattery.Text = "Batería Wiimote";
            // 
            // wiimoteBatteryLabel
            // 
            this.wiimoteBatteryLabel.AutoSize = true;
            this.wiimoteBatteryLabel.Location = new System.Drawing.Point(91, 19);
            this.wiimoteBatteryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wiimoteBatteryLabel.Name = "wiimoteBatteryLabel";
            this.wiimoteBatteryLabel.Size = new System.Drawing.Size(21, 13);
            this.wiimoteBatteryLabel.TabIndex = 1;
            this.wiimoteBatteryLabel.Text = "0%";
            // 
            // wiimoteBatteryBar
            // 
            this.wiimoteBatteryBar.Location = new System.Drawing.Point(6, 18);
            this.wiimoteBatteryBar.Name = "wiimoteBatteryBar";
            this.wiimoteBatteryBar.Size = new System.Drawing.Size(82, 16);
            this.wiimoteBatteryBar.TabIndex = 0;
            // 
            // loadCalibration
            // 
            this.loadCalibration.Location = new System.Drawing.Point(12, 107);
            this.loadCalibration.Name = "loadCalibration";
            this.loadCalibration.Size = new System.Drawing.Size(129, 40);
            this.loadCalibration.TabIndex = 2;
            this.loadCalibration.Text = "Cargar Última Calibración";
            this.loadCalibration.UseVisualStyleBackColor = true;
            this.loadCalibration.Click += new System.EventHandler(this.loadCalibration_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 158);
            this.Controls.Add(this.loadCalibration);
            this.Controls.Add(this.wiimoteBattery);
            this.Controls.Add(this.calibrate);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "WiiDesktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.wiimoteBattery.ResumeLayout(false);
            this.wiimoteBattery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calibrate;
        private System.Windows.Forms.GroupBox wiimoteBattery;
        private System.Windows.Forms.ProgressBar wiimoteBatteryBar;
        private System.Windows.Forms.Button loadCalibration;
        private System.Windows.Forms.Label wiimoteBatteryLabel;
    }
}