using System.Windows.Forms;
using MouseGestures;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GesturesScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.comboBox23 = new ApplicationsComboBox(MouseGesture.RightLeft);
            this.comboBox22 = new ApplicationsComboBox(MouseGesture.RightDown);
            this.comboBox21 = new ApplicationsComboBox(MouseGesture.RightUp);
            this.comboBox20 = new ApplicationsComboBox(MouseGesture.UpLeft);
            this.comboBox19 = new ApplicationsComboBox(MouseGesture.UpDown);
            this.comboBox18 = new ApplicationsComboBox(MouseGesture.UpRight);
            this.comboBox17 = new ApplicationsComboBox(MouseGesture.Left);
            this.comboBox9 = new ApplicationsComboBox(MouseGesture.Up);
            this.comboBox8 = new ApplicationsComboBox(MouseGesture.LeftDown);
            this.comboBox7 = new ApplicationsComboBox(MouseGesture.LeftRight);
            this.comboBox6 = new ApplicationsComboBox(MouseGesture.LeftUp);
            this.comboBox5 = new ApplicationsComboBox(MouseGesture.DownLeft);
            this.comboBox4 = new ApplicationsComboBox(MouseGesture.DownRight);
            this.comboBox3 = new ApplicationsComboBox(MouseGesture.DownUp);
            this.comboBox2 = new ApplicationsComboBox(MouseGesture.Right);
            this.comboBox1 = new ApplicationsComboBox(MouseGesture.Down);
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbLeftDown = new System.Windows.Forms.PictureBox();
            this.pbLeftRight = new System.Windows.Forms.PictureBox();
            this.pbLeftUp = new System.Windows.Forms.PictureBox();
            this.pbDownLeft = new System.Windows.Forms.PictureBox();
            this.pbDownRight = new System.Windows.Forms.PictureBox();
            this.pbDownUp = new System.Windows.Forms.PictureBox();
            this.pbRightLeft = new System.Windows.Forms.PictureBox();
            this.pbRightDown = new System.Windows.Forms.PictureBox();
            this.pbRightUp = new System.Windows.Forms.PictureBox();
            this.pbUpLeft = new System.Windows.Forms.PictureBox();
            this.pbUpDown = new System.Windows.Forms.PictureBox();
            this.pbUpRight = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();

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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.comboBox23);
            this.groupBox1.Controls.Add(this.comboBox22);
            this.groupBox1.Controls.Add(this.comboBox21);
            this.groupBox1.Controls.Add(this.comboBox20);
            this.groupBox1.Controls.Add(this.comboBox19);
            this.groupBox1.Controls.Add(this.comboBox18);
            this.groupBox1.Controls.Add(this.comboBox17);
            this.groupBox1.Controls.Add(this.comboBox9);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pbRight);
            this.groupBox1.Controls.Add(this.pbDown);
            this.groupBox1.Controls.Add(this.pbLeft);
            this.groupBox1.Controls.Add(this.pbUp);
            this.groupBox1.Controls.Add(this.pbLeftDown);
            this.groupBox1.Controls.Add(this.pbLeftRight);
            this.groupBox1.Controls.Add(this.pbLeftUp);
            this.groupBox1.Controls.Add(this.pbDownLeft);
            this.groupBox1.Controls.Add(this.pbDownRight);
            this.groupBox1.Controls.Add(this.pbDownUp);
            this.groupBox1.Controls.Add(this.pbRightLeft);
            this.groupBox1.Controls.Add(this.pbRightDown);
            this.groupBox1.Controls.Add(this.pbRightUp);
            this.groupBox1.Controls.Add(this.pbUpLeft);
            this.groupBox1.Controls.Add(this.pbUpDown);
            this.groupBox1.Controls.Add(this.pbUpRight);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible Mouse Gestures";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
       
            // 
            // comboBox23
            // 
            this.comboBox23.DataSource = ((object)(resources.GetObject("comboBox23.DataSource")));
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Location = new System.Drawing.Point(69, 307);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(121, 21);
            this.comboBox23.TabIndex = 50;
            // 
            // comboBox22
            // 
            this.comboBox22.DataSource = ((object)(resources.GetObject("comboBox22.DataSource")));
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(69, 267);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(121, 21);
            this.comboBox22.TabIndex = 49;
            // 
            // comboBox21
            // 
            this.comboBox21.DataSource = ((object)(resources.GetObject("comboBox21.DataSource")));
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(69, 231);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(121, 21);
            this.comboBox21.TabIndex = 48;
            // 
            // comboBox20
            // 
            this.comboBox20.DataSource = ((object)(resources.GetObject("comboBox20.DataSource")));
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(69, 183);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(121, 21);
            this.comboBox20.TabIndex = 47;
            // 
            // comboBox19
            // 
            this.comboBox19.DataSource = ((object)(resources.GetObject("comboBox19.DataSource")));
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(69, 147);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(121, 21);
            this.comboBox19.TabIndex = 46;
            // 
            // comboBox18
            // 
            this.comboBox18.DataSource = ((object)(resources.GetObject("comboBox18.DataSource")));
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(69, 111);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(121, 21);
            this.comboBox18.TabIndex = 45;
            // 
            // comboBox17
            // 
            this.comboBox17.DataSource = ((object)(resources.GetObject("comboBox17.DataSource")));
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Location = new System.Drawing.Point(69, 61);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(121, 21);
            this.comboBox17.TabIndex = 44;
            // 
            // comboBox9
            // 
            this.comboBox9.DataSource = ((object)(resources.GetObject("comboBox9.DataSource")));
            this.comboBox9.FormattingEnabled = true;


            this.comboBox9.Location = new System.Drawing.Point(69, 25);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 43;  

            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(264, 307);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 51;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);


            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = ((object)(resources.GetObject("comboBox7.DataSource")));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(264, 267);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 41;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = ((object)(resources.GetObject("comboBox6.DataSource")));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(264, 231);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 40;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = ((object)(resources.GetObject("comboBox5.DataSource")));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(264, 183);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 39;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = ((object)(resources.GetObject("comboBox4.DataSource")));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(264, 147);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 38;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = ((object)(resources.GetObject("comboBox3.DataSource")));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(264, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 37;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = ((object)(resources.GetObject("comboBox2.DataSource")));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(264, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = ((object)(resources.GetObject("comboBox1.DataSource")));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(264, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(207, 61);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(32, 32);
            this.pbRight.TabIndex = 34;
            this.pbRight.TabStop = false;
            // 
            // pbDown
            // 
            this.pbDown.Location = new System.Drawing.Point(207, 25);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(32, 32);
            this.pbDown.TabIndex = 32;
            this.pbDown.TabStop = false;
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(10, 59);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(32, 32);
            this.pbLeft.TabIndex = 30;
            this.pbLeft.TabStop = false;
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
            // pbLeftDown
            // 
            this.pbLeftDown.Location = new System.Drawing.Point(207, 307);
            this.pbLeftDown.Name = "pbLeftDown";
            this.pbLeftDown.Size = new System.Drawing.Size(32, 32);
            this.pbLeftDown.TabIndex = 26;
            this.pbLeftDown.TabStop = false;
            // 
            // pbLeftRight
            // 
            this.pbLeftRight.Location = new System.Drawing.Point(207, 269);
            this.pbLeftRight.Name = "pbLeftRight";
            this.pbLeftRight.Size = new System.Drawing.Size(32, 32);
            this.pbLeftRight.TabIndex = 24;
            this.pbLeftRight.TabStop = false;
            // 
            // pbLeftUp
            // 
            this.pbLeftUp.Location = new System.Drawing.Point(207, 231);
            this.pbLeftUp.Name = "pbLeftUp";
            this.pbLeftUp.Size = new System.Drawing.Size(32, 32);
            this.pbLeftUp.TabIndex = 22;
            this.pbLeftUp.TabStop = false;
            // 
            // pbDownLeft
            // 
            this.pbDownLeft.Location = new System.Drawing.Point(207, 183);
            this.pbDownLeft.Name = "pbDownLeft";
            this.pbDownLeft.Size = new System.Drawing.Size(32, 32);
            this.pbDownLeft.TabIndex = 20;
            this.pbDownLeft.TabStop = false;
            // 
            // pbDownRight
            // 
            this.pbDownRight.Location = new System.Drawing.Point(207, 147);
            this.pbDownRight.Name = "pbDownRight";
            this.pbDownRight.Size = new System.Drawing.Size(32, 32);
            this.pbDownRight.TabIndex = 18;
            this.pbDownRight.TabStop = false;
            // 
            // pbDownUp
            // 
            this.pbDownUp.Location = new System.Drawing.Point(207, 111);
            this.pbDownUp.Name = "pbDownUp";
            this.pbDownUp.Size = new System.Drawing.Size(32, 32);
            this.pbDownUp.TabIndex = 16;
            this.pbDownUp.TabStop = false;
            // 
            // pbRightLeft
            // 
            this.pbRightLeft.Location = new System.Drawing.Point(10, 305);
            this.pbRightLeft.Name = "pbRightLeft";
            this.pbRightLeft.Size = new System.Drawing.Size(32, 32);
            this.pbRightLeft.TabIndex = 10;
            this.pbRightLeft.TabStop = false;
            // 
            // pbRightDown
            // 
            this.pbRightDown.Location = new System.Drawing.Point(10, 267);
            this.pbRightDown.Name = "pbRightDown";
            this.pbRightDown.Size = new System.Drawing.Size(32, 32);
            this.pbRightDown.TabIndex = 8;
            this.pbRightDown.TabStop = false;
            // 
            // pbRightUp
            // 
            this.pbRightUp.Location = new System.Drawing.Point(10, 229);
            this.pbRightUp.Name = "pbRightUp";
            this.pbRightUp.Size = new System.Drawing.Size(32, 32);
            this.pbRightUp.TabIndex = 6;
            this.pbRightUp.TabStop = false;
            // 
            // pbUpLeft
            // 
            this.pbUpLeft.Location = new System.Drawing.Point(10, 181);
            this.pbUpLeft.Name = "pbUpLeft";
            this.pbUpLeft.Size = new System.Drawing.Size(32, 32);
            this.pbUpLeft.TabIndex = 4;
            this.pbUpLeft.TabStop = false;
            // 
            // pbUpDown
            // 
            this.pbUpDown.Location = new System.Drawing.Point(10, 145);
            this.pbUpDown.Name = "pbUpDown";
            this.pbUpDown.Size = new System.Drawing.Size(32, 32);
            this.pbUpDown.TabIndex = 2;
            this.pbUpDown.TabStop = false;
            // 
            // pbUpRight
            // 
            this.pbUpRight.Location = new System.Drawing.Point(10, 109);
            this.pbUpRight.Name = "pbUpRight";
            this.pbUpRight.Size = new System.Drawing.Size(32, 32);
            this.pbUpRight.TabIndex = 0;
            this.pbUpRight.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(171, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 22);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GesturesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 392);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GesturesScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mouse Gesture Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
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

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbUpRight;
        private System.Windows.Forms.PictureBox pbRightLeft;
        private System.Windows.Forms.PictureBox pbRightDown;
        private System.Windows.Forms.PictureBox pbRightUp;
        private System.Windows.Forms.PictureBox pbUpLeft;
        private System.Windows.Forms.PictureBox pbUpDown;
        private System.Windows.Forms.PictureBox pbLeftDown;
        private System.Windows.Forms.PictureBox pbLeftRight;
        private System.Windows.Forms.PictureBox pbLeftUp;
        private System.Windows.Forms.PictureBox pbDownLeft;
        private System.Windows.Forms.PictureBox pbDownRight;
        private System.Windows.Forms.PictureBox pbDownUp;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbUp;
        private ApplicationsComboBox comboBox2;
        private ApplicationsComboBox comboBox9;
        private ApplicationsComboBox comboBox7;
        private ApplicationsComboBox comboBox6;
        private ApplicationsComboBox comboBox5;
        private ApplicationsComboBox comboBox4;
        private ApplicationsComboBox comboBox3;
        private ApplicationsComboBox comboBox1;
        private ApplicationsComboBox comboBox18;
        private ApplicationsComboBox comboBox17;
        private ApplicationsComboBox comboBox19;
        private ApplicationsComboBox comboBox23;
        private ApplicationsComboBox comboBox22;
        private ApplicationsComboBox comboBox21;
        private ApplicationsComboBox comboBox20;
        private ApplicationsComboBox comboBox8;
        private Button btnSave;

    }














}