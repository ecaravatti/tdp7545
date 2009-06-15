using System.Windows.Forms;
namespace WiiDesktop.View
{
    partial class GesturesScreen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pbLeftDown = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pbLeftRight = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pbLeftUp = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pbDownLeft = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pbDownRight = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pbDownUp = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbRightLeft = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbRightDown = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbRightUp = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbUpLeft = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbUpDown = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbUpRight = new System.Windows.Forms.PictureBox();
            this.mouseGesturesTest = new MouseGestures.MouseGestures(this.components);
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpRight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How to perform mouse gesture: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1) Click and hold right mouse button";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2) Move the mouse in the indicated directions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3) Release the right mouse button";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pbRight);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.pbDown);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.pbLeft);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.pbUp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.pbLeftDown);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.pbLeftRight);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.pbLeftUp);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.pbDownLeft);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.pbDownRight);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.pbDownUp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pbRightLeft);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pbRightDown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbRightUp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pbUpLeft);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pbUpRight);
            this.groupBox1.Location = new System.Drawing.Point(337, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible Mouse Gestures";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(245, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "Right";
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(207, 61);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(32, 32);
            this.pbRight.TabIndex = 34;
            this.pbRight.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(245, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Down";
            // 
            // pbDown
            // 
            this.pbDown.Location = new System.Drawing.Point(207, 25);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(32, 32);
            this.pbDown.TabIndex = 32;
            this.pbDown.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(48, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 24);
            this.label19.TabIndex = 31;
            this.label19.Text = "Left";
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(10, 59);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(32, 32);
            this.pbLeft.TabIndex = 30;
            this.pbLeft.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(48, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 24);
            this.label20.TabIndex = 29;
            this.label20.Text = "Up";
            // 
            // pbUp
            // 
            this.pbUp.Location = new System.Drawing.Point(10, 23);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(32, 32);
            this.pbUp.TabIndex = 28;
            this.pbUp.TabStop = false;
            this.pbUp.Click += new System.EventHandler(this.pbUp_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(245, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Left Down";
            // 
            // pbLeftDown
            // 
            this.pbLeftDown.Location = new System.Drawing.Point(207, 307);
            this.pbLeftDown.Name = "pbLeftDown";
            this.pbLeftDown.Size = new System.Drawing.Size(32, 32);
            this.pbLeftDown.TabIndex = 26;
            this.pbLeftDown.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(245, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 24);
            this.label14.TabIndex = 25;
            this.label14.Text = "Left Right";
            // 
            // pbLeftRight
            // 
            this.pbLeftRight.Location = new System.Drawing.Point(207, 269);
            this.pbLeftRight.Name = "pbLeftRight";
            this.pbLeftRight.Size = new System.Drawing.Size(32, 32);
            this.pbLeftRight.TabIndex = 24;
            this.pbLeftRight.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(245, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "Left Up";
            // 
            // pbLeftUp
            // 
            this.pbLeftUp.Location = new System.Drawing.Point(207, 231);
            this.pbLeftUp.Name = "pbLeftUp";
            this.pbLeftUp.Size = new System.Drawing.Size(32, 32);
            this.pbLeftUp.TabIndex = 22;
            this.pbLeftUp.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(245, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 24);
            this.label16.TabIndex = 21;
            this.label16.Text = "Down Left";
            // 
            // pbDownLeft
            // 
            this.pbDownLeft.Location = new System.Drawing.Point(207, 183);
            this.pbDownLeft.Name = "pbDownLeft";
            this.pbDownLeft.Size = new System.Drawing.Size(32, 32);
            this.pbDownLeft.TabIndex = 20;
            this.pbDownLeft.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(245, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 24);
            this.label17.TabIndex = 19;
            this.label17.Text = "Down Right";
            // 
            // pbDownRight
            // 
            this.pbDownRight.Location = new System.Drawing.Point(207, 147);
            this.pbDownRight.Name = "pbDownRight";
            this.pbDownRight.Size = new System.Drawing.Size(32, 32);
            this.pbDownRight.TabIndex = 18;
            this.pbDownRight.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(245, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 24);
            this.label18.TabIndex = 17;
            this.label18.Text = "Down Up";
            // 
            // pbDownUp
            // 
            this.pbDownUp.Location = new System.Drawing.Point(207, 111);
            this.pbDownUp.Name = "pbDownUp";
            this.pbDownUp.Size = new System.Drawing.Size(32, 32);
            this.pbDownUp.TabIndex = 16;
            this.pbDownUp.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(48, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Right Left";
            // 
            // pbRightLeft
            // 
            this.pbRightLeft.Location = new System.Drawing.Point(10, 305);
            this.pbRightLeft.Name = "pbRightLeft";
            this.pbRightLeft.Size = new System.Drawing.Size(32, 32);
            this.pbRightLeft.TabIndex = 10;
            this.pbRightLeft.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(48, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Right Down";
            // 
            // pbRightDown
            // 
            this.pbRightDown.Location = new System.Drawing.Point(10, 267);
            this.pbRightDown.Name = "pbRightDown";
            this.pbRightDown.Size = new System.Drawing.Size(32, 32);
            this.pbRightDown.TabIndex = 8;
            this.pbRightDown.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(48, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Right Up";
            // 
            // pbRightUp
            // 
            this.pbRightUp.Location = new System.Drawing.Point(10, 229);
            this.pbRightUp.Name = "pbRightUp";
            this.pbRightUp.Size = new System.Drawing.Size(32, 32);
            this.pbRightUp.TabIndex = 6;
            this.pbRightUp.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(48, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Up Left";
            // 
            // pbUpLeft
            // 
            this.pbUpLeft.Location = new System.Drawing.Point(10, 181);
            this.pbUpLeft.Name = "pbUpLeft";
            this.pbUpLeft.Size = new System.Drawing.Size(32, 32);
            this.pbUpLeft.TabIndex = 4;
            this.pbUpLeft.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(48, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Up Down";
            // 
            // pbUpDown
            // 
            this.pbUpDown.Location = new System.Drawing.Point(10, 145);
            this.pbUpDown.Name = "pbUpDown";
            this.pbUpDown.Size = new System.Drawing.Size(32, 32);
            this.pbUpDown.TabIndex = 2;
            this.pbUpDown.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(48, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Up Right";
            // 
            // pbUpRight
            // 
            this.pbUpRight.Location = new System.Drawing.Point(10, 109);
            this.pbUpRight.Name = "pbUpRight";
            this.pbUpRight.Size = new System.Drawing.Size(32, 32);
            this.pbUpRight.TabIndex = 0;
            this.pbUpRight.TabStop = false;
            // 
            // mouseGesturesTest
            // 
            this.mouseGesturesTest.Gesture += new MouseGestures.MouseGestures.GestureHandler(this.mouseGesturesTest_Gesture);
            // 
            // timerReset
            // 
            this.timerReset.Interval = 500;
            this.timerReset.Tick += new System.EventHandler(this.timerReset_Tick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(298, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Tip: You can perform mouse gesture anywhere in the window.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(118, 215);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 24);
            this.label22.TabIndex = 6;
            this.label22.Text = "Let\'s try it...";
            // 
            // GesturesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 374);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GesturesScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mouse Gesture Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbUpRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbRightLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbRightDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbRightUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbUpLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbLeftDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbLeftRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbLeftUp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbDownLeft;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pbDownRight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbDownUp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pbUp;
        private MouseGestures.MouseGestures mouseGesturesTest;
        private System.Windows.Forms.Timer timerReset;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;

    }

}