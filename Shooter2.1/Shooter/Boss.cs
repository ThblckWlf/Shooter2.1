using System;
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
        public int tothalb;
        public int totviertel;


        public Boss(int tot1)
        {
            this.tot = tot1;
            tothalb = tot / 2;
            totviertel = tothalb / 2;
        }

        public void Zeichnen(Graphics l, SolidBrush b)
        {
            System.Drawing.SolidBrush b5 = new System.Drawing.SolidBrush(Color.Green);
            l.FillEllipse(b, x, y, 20, 20);
            x += xspeed;
            y += yspeed;


            if (tot <= tothalb)
            {
                b5.Color = Color.Orange;
            }

            if (tot <= totviertel)
            {
                b5.Color = Color.Red;
            }

            l.FillRectangle(b5, x, y - 10, tot, 4);
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
