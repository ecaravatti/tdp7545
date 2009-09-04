using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MouseGestures;
using WiiDesktop.Domain.Gestures;

namespace WiiDesktop.View
{
    public class ApplicationsComboBox : ComboBox
    {
        // Gesto asociado al combo de aplicaciones
        private MouseGesture gesture;

        public ApplicationsComboBox(MouseGesture gesture)
            : base()
        {
            this.gesture = gesture;
            this.DataSource = ApplicationsFinder.GetAvailableApplications();
            this.SelectedIndexChanged += new System.EventHandler(this.OnChange);
        }

        protected void OnChange(object sender, EventArgs e)
        {
            GestureConfiguration.Instance.UpdateCommand(gesture, this.SelectedItem.ToString());
        }

        public void setOption(String option)
        {
            SelectedItem = option;
        }

        
    }
}
