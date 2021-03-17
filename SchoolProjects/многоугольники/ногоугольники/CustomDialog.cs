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
    public partial class CustomDialog : Form
    {
       public int but;
        public CustomDialog( )
        {
            InitializeComponent();
            but = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            but = 1;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            but = 2;
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            but = 3;
            Close();
        }

    }
}
