using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace pacman_graf_
{
    enum Direction { up, down, left, right };

    abstract class creature
    {
        protected static int[,] map;
        public int x, y, speed, xnew, ynew; //?
        abstract public void move();
        abstract public void draw(Graphics g);
       // abstract public void clear();

        public creature(int xx, int yy, int ss)
        {
            x = xx;
            y = yy;
            speed = ss;
            //xnew = xn;
            //ynew = yn;

        }
        static creature()
        {
            map = new int[15, 15] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 }, { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 }, { 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1 }, { 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1 }, { 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };
        }
        static public int[,] MAP
        {
            get
            {
                return map;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 0) x = value;
                else Console.WriteLine("только больше нуля");
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0) y = value;
                else Console.WriteLine("только больше нуля");
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 0) speed = value;
                else Console.WriteLine("только больше нуля");
            }
        }
    }

    class pacman : creature
    {
        public int life;
        Image[] right;
        Image[] left;
        Image[] up;
        Image[] down;
       public Direction dir;
      public  Direction dirSOS;
        public Direction dir_turn;
        public pacman(int xx, int yy, int ss) :
           base(xx, yy, ss)
        {
            life = 2;
            dirSOS = Direction.right;
            right = new Image[5] ;
            right[0] = Image.FromFile("zero_r1.png");  //D:\\документы\\ООП\\pacman_right\\zero_r.png
            right[1] = Image.FromFile("zero_r2.png");
            right[2] = Image.FromFile("zero_r3.png");
            right[3] = right[1];
            right[4] = right[0];
            left = new Image[5];
            left[0] = Image.FromFile("zero_l1.png");
            left[1] = Image.FromFile("zero_l2.png");
            left[2] = Image.FromFile("zero_l3.png");
            left[3] = left[1];
            left[4] = left[0];
            up = new Image[5];
            up[0] = Image.FromFile("zero_u1.png");
            up[1] = Image.FromFile("zero_u2.png");
            up[2] = Image.FromFile("zero_u3.png");
            up[3] = up[1];
            up[4] = up[0];
            down = new Image[5];
            down[0] = Image.FromFile("zero_d1.png");
            down[1] = Image.FromFile("zero_d2.png");
            down[2] = Image.FromFile("zero_d3.png");
            down[3] = down[1];
            down[4] = down[0];
        }
        public int Life
        {
            get
            { return life; }
            set { life = value; }
        }
        int i = 0;
        override public void draw(Graphics g)
        {
          switch (dir)
            {
                case Direction.right:
                    g.DrawImage(right[i], x, y, 37, 37);
                    break;
                case Direction.left:
                     g.DrawImage(left[i], x, y, 37, 37);
                    break;
                case Direction.up:
                    g.DrawImage(up[i], x, y, 37, 37);
                    break;
                case Direction.down:
                    g.DrawImage(down[i], x, y, 37, 37);
                    break;
            }

           // g.DrawImage(down[2], x, y, 37, 37);
            i++;
            if(i > 4)
            { i = 0; }
        }   
        public override void move()
        {
           // dir_turn = dir;
            switch (dir)
            {
                case Direction.up:
                    dir = Direction.up;
                    if (dirSOS == Direction.left || dirSOS == Direction.right)
                    { 
                    if (x % 40 != 0)
                    { dir = dirSOS; }
                    if (creature.map[(y / 40) - 1, (x / 40)] == 1)
                    { dir = dirSOS; }
                    }
                    if (dirSOS == Direction.down)
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) - 1, (x / 40)] == 1))
                        { dir = dirSOS; }
                    }
                        break;
                    case Direction.down :
                        dir = Direction.down;
                    if (dirSOS == Direction.left || dirSOS == Direction.right)
                    {
                        if (x % 40 != 0)
                        { dir = dirSOS; }
                        if (creature.map[(y / 40) + 1, (x / 40)] == 1)
                        { dir = dirSOS; }
                    }
                    if(dirSOS == Direction.up)
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) + 1, (x / 40)] == 1))
                        { dir = dirSOS; }
                    }
                    break;
                    case Direction.left:
                        dir = Direction.left;
                    if (dirSOS == Direction.up || dirSOS == Direction.down)
                    {
                        if (y % 40 != 0)
                        { dir = dirSOS; }
                        if (creature.map[(y / 40) , (x / 40) - 1] == 1)
                        { dir = dirSOS; }
                    }
                    if(dirSOS == Direction.right)
                    {
                        if ((x % 40 == 0) && (creature.map[(x / 40) , (x / 40) - 1] == 1))
                        { dir = dirSOS; }
                    }
                    break;
                    case Direction.right:
                        dir = Direction.right;
                    if (dirSOS == Direction.up || dirSOS == Direction.down)
                    {
                        if (y % 40 != 0)
                        { dir = dirSOS; }
                        if (creature.map[(y / 40), (x / 40) + 1] == 1)
                        { dir = dirSOS; }
                    }
                    if(dirSOS == Direction.left)
                    {
                        if ((x % 40 == 0) && (creature.map[(x / 40), (x / 40) + 1] == 1))
                        { dir = dirSOS; }
                    }
                    break;
                }
          
            switch(dir_turn)
            {
                case Direction.up:
                    if((x % 40 == 0 ) && (creature.map[(y / 40) - 1, (x / 40)] != 1))
                    { dir = dir_turn; }
                    break;
                case Direction.down:
                    if ((x % 40 == 0) && (creature.map[(y / 40) + 1, (x / 40)] != 1))
                    { dir = dir_turn; }
                    break;
                case Direction.left:
                    if ((y % 40 == 0) && (creature.map[(y / 40), (x / 40) - 1] != 1))
                    { dir = dir_turn; }
                    break;
                case Direction.right:
                    if ((y % 40 == 0) && (creature.map[(y / 40), (x / 40) + 1] != 1))
                    { dir = dir_turn; }
                    break;
            }
            dirSOS = dir;
            switch (dir)
            {
                case Direction.up:
                    if (y % 40 != 0)
                    { y = y - 4; }
                    else
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) - 1, (x / 40)] != 1))
                        {
                            y = y - 4;
                        }
                    }
                    break;
                case Direction.down:
                    if (y % 40 != 0)
                    { y = y + 4; }
                    else
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) + 1, (x / 40)] != 1))
                        {
                            y = y + 4;
                        }
                    }
                    break;
                case Direction.left:
                    if (x % 40 != 0)
                    { x = x - 4; }
                    else
                    {
                        if ((x % 40 == 0) && (creature.map[(y / 40), (x / 40) - 1] != 1))
                        {
                            x = x - 4;
                        }
                    }
                    // }
                    break;
                case Direction.right:         // в массиве сначала строчка , потом столбец
                    if (x % 40 != 0)
                    { x = x + 4; }
                    else
                    {
                        if ((x % 40 == 0) && (creature.map[(y / 40), (x / 40) + 1] != 1))
                        {
                            x = x + 4;
                        }
                    }
                    break;
            }
        }
    }

    class ghost_1 : creature   //тупой
    {
        Direction dirgh1;
        Image gh1;
        public ghost_1(int xx, int yy, int ss, Direction dd) :
            base(xx, yy, ss)
        {
            dirgh1 = dd;
            gh1 = Image.FromFile("ghost_1.png");
        }
        public override void draw(Graphics g)
        {
            g.DrawImage(gh1, x, y, 37, 37);
        }

        /*/ protected ghost_1(Direction gh1)
         { dirgh1 = gh1}// Direction.left; }/*/
        Random rnd = new Random();
        public override void move()
        {
            switch (dirgh1)
            {
                case Direction.left:
                    if ((x % 40) == 0)
                    {
                        if (creature.map[(y/40), (x/40) - 1] == 1)     // если стена, то в обратную сторону 
                        { dirgh1 = Direction.right; }
                        if ((creature.map[(y/40) - 1, (x/40)] == 0) || (creature.map[(y/40) + 1, (x/40)] == 0))
                        {
                            int a = rnd.Next(1, 4);
                            switch (a)
                            {
                                case 1:
                                    dirgh1 = Direction.up;
                                    break;
                                case 2:
                                    dirgh1 = Direction.down;
                                    break;
                                case 3:
                                    dirgh1 = Direction.left;
                                    break;
                                case 4:
                                    dirgh1 = Direction.right;
                                    break;
                            }
                        }
                    }
                    break;
                case Direction.right:
                    if ((x % 40) == 0)
                    {
                        if (creature.map[(y/40), (x/40) + 1] == 1)     // если стена, то в обратную сторону 
                        { dirgh1 = Direction.left; }
                        if ((creature.map[(y/40) - 1, (x/40)] == 0) || (creature.map[(y/40) + 1, (x/40)] == 0))
                        {
                            int a = rnd.Next(1, 4);
                            switch (a)
                            {
                                case 1:
                                    dirgh1 = Direction.up;
                                    break;
                                case 2:
                                    dirgh1 = Direction.down;
                                    break;
                                case 3:
                                    dirgh1 = Direction.left;
                                    break;
                                case 4:
                                    dirgh1 = Direction.right;
                                    break;
                            }
                        }
                    }
                    break;
                case Direction.up:
                    if ((y % 40) == 0)
                    {
                        if (creature.map[(y/40) - 1, (x/40)] == 1)
                        { dirgh1 = Direction.down; }
                        if ((creature.map[(y/40), (x/40) - 1] == 0) || (creature.map[(y/40), (x/40) + 1] == 0))
                        {
                            int a = rnd.Next(1, 4);
                            switch (a)
                            {
                                case 1:
                                    dirgh1 = Direction.up;
                                    break;
                                case 2:
                                    dirgh1 = Direction.down;
                                    break;
                                case 3:
                                    dirgh1 = Direction.left;
                                    break;
                                case 4:
                                    dirgh1 = Direction.right;
                                    break;
                            }
                        }
                    }
                    break;
                case Direction.down:
                    if ((y % 40) == 0)
                    {
                        if (creature.map[(y/40) + 1, (x/40)] == 1)
                        { dirgh1 = Direction.up; }
                        if ((creature.map[(y/40), (x/40) - 1] == 0) || (creature.map[(y/40), (x/40) + 1] == 0))
                        {
                            int a = rnd.Next(1, 4);
                            switch (a)
                            {
                                case 1:
                                    dirgh1 = Direction.up;
                                    break;
                                case 2:
                                    dirgh1 = Direction.down;
                                    break;
                                case 3:
                                    dirgh1 = Direction.left;
                                    break;
                                case 4:
                                    dirgh1 = Direction.right;
                                    break;
                            }
                        }
                    }
                    break;
            }
            switch (dirgh1)
            {
                case Direction.up:
                    if (y % 40 != 0)
                    { y = y - 4; }
                    else
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) - 1, (x / 40)] != 1))
                        {
                            y = y - 4;
                        }
                    }
                    break;
                case Direction.down:
                    if (y % 40 != 0)
                    { y = y + 4; }
                    else
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) + 1, (x / 40)] != 1))
                        {
                            y = y + 4;
                        }
                    }
                    break;
                case Direction.left:
                    if (x % 40 != 0)
                    { x = x - 4; }
                    else
                    {
                        if ((x % 40 == 0) && (creature.map[(y / 40), (x / 40) - 1] != 1))
                        {
                            x = x - 4;
                        }
                    }
                    // }
                    break;
                case Direction.right:         // в массиве сначала строчка , потом столбец
                    if (x % 40 != 0)
                    { x = x + 4; }
                    else
                    {
                        if ((x % 40 == 0) && (creature.map[(y / 40), (x / 40) + 1] != 1))
                        {
                            x = x + 4;
                        }
                    }
                    break;
            }
        }
    }   // тупой

    class ghost_2 : creature //умный
    {
        Direction dirgh1;
        Image gh2;
        public ghost_2(int xx, int yy, int ss, Direction dd, Image a) :      //(int xx, int yy, int ss, Direction dd)
            base(xx, yy, ss)//base(xx, yy, ss)
        {
            dirgh1 = dd;
            gh2 = a;//Image.FromFile("ghost_2.png");
        }
        public override void draw(Graphics g)
        {
            g.DrawImage(gh2, x, y, 37, 37);
        }
        public override void move()
        { }
        public /*/override/*/ void smove(int pY, int pX)
        {
            if (((x % 40) == 0) && ((y % 40) == 0))
            { 
                int[,] map = new int[15, 15] { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1 }, { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 }, { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 }, { 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1 }, { 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1 }, { 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 }, { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } };
            int firstY, firstX;
            int a1 = y/40;
            int a2 = x/40;
            int b1 = pY;
            int b2 = pX;
                //int xN2 = a2, yN2 = a1;

            map[a1, a2] = 2;
            map[b1, b2] = -3;
            int q = 2;
            bool sh = false;
            if ((pY != y/40) || (pX != x/40))
            {
                while (map[b1, b2] != q)
                {
                    sh = false;
                    q = q + 1;
                    for (int i = 0; i != 15; i++)
                    {
                        for (int b = 0; b != 15; b++)
                        {
                            if (map[i, b] == q - 1)
                            {
                                if (map[(i - 1), b] == 0 || map[(i - 1), b] == -3)
                                {
                                    map[(i - 1), b] = q;
                                    sh = true;
                                }
                                //Console.WriteLine(map[(i - 1), b]);
                                if (map[(i + 1), b] == 0 || map[(i + 1), b] == -3)
                                {
                                    map[(i + 1), b] = q;
                                    sh = true;
                                }
                                // Console.WriteLine(map[(i + 1), b]);
                                if (map[i, (b - 1)] == 0 || map[i, (b - 1)] == -3)
                                {
                                    map[i, (b - 1)] = q;
                                    sh = true;
                                }
                                //Console.WriteLine(map[i, (b - 1)]);
                                if (map[i, (b + 1)] == 0 || map[i, (b + 1)] == -3)
                                {
                                    map[i, (b + 1)] = q;
                                    sh = true;
                                }
                                //Console.WriteLine(map[i, (b + 1)]);
                                //print(map, 10, 10);
                            }

                        }
                    }

                    if (sh == false)
                    {
                        break;
                    }
                }

                if (sh == false)
                {
                    Console.WriteLine("error");
                    firstX = 0;
                    firstY = 0;
                }
                else
                {

                    int[] jor = new int[q * 2];
                    //int[] jor = new int[q * 2];
                    int xn2 = b1, yn2 = b2;
                    int r = 0;//, t = 0;
                              //jor[0, 0] = b1;
                              //jor[0, 1] = b2;
                    int Xnext = xn2;
                    int Ynext = yn2;
                    while (map[xn2, yn2] != map[a1, a2])
                    {
                        /*/ Xnext = x;
                         Ynext = y;/*/
                        if ((map[(xn2 - 1), yn2] >= 2) && (map[(xn2 - 1), yn2] < map[xn2, yn2]))
                        {
                            Xnext = xn2;
                            Ynext = yn2;
                            xn2 = xn2 - 1;
                            jor[r] = yn2;
                            r++;
                            jor[r] = xn2;
                            r++;
                            //Console.WriteLine(b1 + " " + b2);
                        }
                        if ((map[(xn2 + 1), yn2] >= 2) && (map[(xn2 + 1), yn2] < map[xn2, yn2]))
                        {
                            Xnext = xn2;
                            Ynext = yn2;
                            xn2 = xn2 + 1;
                            jor[r] = yn2;
                            r++;
                            jor[r] = xn2;
                            r++;
                            // Console.WriteLine(b1 + " " + b2);
                        }
                        if ((map[xn2, (yn2 - 1)] >= 2) && (map[xn2, (yn2 - 1)] < map[xn2, yn2]))
                        {
                            Xnext = xn2;
                            Ynext = yn2;
                            yn2 = yn2 - 1;
                            jor[r] = yn2;
                            r++;
                            jor[r] = xn2;
                            r++;
                        }
                        if ((map[xn2, (yn2 + 1)] >= 2) && (map[xn2, (yn2 + 1)] < map[xn2, yn2]))
                        {
                            Xnext = xn2;
                            Ynext = yn2;
                            yn2 = yn2 + 1;
                            jor[r] = yn2;
                            r++;
                            jor[r] = xn2;
                            r++;
                        }
                    }

                    firstY = Xnext;
                    firstX = Ynext;
                }

                //Console.WriteLine("firstY = " + firstY + "   firstX = " + firstX);
                //xn2 = firstX;
                //yn2 = firstY;
                if ((y/40 + 1) == firstY)
                { dirgh1 = Direction.down; }
                if ((y/40 - 1) == firstY)
                { dirgh1 = Direction.up; }
                if ((x/40 + 1) == firstX)
                { dirgh1 = Direction.right; }
                if ((x/40 - 1) == firstX)
                { dirgh1 = Direction.left; }

            }
        }
            switch (dirgh1)
            {
                case Direction.up:
                    if (y % 40 != 0)
                    { y = y - 4; }
                    else
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) - 1, (x / 40)] != 1))
                        {
                            y = y - 4;
                        }
                    }
                    break;
                case Direction.down:
                    if (y % 40 != 0)
                    { y = y + 4; }
                    else
                    {
                        if ((y % 40 == 0) && (creature.map[(y / 40) + 1, (x / 40)] != 1))
                        {
                            y = y + 4;
                        }
                    }
                    break;
                case Direction.left:
                    if (x % 40 != 0)
                    { x = x - 4; }
                    else
                    {
                        if ((x % 40 == 0) && (creature.map[(y / 40), (x / 40) - 1] != 1))
                        {
                            x = x - 4;
                        }
                    }
                    // }
                    break;
                case Direction.right:         // в массиве сначала строчка , потом столбец
                    if (x % 40 != 0)
                    { x = x + 4; }
                    else
                    {
                        if ((x % 40 == 0) && (creature.map[(y / 40), (x / 40) + 1] != 1))
                        {
                            x = x + 4;
                        }
                    }
                    break;
            }
        }

    }


}
