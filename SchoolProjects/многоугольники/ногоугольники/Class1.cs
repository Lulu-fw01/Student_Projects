using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_shapes_;

namespace ногоугольники
{
    abstract public class undo
    {
        abstract public void returnsmth(Form1 f1);    // метод который будет возвращать то, что было на предидущем шаге
        abstract public void returnsmthback(Form1 f1);
        public bool usenexttoo = false;
    }   //done

    class undo_somepointsmove: undo
    {
        List<int> pointsnumbers = new List<int>() { };
        float delX;
        float delY;
      //  int num;
        public undo_somepointsmove(float xx, float yy, List<int> list)
        {
            delX = -xx;
            delY = -yy;
            for(int i = 0; i < list.Count; i++)
            {
                pointsnumbers.Add(list[i]);
            }
        }

        public override void returnsmth(Form1 f1)
        {
            for(int i = 0; i < pointsnumbers.Count; i++)
             {
               f1.list[pointsnumbers[i]].X += delX;
               f1.list[pointsnumbers[i]].Y += delY;
             }
            //f1.list[num].X += delX;
            //f1.list[num].Y += delY;
        }

         public override void returnsmthback(Form1 f1)
        {
            for (int i = 0; i < pointsnumbers.Count; i++)
            {
                f1.list[pointsnumbers[i]].X -= delX;
                f1.list[pointsnumbers[i]].Y -= delY;
            }
        }
    }  //done
   
    class undo_allmove: undo
    {
        float delX;
        float delY;
        public undo_allmove(float xx, float yy)
        {
            delX = -xx;
            delY = -yy;
        }

        public override void returnsmth(Form1 f1)
        {
            for (int i = 0; i < f1.list.Count(); i++)
            {
                f1.list[i].X += delX;
                f1.list[i].Y += delY;
            }
        }

        public override void returnsmthback(Form1 f1)
        {
            for (int i = 0; i < f1.list.Count(); i++)
            {
                f1.list[i].X -= delX;
                f1.list[i].Y -= delY;
            }
        }
    }         //done

    class undo_pointsdelete: undo
    {
        int lastnum;
        point p;
        public undo_pointsdelete(int ln)
        {
            lastnum = ln-1;
            usenexttoo = false;
        }

        public override void returnsmth(Form1 f1)
        {
            p = f1.list[lastnum];
           f1.list.RemoveAt(lastnum);

           //    f1.PP--;
        }

        public override void returnsmthback(Form1 f1)
        {
            f1.list.Add(p);
        }
    }    //done

    class undo_pointsreturn: undo
    {
       // float x;
       // float y;
       // int num;
       // point p;

        List<point> deletedpoints = new List<point>() { };
        List<int> numbers = new List<int>() { };

        public undo_pointsreturn(List <point> dd, List <int> nn/*/point pp, int nn/*/)
        {
            deletedpoints = dd;
            numbers = nn;
            usenexttoo = false;
            // x = xx;
            // y = yy;
           // p = pp;
            //num = nn;
        }

        public override void returnsmth(Form1 f1)
        {
            for (int n = deletedpoints.Count - 1; n >=0; n--)
            {
                point a = f1.list[f1.list.Count() - 1];
                f1.list.Add(a);
                for (int i = f1.list.Count() - 2; i > numbers[n]; i--)
                {
                    f1.list[i] = f1.list[i - 1];
                }
                f1.list[numbers[n]] = deletedpoints[n];
            }
        }

        public override void returnsmthback(Form1 f1)
        {
            for (int n = 0; n < numbers.Count; n++)
            {
                f1.list.RemoveAt(numbers[n]);
            }
        }
    }     //done

    class undo_pointcolor : undo
    {
        public Color pointcol, pointcolb;

        public undo_pointcolor(Color pp)
        {
            pointcol = pp;
        }

        public Color Pointcol
        {
            get { return pointcol; }
            set { pointcol = value; }
        }

        public override void returnsmth(Form1 f1)
        {
            pointcolb = point.Color1;
            point.Color1 = pointcol;
            f1.Tsmi_color.BackColor = pointcol;
        }

        public override void returnsmthback(Form1 f1)
        {
            point.Color1 = pointcolb;
            f1.Tsmi_color.BackColor = pointcolb;
        }
    }     //done
    
    class undo_linecolor : undo   
    {
        protected Color pencol, pencolb;

        public undo_linecolor(Color pp)
        {
            pencol = pp;
        }

        public Color Pencol
        {
            get { return pencol; }
            set { pencol = value; }
        }

        public override void returnsmth(Form1 f1)
        {
            pencolb = f1.pen.Color;
           f1.pen.Color = pencol;
           f1.LineColorTsmi.BackColor = pencol;
        }

        public override void returnsmthback(Form1 f1)
        {
            f1.pen.Color = pencolb;
            f1.LineColorTsmi.BackColor = pencolb;
        }
    }      //done

   public class undo_radius : undo   
    {
        protected float rad, radb;

        public undo_radius(float rr)
        {
            rad = rr;
        }

        public float Rad
        {
            get { return rad; }
            set { rad = value; }
        }

        public override void returnsmth(Form1 f1)
        {
            radb = point.R1;
            point.R1 = rad;
        }

        public override void returnsmthback(Form1 f1)
        {
            point.R1 = radb;
        }
    }   //done

    class undo_allpointsrandommove: undo
    {
        List<point> lastlist = new List<point>() { };
        List<point> newlistc = new List<point>() { };

        public undo_allpointsrandommove(List<point> ll)
        {
             for(int i = 0; i < ll.Count; i++)
             {
              switch(ll[i].Typestring)
                {
                    case "sircle":
                        lastlist.Add(new top(ll[i].X, ll[i].Y));
                        break;

                    case "triangle":
                        lastlist.Add(new triangle(ll[i].X, ll[i].Y));
                        break;

                    case "square":
                        lastlist.Add(new square((int)ll[i].X,(int)ll[i].Y));
                        break;
                    case "star":
                        lastlist.Add(new star((int)ll[i].X, (int)ll[i].Y));
                        break;
                }
                 
             }
        }

        public override void returnsmth(Form1 f1)
        {
             for (int i = 0; i < f1.list.Count(); i++)
             {
                switch (f1.list[i].Typestring)
                {
                    case "sircle":
                        newlistc.Add(new top(f1.list[i].X, f1.list[i].Y));
                        break;

                    case "triangle":
                        newlistc.Add(new triangle(f1.list[i].X, f1.list[i].Y));
                        break;

                    case "square":
                        newlistc.Add(new square((int)f1.list[i].X, (int)f1.list[i].Y));
                        break;
                    case "star":
                        newlistc.Add(new star((int)f1.list[i].X, (int)f1.list[i].Y));
                        break;
                }
            }
            f1.list.Clear();
            for(int i = 0; i < lastlist.Count(); i++)
            {
                switch (lastlist[i].Typestring)
                {
                    case "sircle":
                        f1.list.Add(new top(lastlist[i].X, lastlist[i].Y));
                        break;

                    case "triangle":
                        f1.list.Add(new triangle(lastlist[i].X, lastlist[i].Y));
                        break;

                    case "square":
                        f1.list.Add(new square((int)lastlist[i].X, (int)lastlist[i].Y));
                        break;
                    case "star":
                        f1.list.Add(new star((int)lastlist[i].X, (int)lastlist[i].Y));
                        break;
                }
            }
            
          
        }

        public override void returnsmthback(Form1 f1)
        {
            f1.list.Clear();
          //  f1.list = newlistc;
            for (int i = 0; i < newlistc.Count; i++)
            {
                switch (newlistc[i].Typestring)
                {
                    case "sircle":
                        f1.list.Add(new top(newlistc[i].X, newlistc[i].Y));
                        break;

                    case "triangle":
                        f1.list.Add(new triangle(newlistc[i].X, newlistc[i].Y));
                        break;

                    case "square":
                        f1.list.Add(new square((int)lastlist[i].X, (int)lastlist[i].Y));
                        break;
                    case "star":
                        f1.list.Add(new star((int)lastlist[i].X, (int)lastlist[i].Y));
                        break;
                }
             
            }
        }
    }   //done
    
    class undo_shapetype: undo
    {
        int prevmenu, nextmenu;
        
        public undo_shapetype(int mm)
        {
            prevmenu = mm;
        }
        public override void returnsmth(Form1 f1)
        {
            nextmenu = f1.Menu;
            f1.Menu = prevmenu;
           /*/ switch (prevmenu)
            {
                case 1:
                    
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break; 

            }/*/
        }

        public override void returnsmthback(Form1 f1)
        {
            f1.Menu = nextmenu;
        }
    }       //done
    
    



    public class RadiusEventArgs : EventArgs
    {
        public float r;
        public RadiusEventArgs(float rr)
        {
            r = rr;
        }
    }

    public delegate void RadiusEventHandler(object sender, RadiusEventArgs e);    


    public class RadiusUndoAddEventArgs : EventArgs
    {
       public undo_radius lastr;
        public RadiusUndoAddEventArgs(float rr)
        {
            lastr = new undo_radius(rr);
        }
    }

    public delegate void RadiusUndoAddEventHandler(object sender, RadiusUndoAddEventArgs e);




};
