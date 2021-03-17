using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord;
using Accord.Audio;
using Accord.Audio.Windows;
using Accord.DirectSound;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Graduate_App
{
    public enum mode { playing_from_file, editor, playing_from_smth}

    public partial class Form1 : Form
    {
        void ForSaveFiles()
        {
            BinaryFormatter bf = new BinaryFormatter();   
            FileStream fs = new FileStream(chosenfile, FileMode.Create, FileAccess.Write);    

            bf.Serialize(fs, f2.magnetlist);
            bf.Serialize(fs, f2.BackColor);
            bf.Serialize(fs, element.Penelem.Color);
            bf.Serialize(fs, element.Penelem.Width);
            for(int i = 0; i < magbutlist.Count; i++)
            {
                bf.Serialize(fs, magbutlist[i].Enabled);
            }
            bf.Serialize(fs, f2.Height);
            bf.Serialize(fs, f2.Width);

            fs.Close();
        }

        void ForLoadFiles()
        {
            BinaryFormatter bf = new BinaryFormatter();       
            FileStream fs = new FileStream(chosenfile, FileMode.Open, FileAccess.Read);    

            f2.magnetlist = (List<magnet>)bf.Deserialize(fs);
            f2.BackColor = (Color)bf.Deserialize(fs);
            element.Penelem.Color = (Color)bf.Deserialize(fs);
            element.Penelem.Width = (float)bf.Deserialize(fs);
            for (int i = 0; i < magbutlist.Count; i++)
            {
                magbutlist[i].Enabled = (bool)bf.Deserialize(fs);
            }
            f2.Height = (int)bf.Deserialize(fs);
            f2.Width = (int)bf.Deserialize(fs);

            fs.Close();
            itwasalreadyopened = true;
            numericUpDown2.Value = (decimal)element.Penelem.Width;
            numericUpDown1.Value = (decimal)f2.magnetlist.Count();
            f2.P = f2.magnetlist.Count; 
        }

        Form2 f2;
        Random rnd;
        string chosenfile;

        List<Button> magbutlist;
        CustomDialog1 cd1;
        List<int> framesizes;

        bool itwasalreadyopened;

        public Form1()
        {
            
            InitializeComponent();
            itwasalreadyopened = false;
             f2 = new Form2();
             f2.Show();
             rnd = new Random();
            f2.Visible = false;
            magbutlist = new List<Button>();
            magbutlist.Add(magbut1);
            magbutlist.Add(magbut2);
            magbutlist.Add(magbut3);
            magbutlist.Add(magbut4);
            magbutlist.Add(magbut5);
            magbutlist.Add(magbut6);
            magbutlist.Add(magbut7);
            magbutlist.Add(magbut8);
            framesizes = new List<int>() { 8820, 4410, 2205, 1100, 550, 225, 110, 55, 25, };     
            numericUpDown2.Value = (decimal)element.Penelem.Width;
            for (int i = 0; i < framesizes.Count; i++)
            {
                comboBox3.Items.Add(framesizes[i]);
            }
            comboBox3.SelectedIndex = 0;

            numericUpDown3.Value = (decimal)Form2.Deltacolor_k;

        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        public OpenFileDialog OpenFileDialog1
        {
            get { return openFileDialog1; }
            set { openFileDialog1 = value; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f2.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (itwasalreadyopened == false)
            {
                f2.Newp = Convert.ToInt32(numericUpDown1.Value);
                if (f2.Newp > f2.P)
                {
                    for (int i = 0; i < f2.Newp - f2.P; i++)
                    {
                        f2.magnetlist.Add(new magnet(rnd.Next(10, 1500), rnd.Next(10, 800)));
                        magbutlist[f2.magnetlist.Count - 1].Enabled = true;
                        f2.magnetlist[f2.magnetlist.Count - 1].number = f2.magnetlist.Count;
                        if (f2.magnetlist.Count % 2 == 0)
                        { f2.magnetlist[f2.magnetlist.Count - 1].Plusisup = true; }
                        else
                        { f2.magnetlist[f2.magnetlist.Count - 1].Plusisup = false; }

                        switch (f2.magnetlist.Count())
                        {
                            case 1:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.Q;
                                break;
                            case 2:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.W;
                                break;
                            case 3:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.E;
                                break;
                            case 4:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.R;
                                break;
                            case 5:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.T;
                                break;
                            case 6:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.Y;
                                break;
                            case 7:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.U;
                                break;
                            case 8:
                                f2.magnetlist[f2.magnetlist.Count() - 1].Buttonname = Keys.I;
                                break;
                        }
                    }
                    f2.P = f2.Newp;
                }
                else
                {
                    for (int i = 0; i < f2.P - f2.Newp; i++)
                    {
                        f2.magnetlist.RemoveAt(f2.magnetlist.Count - 1);
                        magbutlist[f2.magnetlist.Count].Enabled = false;
                    }
                }
                f2.P = f2.Newp;
                f2.Refresh();
            }
            else
            { itwasalreadyopened = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Visible = true;
            f2.Presentmode = mode.playing_from_file;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void formagbutclicks(int num)
        {
            cd1 = new CustomDialog1(f2.magnetlist[num], num, f2.magnetlist[num].met);
            cd1.FC += new MagnetEventHandler(this.updateMagnet);
            cd1.Text = "проводник " + Convert.ToString(num + 1);
            cd1.ShowDialog();
        }

        private void magbut1_Click(object sender, EventArgs e)
        {
            formagbutclicks(0);
        }

        private void magbut2_Click(object sender, EventArgs e)
        {
            formagbutclicks(1);
        }

        private void magbut3_Click(object sender, EventArgs e)
        {
            formagbutclicks(2);
        }

        private void magbut4_Click(object sender, EventArgs e)
        {
            formagbutclicks(3);
        }

        private void magbut5_Click(object sender, EventArgs e)
        {
            formagbutclicks(4);
        }

        private void magbut6_Click(object sender, EventArgs e)
        {
            formagbutclicks(5);
        }

        private void magbut7_Click(object sender, EventArgs e)
        {
            formagbutclicks(6);
        }

        private void magbut8_Click(object sender, EventArgs e)
        {
            formagbutclicks(7);
        }

        private void updateMagnet(object sender, MagnetEventArgs e)
        {
            f2.magnetlist[e.num].LowpassFrequency = e.lpff;
            f2.magnetlist[e.num].HightpassFrequency = e.hpff;
            f2.magnetlist[e.num].On = e.onoff;
            f2.magnetlist[e.num].met = e.met;
            f2.magnetlist[e.num].I = e.i;
            f2.magnetlist[e.num].Plusisup = e.plusisup;
            f2.magnetlist[e.num].Colorforelem = e.color_for_el;
            f2.magnetlist[e.num].ChangingElectricityWay = e.changingElectricityWay;
        }

        

        private void button_editor_Click(object sender, EventArgs e)
        {
            f2.Visible = true;
            f2.Presentmode = mode.editor;
            f2.oldcolor = magnet.Br.Color;
            magnet.Br.Color = Color.Red;
            f2.Tesxtbox1.Visible = true;
            f2.Groupbox1.Visible = true;
        }

        private void button_playingfromAUX_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                f2.Visible = true;
                f2.Presentmode = mode.playing_from_smth;
                f2.DeviceComboBox.SelectedIndex = comboBox1.SelectedIndex;
                f2.Framesize = (int)comboBox3.SelectedItem;
                f2.Tesxtbox1.Visible = false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);

            // Enumerate audio devices and add all devices to combo
            var audioDevices = new AudioDeviceCollection(AudioDeviceCategory.Capture);

            foreach (AudioDeviceInfo device in audioDevices)
                comboBox1.Items.Add(device);

            // Set a message if there is none
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("No local capture devices");
                comboBox1.Enabled = false;
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            f2.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            element.Penelem.Color = colorDialog1.Color;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            element.Penelem.Width = (float)numericUpDown2.Value;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            chosenfile = saveFileDialog1.FileName;
            ForSaveFiles();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            { f2.Color_mode = colormode.mixedcolor; }
            else
            { f2.Color_mode = colormode.onecolor; }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog2.FileName;
            f2.playingFileName = openFileDialog2.FileName;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Form2.Deltacolor_k = (float)numericUpDown3.Value;
        }

        private void openFileDialog1_FileOk_2(object sender, CancelEventArgs e)
        {
            chosenfile = openFileDialog1.FileName;
            ForLoadFiles();
            f2.Refresh();
        }

        private void updatefrom_but_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var audioDevices = new AudioDeviceCollection(AudioDeviceCategory.Capture);

            foreach (AudioDeviceInfo device in audioDevices)
                comboBox1.Items.Add(device);

            // Set a message if there is none
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("No local capture devices");
                comboBox1.Enabled = false;
            }

            comboBox1.SelectedIndex = 0;
        }
    } 
} 
