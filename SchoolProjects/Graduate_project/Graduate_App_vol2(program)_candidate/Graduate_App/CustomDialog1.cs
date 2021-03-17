using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduate_App
{

    public partial class CustomDialog1 : Form
    {

        public event MagnetEventHandler FC;

        
        int num;
        bool onoff;
        method met;
        //int i;
        bool plusisup;
        public CustomDialog1(magnet mag, int n, method oldmet)
        {
            InitializeComponent();
            
            button2.BackColor = mag.Colorforelem;
            numericUpDown1.Value = (decimal)mag.LowpassFrequency;
            numericUpDown2.Value = (decimal)mag.HightpassFrequency;
            num = n;
            onoff = mag.On;
            if (onoff == true)
                checkBox1.CheckState = CheckState.Checked;
            else
                checkBox1.CheckState = CheckState.Unchecked;
            switch(oldmet)
            {
                case method.none:
                    lowpasscheckBox.CheckState = CheckState.Unchecked;
                    hightpasscheckBox.CheckState = CheckState.Unchecked;
                    break;
                case method.low:
                    lowpasscheckBox.CheckState = CheckState.Checked;
                    hightpasscheckBox.CheckState = CheckState.Unchecked;
                    break;
                case method.hight:
                    lowpasscheckBox.CheckState = CheckState.Unchecked;
                    hightpasscheckBox.CheckState = CheckState.Checked;
                    break;
                case method.both:
                    lowpasscheckBox.CheckState = CheckState.Checked;
                    hightpasscheckBox.CheckState = CheckState.Checked;
                    break;
            }
            met = oldmet;
           // i = mag.I;
            numericUpDown3.Value = mag.I;

        switch(mag.Plusisup)
            {
                case true:
                    plusisupcheckbox.CheckState = CheckState.Checked;
                    plusisdowncheckbox.CheckState = CheckState.Unchecked;
                    break;
                case false:
                    plusisupcheckbox.CheckState = CheckState.Unchecked;
                    plusisdowncheckbox.CheckState = CheckState.Checked;
                    break;
            }

            textBox1.Text = Convert.ToString(mag.ChangingElectricityWay);
            changing_electric_way_CheckBox.CheckState = CheckState.Unchecked;
            if (mag.ChangingElectricityWay == on_off.off)
            {
                changing_electric_way_CheckBox.CheckState = CheckState.Unchecked;
            }
            if (mag.ChangingElectricityWay == on_off.on)
            {
                changing_electric_way_CheckBox.CheckState = CheckState.Checked;
            }
            //textBox1.Text = Convert.ToString(mag.ChangingElectricityWay);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            on_off elWayCh;
            if(changing_electric_way_CheckBox.CheckState == CheckState.Checked)
            { elWayCh = on_off.on; }
            else
            {
                elWayCh = on_off.off;
            }
            
            if (lowpasscheckBox.CheckState == CheckState.Unchecked && hightpasscheckBox.CheckState == CheckState.Unchecked)
            { met = method.none; }
            if (lowpasscheckBox.CheckState == CheckState.Checked && hightpasscheckBox.CheckState == CheckState.Unchecked)
            { met = method.low; }
            if (lowpasscheckBox.CheckState == CheckState.Unchecked && hightpasscheckBox.CheckState == CheckState.Checked)
            { met = method.hight; }
            if (lowpasscheckBox.CheckState == CheckState.Checked && hightpasscheckBox.CheckState == CheckState.Checked)
            { met = method.both; }

            if (plusisupcheckbox.CheckState == CheckState.Checked)
            { plusisup = true; }
            else
            { plusisup = false; }

            if (this.FC != null)
            {
                this.FC(this, new MagnetEventArgs((double)numericUpDown1.Value, (double)numericUpDown2.Value, num, onoff, met, (int)numericUpDown3.Value, plusisup, button2.BackColor, elWayCh));    
            }
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    onoff = true;
                    break;
                case CheckState.Unchecked:
                    onoff = false;
                    break;
            }
        }

        private void plusisdowncheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if(plusisdowncheckbox.CheckState == CheckState.Checked)
            {
                plusisupcheckbox.CheckState = CheckState.Unchecked;
            }
        }

        private void plusisupcheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (plusisupcheckbox.CheckState == CheckState.Checked)
            {
                plusisdowncheckbox.CheckState = CheckState.Unchecked;
            }
        }

        private void CustomDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button2.BackColor;
            colorDialog1.ShowDialog();
            button2.BackColor = colorDialog1.Color;
        }

        private void changing_electric_way_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


    public class MagnetEventArgs : EventArgs
    {
        public double lpff, hpff;
        public int num;
        public bool onoff;
        public method met;
        public int i;
        public bool plusisup;
        public Color color_for_el;
        public on_off changingElectricityWay;
        public MagnetEventArgs(double ll, double hh, int nn, bool nff, method meth, int ii, bool plusis, Color cfel, on_off elWayCh)
        {
            lpff = ll;
            hpff = hh;
            num = nn;
            onoff = nff;
            met = meth;
            i = ii;
            plusisup = plusis;
            color_for_el = cfel;
            changingElectricityWay = elWayCh;
        }
    }

    public delegate void MagnetEventHandler(object sender, MagnetEventArgs e);


    
}
