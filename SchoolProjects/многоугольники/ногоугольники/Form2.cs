using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ногоугольники
{
    public partial class Form2 : Form
    {
        public event RadiusEventHandler RC;       //??????    делегат
        public event RadiusUndoAddEventHandler RUE;

        public float lastrad;
        public Form2()
        {
            InitializeComponent(); 
        }

        public TrackBar TrackBar1
        {
            get { return trackBar1; }
            set { trackBar1 = value; }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (this.RC != null)
            {
                this.RC(this, new RadiusEventArgs(trackBar1.Value));     //????????
            }

            label1.Text = Convert.ToString(trackBar1.Value);
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            if(this.RUE != null)
            {
                this.RUE(this, new RadiusUndoAddEventArgs(lastrad));
            }
        }
    }
}
