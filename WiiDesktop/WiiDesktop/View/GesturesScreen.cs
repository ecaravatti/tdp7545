using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MouseGestures;
using System.Reflection;
using System.IO;
using WiiDesktop.Domain.Gestures;

namespace WiiDesktop.View
{
    public partial class GesturesScreen : Form
    {


        private PictureBox[] mouseGestureDisplay;

        public GesturesScreen()
        {
            InitializeComponent();
            mouseGestureDisplay = new PictureBox[16];

            pbUp.Tag = MouseGesture.Up;
            pbRight.Tag = MouseGesture.Right;
            pbDown.Tag = MouseGesture.Down;
            pbLeft.Tag = MouseGesture.Left;

            pbUpRight.Tag = MouseGesture.UpRight;
            pbUpDown.Tag = MouseGesture.UpDown;
            pbUpLeft.Tag = MouseGesture.UpLeft;

            pbRightUp.Tag = MouseGesture.RightUp;
            pbRightDown.Tag = MouseGesture.RightDown;
            pbRightLeft.Tag = MouseGesture.RightLeft;

            pbDownUp.Tag = MouseGesture.DownUp;
            pbDownRight.Tag = MouseGesture.DownRight;
            pbDownLeft.Tag = MouseGesture.DownLeft;

            pbLeftUp.Tag = MouseGesture.LeftUp;
            pbLeftRight.Tag = MouseGesture.LeftRight;
            pbLeftDown.Tag = MouseGesture.LeftDown;

            mouseGestureDisplay[0] = pbUp;
            mouseGestureDisplay[1] = pbRight;
            mouseGestureDisplay[2] = pbDown;
            mouseGestureDisplay[3] = pbLeft;

            mouseGestureDisplay[4] = pbUpRight;
            mouseGestureDisplay[5] = pbUpDown;
            mouseGestureDisplay[6] = pbUpLeft;

            mouseGestureDisplay[7] = pbRightUp;
            mouseGestureDisplay[8] = pbRightDown;
            mouseGestureDisplay[9] = pbRightLeft;

            mouseGestureDisplay[10] = pbDownUp;
            mouseGestureDisplay[11] = pbDownRight;
            mouseGestureDisplay[12] = pbDownLeft;

            mouseGestureDisplay[13] = pbLeftUp;
            mouseGestureDisplay[14] = pbLeftRight;
            mouseGestureDisplay[15] = pbLeftDown;
        }

        private void ResetImages()
        {
            foreach (PictureBox pb in mouseGestureDisplay)
            {
                Stream a = Assembly.GetExecutingAssembly().GetManifestResourceStream(
                  getResourceName((MouseGesture)pb.Tag, false));
                pb.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(
                  getResourceName((MouseGesture)pb.Tag, false)));
            }
        }

        //Build full name of the resource
        private string getResourceName(MouseGesture mg, bool activeImage)
        {
            string active = "";
            if (activeImage)
                active = "A";

            string gestureName = Enum.GetName(typeof(MouseGesture), (MouseGesture)mg);
            string returnValue = "WiiDesktop.Resources.Images." + gestureName + active + ".png";
            return returnValue;
        }

        private void mouseGesturesTest_Gesture(object sender, MouseGestureEventArgs e)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = GestureConfiguration.Instance.ResolveCommand(e.Gesture);
                process.Start();
            }
            catch (Exception) {
                // No hay comando configurado para el gesto detectado
            }
            foreach (PictureBox pb in mouseGestureDisplay)
            {
                if ((MouseGesture)pb.Tag == e.Gesture)
                {
                    //load image from the resources
                    pb.Image = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(
              getResourceName(e.Gesture, true)));
//                    timerReset.Start();
                    return;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetImages();
            // Si existe uan configuración guardada, cargo los combos
             Dictionary<MouseGesture, String> configMap = GestureConfiguration.Instance.GetConfigurationCopy();
             SetDropDowns(configMap);
        }

        private void SetDropDowns(Dictionary<MouseGesture, String> configMap)
        {
            foreach (KeyValuePair<MouseGesture, String> item in configMap)
            {
                switch (item.Key) 
                {
                    case MouseGesture.Down:
                        this.comboBox1.setOption(item.Value);
                        break;
                    case MouseGesture.DownLeft:
                        this.comboBox5.setOption(item.Value);
                        break;
                    case MouseGesture.DownRight:
                        this.comboBox4.setOption(item.Value);
                        break;
                    case MouseGesture.DownUp:
                        this.comboBox3.setOption(item.Value);
                        break;
                    case MouseGesture.Left:
                        this.comboBox17.setOption(item.Value);
                        break;
                    case MouseGesture.LeftDown:
                        this.comboBox8.setOption(item.Value);
                        break;
                    case MouseGesture.LeftRight:
                        this.comboBox7.setOption(item.Value);
                        break;
                    case MouseGesture.LeftUp:
                        this.comboBox6.setOption(item.Value);
                        break;
                    case MouseGesture.Right:
                        this.comboBox2.setOption(item.Value);
                        break;
                    case MouseGesture.RightDown:
                        this.comboBox22.setOption(item.Value);
                        break;
                    case MouseGesture.RightLeft:
                        this.comboBox23.setOption(item.Value);
                        break;
                    case MouseGesture.RightUp:
                        this.comboBox21.setOption(item.Value);
                        break;
                    case MouseGesture.Up:
                        this.comboBox9.setOption(item.Value);
                        break;
                    case MouseGesture.UpDown:
                        this.comboBox19.setOption(item.Value);
                        break;
                    case MouseGesture.UpLeft:
                        this.comboBox20.setOption(item.Value);
                        break;
                    case MouseGesture.UpRight:
                        this.comboBox18.setOption(item.Value);
                        break;
                }
            }


        }
        
        private void pbUp_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GestureConfiguration.Instance.SaveConfiguration();
            this.Close();
        }
    }
}