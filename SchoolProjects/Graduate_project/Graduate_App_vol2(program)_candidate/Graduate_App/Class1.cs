using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Accord.Audio;
using NUnit.Framework;
using Accord.Audio.Filters;
using Accord.Math;
using Accord.Audio.Generators;
using Accord.Audio.Windows;
using Accord.Audio.Formats;
using SharpDX;
using Accord.DirectSound;



using System.Collections;
using System.Diagnostics;
using System.Media;
using System.IO;


namespace Graduate_App
{
   public enum method {none, low, hight, both };

    public enum on_off { on, off };

    [Serializable]
   public class magnet
    {
        protected on_off changingElectricityWay;

       public method met;

        public int number;
        protected float x, y, power, diap, rx, lx, hy, dy;    // i - сила тока 
        int i;  
        protected bool on;
        protected static int r;//, r2;
        protected static Color color1; 
        protected Color colorforelem;
        static SolidBrush b1;
        protected float dragdropX, dragdropY;
        // string buttonname;
            
        Keys buttonname;

        bool plusisup;       //    плюс сверху или снизу 

        //    protected static double cosmid;              // часть косинуса
        [NonSerialized]
        LowPassFilter lowpassfilter;
        [NonSerialized]
        HighPassFilter hightpassfilter;
        [NonSerialized]
        WaveDecoder decoder;
        [NonSerialized]
        Signal originalsignal;
        [NonSerialized]
        Signal filteredsignal;

        protected double lowpassFrequency;
        protected double hightpassFrequency;

        Single[] fsforrms;

        static magnet()
        {
            r = 60;
         //   r2 = 30;
            color1 = Color.Black;
            //cosmid = 1 / r;
            b1 = new SolidBrush(color1);
        }

        public magnet(float xx, float yy)
        {
            changingElectricityWay = on_off.off;
            x = xx;
            y = yy;
            on = false;
            diap = 200;

            i = 1000000;
        

            rx = x + r;
            lx = x - r;
           // hy = y - r2;
           // dy = y + r2;
            plusisup = true;
            buttonname = new Keys();

            lowpassFrequency = 13400;
            hightpassFrequency= 13400;
            met = method.none;
            colorforelem = Color.White;
        }

        public on_off ChangingElectricityWay
        {
            get { return changingElectricityWay; }
            set { changingElectricityWay = value; }
        }

        public Color Colorforelem
        {
            get { return colorforelem; }
            set { colorforelem = value; }
        }

        public double LowpassFrequency
        {
            get { return lowpassFrequency; }
            set { lowpassFrequency = value; }
        }

        public double HightpassFrequency
        {
            get { return hightpassFrequency; }
            set { hightpassFrequency = value; }
        }

        public Signal Filteredsignal
        {
            get { return filteredsignal; }
            set { filteredsignal = value; }
        }

        public Single[] Fsforrms
        {
            get { return fsforrms; }
            set { fsforrms = value; }
        }

        public Keys Buttonname
        {
            get { return buttonname; }
            set { buttonname = value; }
        }

        public bool Plusisup
        {
            get { return plusisup; }
            set { plusisup = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public float Lx
        {
            get { return lx; }
            set { lx = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Dy
        {
            get { return dy; }
            set { dy = value; }
        }

        public float Hy
        {
            get { return hy; }
            set { hy = value; }
        }

        public float Rx
        {
            get { return rx; }
            set { rx = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Diap
        {
            get { return diap; }
            set { diap = value; }
        }

        public int I
        {
            get { return i; }
            set { i = value; }
        }

       // public static double Cosmid
        //{
          //  get { return cosmid; }
           // set { cosmid = value; }
      //  }

            

        public static int R
        {
            get { return r; }
            set { r = value; }
        }

        public static Color Color1
        {
            get { return color1; }
            set { color1 = value; }
        }

        public static SolidBrush Br
        {
            get { return b1; }
            set { b1 = value; }
        }

        public float DragdropX
        {
            get { return dragdropX; }
            set { dragdropX = value; }
        }

        public float DragdropY
        {
            get { return dragdropY; }
            set { dragdropY = value; }
        }

        public void draw(Graphics g)
        {
           // SolidBrush b1 = new SolidBrush(color1);
            g.FillEllipse(b1, x - r, y - r,2 * r, 2 * r);
        }

        public bool zone(float xc, float yc)
        {
            if (Math.Sqrt(Math.Pow((x - xc), 2) + Math.Pow((y - yc), 2)) <= r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void filteredSignal(Signal originalsignal)
        {
            lowpassfilter = new LowPassFilter(lowpassFrequency, originalsignal.SampleRate);
            hightpassfilter = new HighPassFilter(hightpassFrequency, originalsignal.SampleRate);

            switch (met)
            {
                case method.none:
                    filteredsignal = originalsignal;
                    break;
                case method.low:
                    filteredsignal = lowpassfilter.Apply(originalsignal);
                    filteredsignal = lowpassfilter.Apply(filteredsignal);
                    filteredsignal = lowpassfilter.Apply(filteredsignal);
                    break;
                case method.hight:
                    filteredsignal = hightpassfilter.Apply(originalsignal);
                    filteredsignal = hightpassfilter.Apply(filteredsignal);
                    filteredsignal = hightpassfilter.Apply(filteredsignal);
                    break;
                case method.both:
                    filteredsignal = lowpassfilter.Apply(originalsignal);
                    filteredsignal = hightpassfilter.Apply(filteredsignal);
                    filteredsignal = lowpassfilter.Apply(filteredsignal);
                    filteredsignal = hightpassfilter.Apply(filteredsignal);
                    filteredsignal = lowpassfilter.Apply(filteredsignal);
                    filteredsignal = hightpassfilter.Apply(filteredsignal);
                    break;
            }
        }

        public void filteredSignal(string filename)
        {
            if (filename != null)
            {
                var fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                decoder = new WaveDecoder(fileStream);
                originalsignal = decoder.Decode();
                lowpassfilter = new LowPassFilter(lowpassFrequency, decoder.SampleRate);
                hightpassfilter = new HighPassFilter(hightpassFrequency, decoder.SampleRate);
                filteredsignal = null;
            switch(met)
                {
                    case method.none:
                        filteredsignal = originalsignal;
                        break;
                    case method.low:
                        filteredsignal = lowpassfilter.Apply(originalsignal);
                        for(int i = 0; i < 2; i++)
                        {
                            filteredsignal = lowpassfilter.Apply(filteredsignal);
                        }
                        break;
                    case method.hight:
                        filteredsignal = hightpassfilter.Apply(originalsignal);
                        for (int i = 0; i < 2; i++)
                        {
                            filteredsignal = hightpassfilter.Apply(filteredsignal);
                        }
                        break;
                    case method.both:
                        filteredsignal = lowpassfilter.Apply(originalsignal);
                        filteredsignal = hightpassfilter.Apply(filteredsignal);
                        for (int i = 0; i < 2; i++)
                        {
                            filteredsignal = lowpassfilter.Apply(filteredsignal);
                            filteredsignal = hightpassfilter.Apply(filteredsignal);
                        }
                        break;
                }
                //fsforrms = new Single[filteredsignal.Samples];
               // filteredsignal.CopyTo(fsforrms);


            }
        }


        
    }

    [Serializable]
    public class element
    {
        protected float x, y, xm, ym, x2, y2;
        protected static Color color1;
     //   protected Color mixedcolror;
        //static Brush br1;
        protected static float length, widthd;
        static Pen penelem;
        //  Random rand;

        protected double cos, sin;

       
        public element(float xx, float yy)
        {
            xm = xx;
            ym = yy;
            x2 = xm + length/2;
            y2 = ym;
            x = xm - length / 2;
            y = ym;
            cos = 1;
            sin = 0;
            mixedcolorpen = new Pen(Color.White, widthd);
            //  mixedcolror = Color.Black;
        }

        static element()
        {
            length = 6;
            widthd = 1;
            //color1 = Color.White;
           // Brush br1 = new SolidBrush(color1);
            penelem = new Pen(Color.White, widthd);
            color1 = Color.White;
        }
        
        public double Cos
        {
            get { return cos; }
            set { cos = value; }
        }

        public double Sin
        {
            get { return sin; }
            set { sin = value; }
        }

        public static float Length
        {
            get { return length; }
            set { length = value; }
        }

        public static float Widthd
        {
            get { return widthd; }
            set { widthd = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Xm
        {
            get { return xm; }
            set { xm = value; }
        }

        public float Ym
        {
            get { return ym; }
            set { ym = value; }
        }

        public float X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public float Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public static Color Color1
        {
            get { return color1; }
            set { color1 = value; }
        }

        public static Pen Penelem
        {
            get { return penelem; }
            set { penelem = value; }
        }

        protected Pen mixedcolorpen; 

        public Pen Mixedcolorpen
        {
            get { return mixedcolorpen; }
            set { mixedcolorpen = value; }
        }

        int amtofmag = 0;
        int sum_R = 0;
        int sum_G = 0;
        int sum_B = 0;

        public int Amtofmag
        {
            get { return amtofmag; }
            set { amtofmag = value; }
        }

        public int Sum_R
        {
            get { return sum_R; }
            set { sum_R = value; }
        }

        public int Sum_G
        {
            get { return sum_G; }
            set { sum_G = value; }
        }

        public int Sum_B
        {
            get { return sum_B; }
            set { sum_B = value; }
        }

        public void drawel(Graphics g, colormode mode) //  also check all new functions and upgraid old functions
        {
            // g.FillRectangle(new SolidBrush(color1), x, y , length, widthd);
            try
            {
                mixedcolorpen.Width = penelem.Width;
            }
            catch (Exception)
            { }

            if (Math.Abs(x2 - x) == length)
            {
                y = ym;
                y2 = ym;
            }
            try
            {
                if (mode == colormode.onecolor)
                { g.DrawLine(penelem, x, y, x2, y2); }

                if(mode == colormode.mixedcolor)
                {
                    g.DrawLine(mixedcolorpen, x, y, x2, y2);
                }
            }
            catch (Exception)
            { }
                
        }


    }

}
