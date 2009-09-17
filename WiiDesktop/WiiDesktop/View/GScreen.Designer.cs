using System.ComponentModel;
using MouseGestures;
using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using WiiDesktop.Domain.Gestures;
using System.Drawing;
namespace WiiDesktop.View
{
    partial class GScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbGesture;
        private MouseGestures.MouseGestures mouseGesturesTest;
        private System.Windows.Forms.Timer timerReset;
        private PictureBox[] mouseGestureDisplay;
        private MouseGesture[] mouseGesturesList = new MouseGesture[16]{MouseGesture.Up, MouseGesture.Right ,MouseGesture.Down, 
        MouseGesture.Left, MouseGesture.UpRight, MouseGesture.UpDown, MouseGesture.UpLeft, MouseGesture.RightUp, MouseGesture.RightDown, 
        MouseGesture.RightLeft, MouseGesture.DownUp, MouseGesture.DownRight, MouseGesture.DownLeft, MouseGesture.LeftUp,
        MouseGesture.LeftRight, MouseGesture.LeftDown};


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
            this.components = new System.ComponentModel.Container();
            this.pbGesture = new System.Windows.Forms.PictureBox();
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mouseGesturesTest = new MouseGestures.MouseGestures(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGesture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGesture
            // 
            this.pbGesture.Location = new System.Drawing.Point(20, 28);
            this.pbGesture.Name = "pbGesture";
            this.pbGesture.Size = new System.Drawing.Size(46, 50);
            this.pbGesture.TabIndex = 0;
            this.pbGesture.TabStop = false;
            // 
            // timerReset
            // 
            this.timerReset.Interval = 500;
            this.timerReset.Tick += new System.EventHandler(this.timerReset_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbGesture);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area de Gestos";
            // 
            // mouseGesturesTest
            // 
            this.mouseGesturesTest.Gesture += new MouseGestures.MouseGestures.GestureHandler(this.mouseGestures_Gesture);
            // 
            // GScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pbGesture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private void mouseGestures_Gesture(object sender, MouseGestureEventArgs e)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = GestureConfiguration.Instance.ResolveCommand(e.Gesture);
                process.Start();
            }
            catch (Exception)
            {
                // No hay comando configurado para el gesto detectado
            }
            foreach (PictureBox pb in mouseGestureDisplay)
            {
                if ((MouseGesture)pb.Tag == e.Gesture)
                {
                    //load image from the resources
                    pbGesture.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(
              getResourceName(e.Gesture, true)));
                    timerReset.Start();
                    return;
                }
            }
        }

        private void timerReset_Tick(object sender, EventArgs e)
        {
            //resets images to normal
            timerReset.Stop();
        }

        //Build full name of the resource
        private string getResourceName(MouseGesture mg, bool activeImage)
        {
            string gestureName = Enum.GetName(typeof(MouseGesture), (MouseGesture)mg);
            string returnValue = "WiiDesktop.Resources.Images." + gestureName + ".png";
            return returnValue;
        }

        private GroupBox groupBox1;
    }
}