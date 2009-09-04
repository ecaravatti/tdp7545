using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WiiDesktop.View
{
    public partial class GScreen : Form
    {
        public GScreen()
        {
            InitializePictureBoxList();
            InitializeComponent();
            //InitializePbConfigImage();
        }


        private void InitializePictureBoxList()
        {
            mouseGestureDisplay = new PictureBox[16];
            for (int i = 0; i < 16; i++)
            {
                mouseGestureDisplay[i] = new PictureBox();
                mouseGestureDisplay[i].Tag = mouseGesturesList[i];
            }
        }

        private void InitializePbConfigImage()
        {
            this.pbGesture.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(
            "WiiDesktop.Resources.Images.configIcon.png"));
        }
     
    }
}