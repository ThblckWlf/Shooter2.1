using System.Drawing;

namespace Shooter
{
    class Zombies
    {
        public int x;
        public int y;
        public int xspeed;
        public int yspeed;
        public int tot;
        public SolidBrush b;

        public Zombies(int x, int y, int xspeed, int yspeed, int tot, SolidBrush b)
        {
            this.x = x;
            this.y = y;
            this.xspeed = xspeed;
            this.yspeed = yspeed;
            this.tot = tot;
            this.b = b;
        }
        public void zeichnen(Graphics l)
        {
            switch (tot)
            {
                case 0:
                    if (xspeed < 0) xspeed = -7;
                    if (xspeed > 0) xspeed = 7;
                    if (yspeed < 0) yspeed = -7;
                    if (yspeed > 0) yspeed = 7;



                    b.Color = Color.Green;
                    break;
                case 1:
                    if (xspeed < 0) xspeed = -5;
                    if (xspeed > 0) xspeed = 5;
                    if (yspeed < 0) yspeed = -5;
                    if (yspeed > 0) yspeed = 5;



                    b.Color = Color.Yellow;
                    break;
                case 2:
                    if (xspeed < 0) xspeed = -3;
                    if (xspeed > 0) xspeed = 3;
                    if (yspeed < 0) yspeed = -3;
                    if (yspeed > 0) yspeed = 3;



                    b.Color = Color.Blue;
                    break;
            }
            l.FillEllipse(b, x, y, 12, 12);




        }



    }

}
