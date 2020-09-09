using System.Drawing;

namespace Shooter
{
    class Boss
    {
        public int x;
        public int y;
        public int xspeed;
        public int yspeed;
        public int tot;

        public Boss(int tot)
        {
            this.tot = tot;
        }

        public void Zeichnen(Graphics l, SolidBrush b)
        {
            l.FillEllipse(b, x, y, 20, 20);
            x += xspeed;
            y += yspeed;
        }

        public void Verfolgen(int xs, int ys)
        {
            if (this.x < xs)
            {
                xspeed = 2;
            }
            else
            {
                xspeed = -2;
            }



            if (this.y < ys)
            {
                yspeed = 2;
            }
            else
            {
                yspeed = -2;
            }



            if (this.x > xs - 2 && this.x < xs + 2)
            {
                xspeed = 0;
            }



            if (this.y > ys - 2 && this.y < ys + 2)
            {
                yspeed = 0;
            }
        }


    }
}
