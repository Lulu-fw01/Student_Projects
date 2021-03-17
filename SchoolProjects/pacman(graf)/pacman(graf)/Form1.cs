using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman_graf_
{
    public partial class Form1 : Form
    {
        pacman pac;
        ghost_1 gh1;
        ghost_2 gh2;
        ghost_2 gh32;
        Image gameover;
        //Image win;
        bool points;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
             pac = new pacman(40, 40, 0);
            gh1 = new ghost_1(520, 520, 0, Direction.left);
            gh2 = new ghost_2(40, 520, 0, Direction.right, Image.FromFile("ghost_2.png"));
            gh32 = new ghost_2(520, 260, 0, Direction.up, Image.FromFile("ghost_2.png"));
            gameover = Image.FromFile("gameover.png");
            timer1.Start();
            timer2.Start();
            points = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Brush map = new Brush(Color.Blue);
            if (points == false)
            { e.Graphics.DrawImage(Image.FromFile("you_win.png"), 0, 0, 700, 700); }
            else
            {
                if (pac.life == 0)
                { e.Graphics.DrawImage(gameover, 260, 260, 100, 100); }
                else
                {
                    for (int i = 0, i1 = 0; i != 15; i++, i1 = i1 + 40)
                    {
                        for (int b = 0, b1 = 0; b != 15; b++, b1 = b1 + 40)
                        {
                            if (creature.MAP[b, i] == 1)
                            {
                                Rectangle maprec = new Rectangle(i1, b1, 40, 40);
                                e.Graphics.FillRectangle(Brushes.Blue, maprec);
                            }
                            if (creature.MAP[b, i] == 0)
                            {
                                e.Graphics.FillEllipse(Brushes.Green, i1 + 7, b1 + 7, 25, 25);
                            }
                        }
                        //Console.Write("\n");
                    }
                    //Image pzero = Image.FromFile("D:\\документы\\ООП\\pacman_right\\zero_r.png");
                    //e.Graphics.DrawImage(pzero, 80, 40, 37, 37);
                    pac.draw(e.Graphics);
                    gh1.draw(e.Graphics);
                    gh2.draw(e.Graphics);
                    gh32.draw(e.Graphics);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    pac.dir = Direction.up;
                    pac.dir_turn = pac.dir;
                    break;
                case Keys.S:
                    pac.dir = Direction.down;
                    pac.dir_turn = pac.dir;
                    break;
                case Keys.A:
                    pac.dir = Direction.left;
                    pac.dir_turn = pac.dir;
                    break;
                case Keys.D:
                    pac.dir = Direction.right;
                    pac.dir_turn = pac.dir;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pac.move();
           gh1.move();
            points = false;
            for (int i = 0, i1 = 0; i != 15; i++, i1 = i1 + 40)
            {
                for (int b = 0, b1 = 0; b != 15; b++, b1 = b1 + 40)
                {
                    if (creature.MAP[b, i] == 0)
                    {
                        points = true;
                    }
                }
            }
            // gh2.smove(pac.y / 40, pac.x / 40);
            // gh32.smove(pac.y / 40, pac.x / 40);
            if (  ((pac.x == gh1.x) && ((Math.Abs(pac.y - gh1.y)) <= 32 )) || ((pac.y == gh1.y) && (Math.Abs(pac.x - gh1.x) <= 32)) || ((pac.x == gh2.x) && ((Math.Abs(pac.y - gh2.y)) <= 32)) || ((pac.y == gh2.y) && (Math.Abs(pac.x - gh2.x) <= 32)) || ((pac.x == gh32.x) && ((Math.Abs(pac.y - gh32.y)) <= 32)) || ((pac.y == gh32.y) && (Math.Abs(pac.x - gh32.x) <= 32)))
            {
                pac.life--;
                pac.x = 40;
                pac.y = 40;
                gh1.x = 520;
                gh1.y = 520;
                gh2.x = 40;
                gh2.y = 520;
                gh32.x = 520;
                gh32.y = 40;
            }
            if (((pac.x % 40) == 0 || (pac.y % 40) == 0) && (pac.dir == Direction.right || pac.dir == Direction.down))
            { creature.MAP[pac.y / 40, pac.x / 40] = 2; }
            if((pac.dir == Direction.left) && (pac.x+4) % 40 == 0 )
            { creature.MAP[pac.y / 40, (pac.x+4) / 40] = 2; }
            if ((pac.dir == Direction.up) && (pac.y + 4) % 40 == 0)
            { creature.MAP[(pac.y + 4) / 40, pac.x / 40] = 2; }
          
            Refresh();
        }
        

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            gh2.smove(pac.y / 40, pac.x / 40);
            gh32.smove(pac.y / 40, pac.x / 40);
            if (((pac.x == gh2.x) && ((Math.Abs(pac.y - gh2.y)) <= 32)) || ((pac.y == gh2.y) && (Math.Abs(pac.x - gh2.x) <= 32)) || ((pac.x == gh32.x) && ((Math.Abs(pac.y - gh32.y)) <= 32)) || ((pac.y == gh32.y) && (Math.Abs(pac.x - gh32.x) <= 32)))
            {
                pac.life--;
                pac.x = 40;
                pac.y = 40;
                gh1.x = 520;
                gh1.y = 520;
                gh2.x = 40;
                gh2.y = 520;
                gh32.x = 520;
                gh32.y = 40;
            }
            Refresh();
        }
    }
}
