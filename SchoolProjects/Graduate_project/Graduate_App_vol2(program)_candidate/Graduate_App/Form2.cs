using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Diagnostics;
using System.Media;
using System.IO;

using NUnit.Framework;
using Accord.Audio.Filters;
using Accord.Math;
using Accord.Audio.Generators;
using Accord.Audio.Windows;
using Accord.Audio.Formats;
using SharpDX;
using Accord.Audio;
using Accord;
using Accord.DirectSound;

namespace Graduate_App
{
    public enum colormode { onecolor, mixedcolor };

    public partial class Form2 : Form
    {

        public float newmaxsample(Signal sig, int position, int num)
        {
            float maxsam = 0;
            bool plus = true;
            if (sig.Length >= position + num)
            {
                for (int i = 0; i < num; i++)
                {
                    if (Math.Abs(sig.GetSample(1, position + i)) > maxsam)
                    {
                        maxsam = Math.Abs(sig.GetSample(1, position + i));
                        if(sig.GetSample(1, position + i) > 0)
                        {
                            plus = true;
                        }
                        else
                        {
                            plus = false;
                        }
                    }
                }
            }
            if (maxsam < 0.0001)
            { maxsam = 0; }

            if(plus == false)
            { maxsam = maxsam * (-1); }
            return maxsam;
        }

        public float maxsample(Signal sig, int position, int num)
        {
            float maxsam = 0;
            if (sig.Length >= position + num)
            {
                for (int i = 0; i < num; i++)
                {
                    if (Math.Abs(sig.GetSample(1, position + i)) > maxsam)
                    {
                        maxsam = Math.Abs(sig.GetSample(1, position + i));
                    }
                }
            }
            if (maxsam < 0.0001)
            { maxsam = 0; }
            return maxsam;
        }


        public int deltacolorRGB(int param, float b_vec)
        {
            if (b_vec == 0)
            {
                return 255;
            }
            else
            {
                float newparam = (deltacolor_k * (255 - param) )/ b_vec;
                if (newparam > (255 - param))
                {
                    newparam = 255 - param;
                }

                if (newparam > 255)
                {
                    newparam = 255;
                }

                int newparamtoint = 0;
                if (newparam < 1)
                {
                    newparamtoint = 1;
                }
                else
                {
                    newparamtoint = Convert.ToInt32(newparam);
                }
                return newparamtoint;
            }
        }

        public Color newcolor(Color mag_color, float b_vec)
        {
            Color newcolor;
            int r, g, b;
            Color updatedcolor = Color.Black;
            r = mag_color.R + deltacolorRGB(mag_color.R, b_vec);
            g = mag_color.G + deltacolorRGB(mag_color.G, b_vec);
            b = mag_color.B + deltacolorRGB(mag_color.B, b_vec);

            if (r > 255)
            {
                r = 255;
            }
            if (g > 255)
            {
                g = 255;
            }
            if (b > 255)
            {
                b = 255;
            }

            newcolor = Color.FromArgb(r, g, b);
            return newcolor;
        }

        public Color elemColorPlusNewColor(Color elem_Color, Color new_Color)
        {
            Color final_Color;

            int lastr = elem_Color.R + new_Color.R;
            int lastg = elem_Color.G + new_Color.G;
            int lastb = elem_Color.B + new_Color.B;
            if (lastr > 255)
            {
                lastr = 255;
            }
            if (lastg > 255)
            {
                lastg = 255;
            }
            if (lastb > 255)
            {
                lastb = 255;
            }
            
            final_Color = Color.FromArgb(lastr, lastg, lastb);

            return final_Color;
        }

        public void elemColorplusNewColr_vol2(ref element el, Color new_Color)
        {
            el.Amtofmag++;
            Color final_Color;
            el.Sum_R = el.Sum_R + new_Color.R;
            el.Sum_G = el.Sum_G + new_Color.G;
            el.Sum_B = el.Sum_B + new_Color.B;

            int lastr = el.Sum_R / 2;//el.Amtofmag;
            int lastg = el.Sum_G / 2;//el.Amtofmag;
            int lastb = el.Sum_B / 2;//el.Amtofmag;

            if (lastr > 255)
            {
                lastr = 255;
            }
            if (lastg > 255)
            {
                lastg = 255;
            }
            if (lastb > 255)
            {
                lastb = 255;
            }

            final_Color = Color.FromArgb(lastr, lastg, lastb);
            el.Mixedcolorpen.Color = final_Color;
        }


        public element parallel_maglines(element el, List<magnet> mag)
        {
            float FinalVecX = 0;
            float FinalVecY = 0;
            bool WasChanged = false;
            // for mixedcolor add if, where el.mixedpen rgb = 000, and delete index in function
            if(color_mode == colormode.mixedcolor )
            {
                try
                {
                    el.Mixedcolorpen.Color = Color.FromArgb(0, 0, 0);
                    el.Sum_R = 0;
                    el.Sum_G = 0;
                    el.Sum_B = 0;
                    el.Amtofmag = 0;
                }
                catch (Exception)
                { }

            }
            Parallel.For(0, mag.Count, n =>
           {
               if (mag[n].On == true && ((el.Xm - mag[n].X) * (el.Xm - mag[n].X) + (el.Ym - mag[n].Y) * (el.Ym - mag[n].Y) >= magnet.R * magnet.R))
               {

                   float k = (el.Ym - mag[n].Y) / (el.Xm - mag[n].X);
                   float b = mag[n].Y - k * mag[n].X;
                   float c = el.Ym + el.Xm / k;
                   float r = (float)Math.Sqrt((el.Xm - mag[n].X) * (el.Xm - mag[n].X) + (el.Ym - mag[n].Y) * (el.Ym - mag[n].Y));

                   float vecB = 0;
                   if(mag[n].ChangingElectricityWay == on_off.on)
                   {
                       float ms = newmaxsample(mag[n].Filteredsignal, position, numofsamples);

                       if (ms < 0)
                           mag[n].Plusisup = false;
                       else
                           mag[n].Plusisup = true;

                        vecB = Math.Abs((int)(ms * mag[n].I) / r);
                   }
                   else
                   {
                        vecB = (int)(maxsample(mag[n].Filteredsignal, position, numofsamples) * mag[n].I) / r;
                   }
                   
                   //float vecB = (int)(maxsample(mag[n].Filteredsignal, position, numofsamples) * mag[n].I) / r;   // !!!!!!!!!!!!
                   float z = k * k + 1;
                   float v = 2 * el.Xm * k - 2 * c * k * k - 2 * el.Ym;
                   float p = c * c * k * k - vecB * vecB - 2 * el.Xm * c * k + el.Xm * el.Xm + el.Ym * el.Ym;    // оптимизировать ?
                    float deskr = v * v - 4 * z * p;

                   float NewVecX = 0;
                   float NewVecY = 0;

                   
                   Color new_Color = Color.White;
                   if(color_mode == colormode.mixedcolor)
                   {
                       new_Color = newcolor(mag[n].Colorforelem, vecB);
                   }

                   if (mag[n].Plusisup == true)
                   {
                       if (el.Xm < mag[n].X)
                       {
                           NewVecY = (float)(-v - Math.Sqrt(deskr)) / (2 * z);
                           NewVecX = c * k - NewVecY * k;
                       }
                       if (el.Xm > mag[n].X)
                       {
                           NewVecY = (float)(-v + Math.Sqrt(deskr)) / (2 * z);
                           NewVecX = c * k - NewVecY * k;
                       }
                       if (deskr < 1 || el.Xm == mag[n].X || Math.Abs(el.Xm - mag[n].X) < 5)
                       {
                           if (el.Ym < mag[n].Y)
                           {
                               NewVecX = el.Xm + vecB;
                               NewVecY = el.Ym;
                           }
                           if (el.Ym > mag[n].Y)
                           {
                               NewVecX = el.Xm - vecB;
                               NewVecY = el.Ym;
                           }
                       }
                   }
                   else
                   {
                       if (el.Xm < mag[n].X)
                       {
                           NewVecY = (float)(-v + Math.Sqrt(deskr)) / (2 * z);
                           NewVecX = c * k - NewVecY * k;
                       }
                       if (el.Xm > mag[n].X)
                       {
                           NewVecY = (float)(-v - Math.Sqrt(deskr)) / (2 * z);
                           NewVecX = c * k - NewVecY * k;
                       }
                       if (deskr < 1 || el.Xm == mag[n].X || Math.Abs(el.Xm - mag[n].X) < 5)
                       {
                           if (el.Ym < mag[n].Y)
                           {
                               NewVecX = el.Xm - vecB;
                               NewVecY = el.Ym;
                           }
                           if (el.Ym > mag[n].Y)
                           {
                               NewVecX = el.Xm + vecB;
                               NewVecY = el.Ym;
                           }
                       }
                   }

                    ////////////////////////////
                    if (WasChanged == false)
                   {
                       FinalVecX = NewVecX;
                       FinalVecY = NewVecY;
                       WasChanged = true;
                   }
                   else
                   {
                       FinalVecX = FinalVecX + NewVecX - el.Xm;             //el.Xm + ((FinalVecX - el.Xm) + (NewVecX - el.Xm));
                        FinalVecY = FinalVecY + NewVecY - el.Ym;             //el.Ym + ((FinalVecY - el.Ym) + (NewVecY - el.Ym));
                    }
                   //

                  /*/ if (color_mode == colormode.mixedcolor)
                   {
                       el.Mixedcolorpen.Color = mixedcolorcounting(el.Mixedcolorpen.Color, mag[n].Colorforelem, vecB);
                   }/*/

               if(color_mode == colormode.mixedcolor)
                   {
                       //Color final_Color = elemColorPlusNewColor(el.Mixedcolorpen.Color, new_Color);
                       try
                       {
                           // el.Mixedcolorpen.Color = final_Color;
                           elemColorplusNewColr_vol2(ref el, new_Color);
                       }
                       catch (Exception)
                       { }
                   }

               }

           });

            if (WasChanged == false)
            {
                return el;
            }
            else
            {

                el.X2 = el.Xm;
                el.Y2 = el.Ym;
                el.X = FinalVecX;
                el.Y = FinalVecY;
            }

            return el;
        }

        

        colormode color_mode;
        bool fullscreen;
        int p;
        int newp;
        int elp;
        public List<element> elemlist = new List<element>() { };
        public List<magnet> magnetlist =  new List<magnet>() { };
        public List<int> listdd = new List<int>() { };
        bool dragdropdobr;
        int ldd;
        public string playingFileName;
        bool itsplaying;
        public Color oldcolor;

        Random rndf2;

        SoundPlayer player;

       static float deltacolor_k;

        int numofsamples; // количество сэмплов на отрезке
        int position;

        mode presentmode;

        ComboBox deviceComboBox;

        public ComboBox DeviceComboBox
        {
            get { return deviceComboBox; }
            set { deviceComboBox = value; }
        }

        static  Form2()
        {
            deltacolor_k = 5;
        }

        public Form2()
        {
            
            color_mode = colormode.onecolor;
            framesize = 8820;
            rndf2 = new Random();
            InitializeComponent();
            fullscreen = false;
            p = 0; //количество магнитов
            newp = 0;
            dragdropdobr = false;
            ldd = 0;
            this.Size = this.MaximumSize;
             elp = 170; // количество опилок

            for(int i = 0; i < elp; i++)
            {
                elemlist.Add(new element(rndf2.Next(8, 1580), rndf2.Next(8, 880)));   //  1942 1089
            }

            player = new SoundPlayer();
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            itsplaying = false;
            deviceComboBox = new ComboBox();
            var audioDevices = new AudioDeviceCollection(AudioDeviceCategory.Capture);
            foreach (AudioDeviceInfo device in audioDevices)
            deviceComboBox.Items.Add(device);
        }

        public static float Deltacolor_k
        {
            get { return deltacolor_k; }
            set { deltacolor_k = value; }
        }

        public GroupBox Groupbox1
        {
            get { return groupBox1; }
            set { groupBox1 = value; }
        }

        public int P
        {
            get { return p; }
            set { p = value; }
        }

        public colormode Color_mode
        {
            get { return color_mode; }
            set { color_mode = value; }
        }

        public TextBox Tesxtbox1
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }

        public int Elp
        {
            get { return elp; }
            set { elp = value; }
        }

        public mode Presentmode
        {
            get { return presentmode; }
            set { presentmode = value; }
        }

        public int Newp
        {
            get { return newp; }
            set { newp = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (presentmode == mode.editor)
            { magnet.Br.Color = oldcolor; }
            this.Visible = false;
            timerForWAV.Stop();
            player.Stop();
            itsplaying = false;

            if (presentmode == mode.playing_from_smth && source != null)
            {
                source.SignalToStop();
                textBox1.Visible = false;
            }
            groupBox1.Visible = false;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (itsplaying == true && presentmode == mode.playing_from_file)
            {
                Parallel.For(0, elp, i => 
                { elemlist[i] = parallel_maglines(elemlist[i], magnetlist); });

                for (int i = 0; i < elp; i++)
                {
                    elemlist[i].drawel(e.Graphics, color_mode);
                }
            }

            if (presentmode == mode.editor)
            {
                for (int i = 0; i < p; i++)  
                {
                    if (magnetlist[i].On == true)
                    magnetlist[i].draw(e.Graphics);
                }
                for (int i = 0; i < elp; i++)
                {
                    elemlist[i].drawel(e.Graphics, color_mode);
                }
            }

            if (presentmode == mode.playing_from_smth && itsplaying == true)
            {
                for (int i = 0; i < elp; i++)
                {
                    elemlist[i].drawel(e.Graphics, color_mode);
                }
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (P > 0)
                {
                    for (int i = 0; i < P; i++)
                    {
                        if (magnetlist[i].zone(e.X, e.Y) == true)   //?????
                        {
                            listdd.Add(i);
                            ldd++;
                            dragdropdobr = true;
                            magnetlist[i].DragdropX = magnetlist[i].X - e.X;
                            magnetlist[i].DragdropY = magnetlist[i].Y - e.Y;
                            textBox1.Text = Convert.ToString(magnetlist[i].number);
                        }
                    }
                }
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragdropdobr == true)
            {
                for (int i = 0; i < ldd; i++)
                {
                    magnetlist[listdd[i]].X = e.X + magnetlist[listdd[i]].DragdropX;
                    magnetlist[listdd[i]].Y = e.Y + magnetlist[listdd[i]].DragdropY;
                    magnetlist[listdd[i]].Lx = magnetlist[listdd[i]].X - magnet.R;
                    magnetlist[listdd[i]].Rx = magnetlist[listdd[i]].X + magnet.R;
                    magnetlist[listdd[i]].Hy = magnetlist[listdd[i]].Y - magnet.R;
                    magnetlist[listdd[i]].Dy = magnetlist[listdd[i]].Y + magnet.R;
                    Refresh();
                }
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dragdropdobr == true)
                {
                    dragdropdobr = false;
                    ldd = 0;
                    listdd.Clear();
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
          
            for(int n = 0; n < magnetlist.Count; n++)
            {
                if (e.KeyCode == magnetlist[n].Buttonname)
                {
                    if (magnetlist[n].On == true)
                    {
                        magnetlist[n].On = false;
                    }
                    else
                    {
                        magnetlist[n].On = true;
                    }
                    Refresh();
                }
            }
        }
       
        private void timerForWAV_Tick(object sender, EventArgs e)
        {
            position += numofsamples;
            if (magnetlist.Count >= 1)
            {
                if (position > magnetlist[0].Filteredsignal.Length)
                {
                    timerForWAV.Stop();
                }
            }
            Refresh();
        }

       IAudioSource source;

        int framesize;
        public int Framesize
        {
            get { return framesize; }
            set { framesize = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(playingFileName != null && presentmode == mode.playing_from_file)
            {
                position = 0;
                for (int i = 0; i < magnetlist.Count(); i++)
                {
                    magnetlist[i].filteredSignal(playingFileName);
                }
                WaveDecoder dec = new WaveDecoder(playingFileName);
               
                numofsamples = timerForWAV.Interval * dec.SampleRate / 1000;
                position = 0;

                player.Stop();
                var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
                player.SoundLocation = Path.Combine(basePath, playingFileName);
                player.Load();
                player.Play();
                timerForWAV.Start();
                itsplaying = true;
            }

            if(presentmode == mode.editor)
            {
                timerForWAV.Stop();
                player.Stop();
                Refresh();
            }


            if (presentmode == mode.playing_from_smth)
            {
                var info = deviceComboBox.SelectedItem as AudioDeviceInfo;

                // Create a new audio capture device
                source = new AudioCaptureDevice(info)
                {
                    // Capture at 22050 Hz
                    DesiredFrameSize = framesize,   // секунда * framesize / samplerate   8820  4410 2205 1100 550 225 110 55 25
                    SampleRate = 44100        // 44100
                };

                position = 0;

                // Wire up some notification events
                source.NewFrame += source_NewFrame;
                source.AudioSourceError += source_AudioSourceError;   // пока не надо

                itsplaying = true;
                // Start it!
                source.Start();
            }

        }

        void source_AudioSourceError(object sender, AudioSourceErrorEventArgs e)
        {
            throw new Exception(e.Description);
        }

        void source_NewFrame(object sender, NewFrameEventArgs eventArgs)
        { 
            Parallel.For(0, magnetlist.Count(), i =>
            { magnetlist[i].filteredSignal(eventArgs.Signal); });

            numofsamples = eventArgs.Signal.Length;

            Parallel.For(0, elp, i =>
            { elemlist[i] = parallel_maglines(elemlist[i], magnetlist); });

            position = 0;
            UpdateForm(this);
        }

        protected override void OnLoad(EventArgs e)
        {
        
        }

        void UpdateForm(Form form)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    form.Refresh();
                }));
            else
            {
                form.Refresh();
            }
        }

        void UpdateTitle(TextBox textbox, string text)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    textbox.Text = text;
                }));
            else
            {
                textbox.Text = text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Height-=4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Height+=4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Width-=4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Width+=4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            elemlist.Clear();
            for(int i = 0; i < elp; i++)
            {
                elemlist.Add(new element(rndf2.Next(8, Width), rndf2.Next(8, Height)));
            }
            Refresh();
        }

    }
}
