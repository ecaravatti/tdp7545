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
            this.wiimoteBatteryBar = new System.Windows.Forms.ProgressBar();
            this.loadCalibration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wiimoteBattery.SuspendLayout();
            this.SuspendLayout();
            // 
            // calibrate
            // 
            this.calibrate.Location = new System.Drawing.Point(30, 123);
            this.calibrate.Name = "calibrate";
            this.calibrate.Size = new System.Drawing.Size(111, 40);
            this.calibrate.TabIndex = 0;
            this.calibrate.Text = "Calibrar";
            this.calibrate.UseVisualStyleBackColor = true;
            this.calibrate.Click += new System.EventHandler(this.calibrate_Click);
            // 
            // wiimoteBattery
            // 
            this.wiimoteBattery.Controls.Add(this.label2);
            this.wiimoteBattery.Controls.Add(this.label1);
            this.wiimoteBattery.Controls.Add(this.wiimoteBatteryBar);
            this.wiimoteBattery.Location = new System.Drawing.Point(30, 41);
            this.wiimoteBattery.Name = "wiimoteBattery";
            this.wiimoteBattery.Size = new System.Drawing.Size(231, 57);
            this.wiimoteBattery.TabIndex = 1;
            this.wiimoteBattery.TabStop = false;
            this.wiimoteBattery.Text = "Batería Wiimote";
            // 
            // wiimoteBatteryBar
            // 
            this.wiimoteBatteryBar.Location = new System.Drawing.Point(29, 25);
            this.wiimoteBatteryBar.Name = "wiimoteBatteryBar";
            this.wiimoteBatteryBar.Size = new System.Drawing.Size(170, 19);
            this.wiimoteBatteryBar.TabIndex = 0;
            // 
            // loadCalibration
            // 
            this.loadCalibration.Location = new System.Drawing.Point(154, 123);
            this.loadCalibration.Name = "loadCalibration";
            this.loadCalibration.Size = new System.Drawing.Size(107, 40);
            this.loadCalibration.TabIndex = 2;
            this.loadCalibration.Text = "Cargar Última Calibración";
            this.loadCalibration.UseVisualStyleBackColor = true;
            this.loadCalibration.Click += new System.EventHandler(this.loadCalibration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.loadCalibration);
            this.Controls.Add(this.wiimoteBattery);
            this.Controls.Add(this.calibrate);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "WiiDesktop";
            this.wiimoteBattery.ResumeLayout(false);
            this.wiimoteBattery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calibrate;
        private System.Windows.Forms.GroupBox wiimoteBattery;
        private System.Windows.Forms.ProgressBar wiimoteBatteryBar;
        private System.Windows.Forms.Button loadCalibration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}