using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ClassLibrary_shapes_;

namespace ногоугольники
{
    public partial class  Form1 : Form
    {
        void deletepointsnotforundo()
        {
            for (int i = 0; i < list.Count; i++)
            { list[i].Delpoint = false; }

            if (list.Count > 3)
            {
                if (spos_paint == 1)
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        for (int j = i + 1; j < list.Count; j++)
                        {
                            up = false;
                            down = false;

                            if (list[i].X != list[j].X)
                            {
                                k = (list[i].Y - list[j].Y) / (list[i].X - list[j].X);
                                b = list[j].Y - k * list[j].X;
                                for (int n = 0; n < list.Count; n++)
                                {
                                    if (n != i && n != j)
                                    {
                                        vry = k * list[n].X + b;
                                        if (list[n].Y > vry)
                                        { up = true; }
                                        if (list[n].Y < vry)
                                        { down = true; }

                                    }
                                }
                            }
                            else
                            {
                                for (int n = 0; n < list.Count; n++)
                                {
                                    if (n != i && n != j)
                                        if (list[n].X > list[i].X)
                                        { up = true; }
                                    if (list[n].X < list[i].X)
                                    { down = true; }
                                }
                            }

                            if ((up == true && down == false) || (up == false && down == true))
                            {
                                list[i].Delpoint = true;
                                list[j].Delpoint = true;
                            }
                        }//
                    }
                }
                if (spos_paint == 2)
                {
                    lfdwnum = 0;
                    firstangle = 180;//Math.PI;
                    for (int i = 1; i < list.Count; i++)
                    {
                        if (list[i].Y > list[lfdwnum].Y)
                        { lfdwnum = i; }
                        if (list[i].Y == list[lfdwnum].Y)
                        {
                            if (list[i].X < list[lfdwnum].X)
                            { lfdwnum = i; }
                        }

                    }

                    previousnum = lfdwnum;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i != lfdwnum)
                        {
                            if (angle(list[lfdwnum].X + 100, list[lfdwnum].Y, list[lfdwnum].X, list[lfdwnum].Y, list[i].X, list[i].Y) < firstangle)
                            {
                                firstangle = angle(list[lfdwnum].X + 100, list[lfdwnum].Y, list[lfdwnum].X, list[lfdwnum].Y, list[i].X, list[i].Y);
                                nextnum = i;
                            }
                        }
                    }
                    list[previousnum].Delpoint = true;
                    list[nextnum].Delpoint = true;

                    firstangle = 0;
                    while (nextnum != lfdwnum)
                    {
                        firstangle = 0;
                        mednum = nextnum;
                        for (int i = 0; i < list.Count; i++)
                        {

                            if (angle(list[previousnum].X, list[previousnum].Y, list[mednum].X, list[mednum].Y, list[i].X, list[i].Y) > firstangle)
                            {
                                firstangle = angle(list[previousnum].X, list[previousnum].Y, list[mednum].X, list[mednum].Y, list[i].X, list[i].Y);
                                nextnum = i;
                            }
                        }
                        previousnum = mednum;
                        list[nextnum].Delpoint = true;
                    }
                }


                for (int m = 0; m < list.Count; m++)
                {
                    if (list[m].Delpoint == false)
                    {
                        list.RemoveAt(m);
                        m--;
                    }
                }
            }
        }

        void deletepoints()
        {
            for (int i = 0; i < list.Count; i++)
            { list[i].Delpoint = false; }

            if (list.Count > 3)
            {
                if (spos_paint == 1)
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        for (int j = i + 1; j < list.Count; j++)
                        {
                            up = false;
                            down = false;

                            if (list[i].X != list[j].X)
                            {
                                k = (list[i].Y - list[j].Y) / (list[i].X - list[j].X);
                                b = list[j].Y - k * list[j].X;
                                for (int n = 0; n < list.Count; n++)
                                {
                                    if (n != i && n != j)
                                    {
                                        vry = k * list[n].X + b;
                                        if (list[n].Y > vry)
                                        { up = true; }
                                        if (list[n].Y < vry)
                                        { down = true; }

                                    }
                                }
                            }
                            else
                            {
                                for (int n = 0; n < list.Count; n++)
                                {
                                    if (n != i && n != j)
                                        if (list[n].X > list[i].X)
                                        { up = true; }
                                    if (list[n].X < list[i].X)
                                    { down = true; }
                                }
                            }

                            if ((up == true && down == false) || (up == false && down == true))
                            {
                                list[i].Delpoint = true;
                                list[j].Delpoint = true;
                            }
                        }//
                    }
                }
                if (spos_paint == 2)
                {
                    lfdwnum = 0;
                    firstangle = 180;//Math.PI;
                    for (int i = 1; i < list.Count; i++)
                    {
                        if (list[i].Y > list[lfdwnum].Y)
                        { lfdwnum = i; }
                        if (list[i].Y == list[lfdwnum].Y)
                        {
                            if (list[i].X < list[lfdwnum].X)
                            { lfdwnum = i; }
                        }

                    }

                    previousnum = lfdwnum;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i != lfdwnum)
                        {
                            if (angle(list[lfdwnum].X + 100, list[lfdwnum].Y, list[lfdwnum].X, list[lfdwnum].Y, list[i].X, list[i].Y) < firstangle)
                            {
                                firstangle = angle(list[lfdwnum].X + 100, list[lfdwnum].Y, list[lfdwnum].X, list[lfdwnum].Y, list[i].X, list[i].Y);
                                nextnum = i;
                            }
                        }
                    }
                    /// label1.Text = Convert.ToString(firstangle);
                    list[previousnum].Delpoint = true;
                    list[nextnum].Delpoint = true;

                    firstangle = 0;
                    while (nextnum != lfdwnum)
                    {
                        firstangle = 0;
                        mednum = nextnum;
                        for (int i = 0; i < list.Count; i++)
                        {

                            if (angle(list[previousnum].X, list[previousnum].Y, list[mednum].X, list[mednum].Y, list[i].X, list[i].Y) > firstangle)
                            {
                                firstangle = angle(list[previousnum].X, list[previousnum].Y, list[mednum].X, list[mednum].Y, list[i].X, list[i].Y);
                                nextnum = i;
                            }
                        }
                        previousnum = mednum;
                        list[nextnum].Delpoint = true;
                    }
                }

                List<point> pp = new List<point>() { };
                List<int> ppnum = new List<int>() { };
                for (int m = 0; m < list.Count; m++)
                {
                    if (list[m].Delpoint == false)
                    {
                         //stackForUndo.Push(new undo_pointsreturn(list[m], m));
                        pp.Add(list[m]);
                        ppnum.Add(m);

                        list.RemoveAt(m);
                        //P--;
                        m--;
                    }
                }
                if (pp.Count > 0)
                {
                    stackForUndo.Push(new undo_pointsreturn(pp, ppnum));
                    stackForUndo.Peek().usenexttoo = true;
                }
            }
        }

        void ForSaveFiles()
        {
            BinaryFormatter bf = new BinaryFormatter();   // форматирует все в бинарный код
            FileStream fs = new FileStream(chosenfile, FileMode.Create, FileAccess.Write);    // открытие для записи

            bf.Serialize(fs, list);
            bf.Serialize(fs, spos_paint);
            bf.Serialize(fs, pen.Color);
            bf.Serialize(fs, menu);
            bf.Serialize(fs, поОпределениюToolStripMenuItem.BackColor);
            bf.Serialize(fs, цветЛиниий_tsmi.BackColor);
            bf.Serialize(fs, tsmi_color.BackColor);
           // bf.Serialize(fs, list.Count);
            bf.Serialize(fs, point.Color1);
            bf.Serialize(fs, point.R1);

            fs.Close();
        }

        void ForLoadFiles()
        {
            BinaryFormatter bf = new BinaryFormatter();       // расфоатирует
            FileStream fs = new FileStream(chosenfile, FileMode.Open, FileAccess.Read);    // открытие для чтения

            list = (List<point>)bf.Deserialize(fs);
            spos_paint = (int)bf.Deserialize(fs);
            pen.Color = (Color)bf.Deserialize(fs);
            menu = (int)bf.Deserialize(fs);
            поОпределениюToolStripMenuItem.BackColor = (Color)bf.Deserialize(fs);
            цветЛиниий_tsmi.BackColor = (Color)bf.Deserialize(fs);
            tsmi_color.BackColor = (Color)bf.Deserialize(fs);
            //P = (int)bf.Deserialize(fs);
            point.Color1 = (Color)bf.Deserialize(fs);
            point.R1 = (float)bf.Deserialize(fs);
            itwassaved = true;

            stackForUndo.Clear();
            secondStackForUndo.Clear();
            fs.Close();
        }

        void ForClear()
        {
            list.Clear();
            menu = 1;
            spos_paint = 1;
            pen.Color = Color.Blue;
            поОпределениюToolStripMenuItem.BackColor = Color.Blue;
            tsmi_color.BackColor = Color.Red;
            цветЛиниий_tsmi.BackColor = Color.Blue;
            point.Color1 = Color.Red;
            //P = 0;
            point.R1 = 16;
            stackForUndo.Clear();
            secondStackForUndo.Clear();
        }

        public static double angle(double x1, double y1, double x2, double y2, double x3, double y3)     // ниж/выш  - сред - выш/ниж
        {
            double onethree = (x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2);
            double lenonetwo = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double lenthreetwo = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double cosx1x3 = onethree / (lenonetwo * lenthreetwo);
            double angle = Math.Acos(cosx1x3) * 180 / Math.PI;
            return angle;
        }



      

        double firstangle;
        int nextnum;
        int mednum;
        int previousnum;
        int lfdwnum;

        Random rnd;

        Random rndForMove;

        bool allmove;

        public List<point> list = new List<point>() { };
        public List<int> listdd = new List<int>() { };
        //int ldd;
       // int P;
        float k, b, vry;  //tbv
        float deltaX, deltaY;
        bool mngdragdrop; // для передвижения всей оболочки
        bool dragdropdobr;
        int menu;// 1 - круг, 2 - квадрат, 3 - треугольник
        int spos_paint; // 1 -  по определению 2 - джарвис
       public Pen pen;
       // Color penscolor;
        bool up, down;

        Stack<undo> stackForUndo = new Stack<undo>() { };
        Stack<undo> secondStackForUndo = new Stack<undo>() { };



        string chosenfile;
  
        Form2 f2;
        CustomDialog f3;

        int time;

        bool itwassaved;

        public Form1()
        {
            allmove = false;
            InitializeComponent();
            firstangle = 180;
            //P = 0;
            //ldd = 0;
            dragdropdobr = false;
            menu = 1;
            spos_paint = 1;
            //tbv = 5;
            lfdwnum = 0;
          //  penscolor = new Color();
          //  penscolor = Color.Blue;
            pen = new Pen(Color.Blue, 8);
            поОпределениюToolStripMenuItem.BackColor = Color.Blue;

            time = 0;

            rnd = new Random();
            rndForMove = new Random();
            itwassaved = false;

            f3 = new CustomDialog();
        }

        public ToolStripMenuItem CircleToolStripMenuItem
        {
            get { return circleToolStripMenuItem; }
            set { circleToolStripMenuItem = value; }
        }

        public ToolStripMenuItem SquareToolStripMenuItem
        {
            get { return squareToolStripMenuItem; }
            set { squareToolStripMenuItem = value; }
        }

        public ToolStripMenuItem TriangleToolStripMenuItem
        {
            get { return triangleToolStripMenuItem; }
            set { triangleToolStripMenuItem = value; }
        }

        public ToolStripMenuItem StarToolStripMenuItem
        {
            get { return starToolStripMenuItem; }
            set { starToolStripMenuItem = value; }
        }

        public ToolStripMenuItem LineColorTsmi
        {
            get { return цветЛиниий_tsmi; }
            set { цветЛиниий_tsmi = value; }
        }

        public ToolStripMenuItem Tsmi_color
        {
            get { return tsmi_color; }
            set { tsmi_color = value; }
        }

        public int Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (list.Count >= 3)
            {

                if (spos_paint == 1 || spos_paint == 2)
                {
                    timer1 = new Timer();
                    timer1.Start();
                }

                if (spos_paint == 1)
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        for (int j = i + 1; j < list.Count; j++)
                        {
                            up = false;
                            down = false;

                            if (list[i].X != list[j].X)
                            {
                                k = (list[i].Y - list[j].Y) / (list[i].X - list[j].X);
                                b = list[j].Y - k * list[j].X;
                                for (int n = 0; n < list.Count; n++)
                                {
                                    if (n != i && n != j)
                                    {
                                        vry = k * list[n].X + b;
                                        if (list[n].Y > vry)
                                        { up = true; }
                                        if (list[n].Y < vry)
                                        { down = true; }
                                    }
                                }
                            }
                            else
                            {

                                for (int n = 0; n < list.Count; n++)
                                {
                                    if (n != i && n != j)
                                        if (list[n].X > list[i].X)
                                        { up = true; }
                                    if (list[n].X < list[i].X)
                                    { down = true; }
                                }
                            }
                            if ((up == true && down == false) || (up == false && down == true))
                            { e.Graphics.DrawLine(pen, list[i].X, list[i].Y, list[j].X, list[j].Y); }
                        }
                    }
                }
                if (spos_paint == 2)
                {
                    lfdwnum = 0;
                    firstangle = 180;
                    for (int i = 1; i < list.Count; i++)
                    {
                        if (list[i].Y > list[lfdwnum].Y)
                        { lfdwnum = i; }
                        if (list[i].Y == list[lfdwnum].Y)
                        {
                            if (list[i].X < list[lfdwnum].X)
                            { lfdwnum = i; }
                        }

                    }

                    previousnum = lfdwnum;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i != lfdwnum)
                        {
                            if (angle(list[lfdwnum].X + 100, list[lfdwnum].Y, list[lfdwnum].X, list[lfdwnum].Y, list[i].X, list[i].Y) < firstangle)
                            {
                                firstangle = angle(list[lfdwnum].X + 100, list[lfdwnum].Y, list[lfdwnum].X, list[lfdwnum].Y, list[i].X, list[i].Y);
                                nextnum = i;
                            }
                        }
                    }
                    
                    e.Graphics.DrawLine(pen, list[previousnum].X, list[previousnum].Y, list[nextnum].X, list[nextnum].Y);

                    firstangle = 0;
                    while (nextnum != lfdwnum)
                    {
                        firstangle = 0;
                        mednum = nextnum;
                        for (int i = 0; i < list.Count; i++)
                        {

                            if (angle(list[previousnum].X, list[previousnum].Y, list[mednum].X, list[mednum].Y, list[i].X, list[i].Y) > firstangle)
                            {
                                firstangle = angle(list[previousnum].X, list[previousnum].Y, list[mednum].X, list[mednum].Y, list[i].X, list[i].Y);
                                nextnum = i;
                            }
                        }
                        previousnum = mednum;
                        e.Graphics.DrawLine(pen, list[previousnum].X, list[previousnum].Y, list[nextnum].X, list[nextnum].Y);
                    }
                }
                if (spos_paint == 1 || spos_paint == 2)
                {
                    timer1.Stop();
                    label1.Text = Convert.ToString(time);
                    time = 0;
                }

            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i].draw(e.Graphics);
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itwassaved = false;
            if (menu != 1)
            {
                itwassaved = false;
                stackForUndo.Push(new undo_shapetype(menu));
            }
            menu = 1;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu != 2)
            {
                itwassaved = false;
                stackForUndo.Push(new undo_shapetype(menu));
            }
            menu = 2;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu != 3)
            {
                itwassaved = false;
                stackForUndo.Push(new undo_shapetype(menu));
            }
            menu = 3;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu != 4)
            {
                itwassaved = false;
                stackForUndo.Push(new undo_shapetype(menu));
            }
            menu = 4;
        }

        private void джарвисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spos_paint = 2;
            джарвисToolStripMenuItem.BackColor = Color.Blue;
            поОпределениюToolStripMenuItem.BackColor = Color.White;
            itwassaved = false;
            Refresh();
        }

        private void tsmi_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (point.Color1 != colorDialog1.Color)
            {
                stackForUndo.Push(new undo_pointcolor(point.Color1));
                secondStackForUndo.Clear();
                point.Color1 = colorDialog1.Color;
                tsmi_color.BackColor = colorDialog1.Color;
                itwassaved = false;
                Refresh();
            }
        }

        private void цветЛиниий_tsmi_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            if (pen.Color != colorDialog2.Color)
            {
                stackForUndo.Push(new undo_linecolor(pen.Color));
                secondStackForUndo.Clear();
                pen.Color = colorDialog2.Color;
                цветЛиниий_tsmi.BackColor = colorDialog2.Color;
                itwassaved = false;
                Refresh();
            }
        }

        private void рандомноРазбросатьЕще500ТочекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spos_paint = 3;
            джарвисToolStripMenuItem.BackColor = Color.White;
            поОпределениюToolStripMenuItem.BackColor = Color.White;
            for (int i = 0; i < 500; i++)
            {
                if (menu == 1)
                {
                    list.Add(new top(rnd.Next(20, 600), rnd.Next(20, 600)));
                }
                if (menu == 2)
                {
                    list.Add(new square(rnd.Next(20, 600), rnd.Next(20, 600)));
                }
                if (menu == 3)
                {
                    list.Add(new triangle(rnd.Next(20, 600), rnd.Next(20, 600)));
                }
                if (menu == 4)
                {
                    list.Add(new star(rnd.Next(20, 600), rnd.Next(20, 600)));
                }
            }
            itwassaved = false;
            Refresh();
        }

        private void поОпределениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spos_paint = 1;
            джарвисToolStripMenuItem.BackColor = Color.White;
            поОпределениюToolStripMenuItem.BackColor = Color.Blue;
            itwassaved = false;
            Refresh();
        }

        private void tsmi_r_Click(object sender, EventArgs e)
        {
            if (this.f2 == null || f2.Visible != true)
            {
                f2 = new Form2();
                f2.lastrad = point.R1;
                f2.TrackBar1.Value = (int)point.R1;
                f2.RC += new RadiusEventHandler(this.updateRadius);   //??????? 
                f2.RUE += new RadiusUndoAddEventHandler(this.updateRadiusUndo);
                f2.Show();
               // stackForUndo.Push(new undo_radius(point.R1));
                secondStackForUndo.Clear();
            }
            else
            {
                f2.lastrad = point.R1;
                f2.TrackBar1.Value = (int)point.R1;
                f2.BringToFront();
                f2.WindowState = FormWindowState.Normal;
               // stackForUndo.Push(new undo_radius(point.R1));
                secondStackForUndo.Clear();
            }
        }




        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itwassaved == false)
            {
                    f3.ShowDialog();
                if (f3.but == 1)
                {
                    if (chosenfile == null)
                    {
                        saveFileDialog1.ShowDialog();
                        if(itwassaved == true)
                        {
                            ForSaveFiles();
                            ForClear();
                            Refresh();
                        }
                        
                    }
                    else
                    {
                        ForSaveFiles();
                        ForClear();
                        Refresh();
                    }
                }

                if (f3.but == 2)
                {
                    ForClear();
                    Refresh();
                }
            }
            else
            {
                ForClear();
                Refresh();
            }
            f3.but = 0;
            chosenfile = null;
        }      //done

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)         //done
        {
            if (itwassaved == false)
            {
                f3.ShowDialog();
                if (f3.but == 1)
                {
                    if (chosenfile == null)
                    {
                        saveFileDialog1.ShowDialog();
                        if (itwassaved == true)
                        {
                            ForSaveFiles();
                            openFileDialog1.ShowDialog();
                        }

                    }
                    else
                    {
                        ForSaveFiles();
                        openFileDialog1.ShowDialog();
                    }
                }
                if (f3.but == 2)
                {
                    openFileDialog1.ShowDialog();
                }
            }
            else
            {
                openFileDialog1.ShowDialog();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)           //done
        {
            chosenfile = openFileDialog1.FileName;
            ForLoadFiles();
            itwassaved = true;
            Refresh();
        }         

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)       //done
        {
            if(chosenfile == null)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                ForSaveFiles();
                itwassaved = true;
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)    //done
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)           //done
        {
            chosenfile = saveFileDialog1.FileName;
            ForSaveFiles();
            itwassaved = true;
        }                   

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)           //done
        {
            if (itwassaved == false)
            {
                    f3.ShowDialog();
                if (f3.but == 1)
                {
                    if (chosenfile == null)
                    {
                        saveFileDialog1.ShowDialog();
                    }
                    else
                    {
                        ForSaveFiles();
                        itwassaved = true;
                    }
                }

                if((f3.but == 1 && itwassaved == true) || f3.but == 2)
                Close();
            }
            else
            { Close(); }
        }



        bool addpoint = false ;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                addpoint = true;
                if (list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].zone(e.X, e.Y) == true)   
                        {
                            listdd.Add(i);
                            dragdropdobr = true;
                            list[i].DragdropX = list[i].X - e.X ;
                            list[i].DragdropY = list[i].Y - e.Y;
                            deltaX = e.X;
                            deltaY = e.Y;
                            addpoint = false;
                        }
                    }
                }
                if (list.Count >= 3)
                {
                    mngdragdrop = true;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].zone(e.X, e.Y) == true)
                        {
                            mngdragdrop = false;
                            break;
                        }
                    }
                    if (mngdragdrop == true)
                    { 
                    deltaX = 0;
                    deltaY = 0;
                    for (int j = 0; j < list.Count; j++)  // передвижение выпуклой оболочки
                    {
                        up = false;
                        down = false;

                        if (e.X != list[j].X)
                        {
                            k = (e.Y - list[j].Y) / (e.X - list[j].X);
                            b = list[j].Y - k * list[j].X;
                            for (int n = 0; n < list.Count; n++)
                            {
                                if (n != j)
                                {
                                    vry = k * list[n].X + b;
                                    if (list[n].Y > vry)
                                    { up = true; }
                                    if (list[n].Y < vry)
                                    { down = true; }
                                }
                            }
                        }
                        else
                        {
                            for (int n = 0; n < list.Count; n++)
                            {
                                if (n != j)
                                    if (list[n].X > e.X)
                                    { up = true; }
                                if (list[n].X < e.X)
                                { down = true; }
                            }
                        }

                        if ((up == true && down == false) || (up == false && down == true))
                        {
                            mngdragdrop = false;
                            break;
                        }
                    }
                    if (mngdragdrop == true)
                    {
                            for(int i = 0; i < list.Count; i++)
                            {
                                list[i].DragdropX = list[i].X - e.X;
                                list[i].DragdropY = list[i].Y - e.Y;
                            }
                        deltaX = e.X;
                        deltaY = e.Y;
                            addpoint = false;
                    }
                }
                }

            }
            if (e.Button == MouseButtons.Right)    // delete point
            {
                List<point> pp = new List<point>() { };
                List<int> ppnum = new List<int>() { };

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].zone(e.X, e.Y) == true)  
                    {
                        //stackForUndo.Push(new undo_pointsreturn(list[i], i));
                       
                        secondStackForUndo.Clear();
                        pp.Add(list[i]);
                        ppnum.Add(i);
                        list.RemoveAt(i);
                        Refresh();
                    }
                }
                if (pp.Count > 0)
                {
                    stackForUndo.Push(new undo_pointsreturn(pp, ppnum));
                }

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mngdragdrop == true)
            {
                for(int i = 0; i < list.Count; i++)
                {
                    list[i].X = e.X + list[i].DragdropX;
                    list[i].Y = e.Y + list[i].DragdropY;
                }
                Refresh();
            }
            if (dragdropdobr == true)
            {
                for (int i = 0; i < listdd.Count; i++)
                {
                    list[listdd[i]].X = e.X + list[listdd[i]].DragdropX;
                    list[listdd[i]].Y = e.Y + list[listdd[i]].DragdropY;
                    Refresh();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mngdragdrop == true)
                {
                    deltaX = e.X - deltaX;
                    deltaY = e.Y - deltaY;
                    if (deltaX != 0 && deltaY != 0)
                    {
                        stackForUndo.Push(new undo_allmove(deltaX, deltaY));
                        secondStackForUndo.Clear();
                    }
                    mngdragdrop = false;
                }
                if (dragdropdobr == true)
                {
                    deltaX = e.X - deltaX;
                    deltaY = e.Y - deltaY;
                    
                    stackForUndo.Push(new undo_somepointsmove(deltaX, deltaY, listdd));
                    deletepoints();
                    secondStackForUndo.Clear();
                    listdd.Clear();
                    dragdropdobr = false;
                }
                if(addpoint == true)
                {
                    if(menu == 1)
                    {
                        list.Add(new top(e.X, e.Y));
                    }
                    if (menu == 2)
                    {
                        list.Add(new square(e.X, e.Y));
                    }
                    if (menu == 3)
                    {
                        list.Add(new triangle(e.X, e.Y));
                    }
                    if(menu == 4)
                    {
                        list.Add(new star(e.X, e.Y));
                    }

                    stackForUndo.Push(new undo_pointsdelete(list.Count()));
                    deletepoints();

                    secondStackForUndo.Clear();
                    
                }
                    Refresh();
            }
            itwassaved = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + 1;
        }

        private void updateRadius(object sender, RadiusEventArgs e)
        {
          //  new undo_radius() rad = new undo_radius(point.R1);
            //stackForUndo.Push(new undo_radius(point.R1));
           // secondStackForUndo.Clear();
            point.R1= e.r;
            label2.Text = Convert.ToString(point.R1);
            itwassaved = false;
            Refresh();

        }

        private void updateRadiusUndo(object sender, RadiusUndoAddEventArgs e)
        {
            stackForUndo.Push(e.lastr);
        }
    

        private void toolStripButton1_Click(object sender, EventArgs e)  // play done
        {
            toolStripButton1.Enabled = false;
            toolStripButton2.Enabled = true;
            stackForUndo.Push(new undo_allpointsrandommove(list));
            timer2.Start();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)   //stop done
        {
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = false;
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int forrnd;
            for(int i = 0; i < list.Count; i++)
            {
                forrnd = rnd.Next(0, 5);
                switch(forrnd)
                {
                    case 1:
                        list[i].Y-=10;
                        break;
                    case 2:
                        list[i].Y+=10;
                        break;
                    case 3:
                        list[i].X-=10;
                        break;
                    case 4:
                        list[i].X+=10;
                        break;
                }
            }
            
            deletepointsnotforundo();

            Refresh();
        }   //done

        public Timer Timer2
        {
            get { return timer2; }
            set { timer2 = value; }
        }
  



        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(stackForUndo.Count);
            if(stackForUndo.Count >=1)
            {
                stackForUndo.Peek().returnsmth(this);
                secondStackForUndo.Push(stackForUndo.Peek());
                if (stackForUndo.Peek().usenexttoo == true)
                {
                    stackForUndo.Pop();
                    stackForUndo.Peek().returnsmth(this);
                    stackForUndo.Peek().usenexttoo = true;
                    secondStackForUndo.Push(stackForUndo.Peek());
                }

                stackForUndo.Pop();
            }
            Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (secondStackForUndo.Count >= 1)
            {
                secondStackForUndo.Peek().returnsmthback(this);
                stackForUndo.Push(secondStackForUndo.Peek());
                if (secondStackForUndo.Peek().usenexttoo == true)
                {
                    secondStackForUndo.Pop();
                    secondStackForUndo.Peek().returnsmthback(this);
                    stackForUndo.Push(secondStackForUndo.Peek());
                }
                secondStackForUndo.Pop();
            }
            Refresh();
        }
    }

}
