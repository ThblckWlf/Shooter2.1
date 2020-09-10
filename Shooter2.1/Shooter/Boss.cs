using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows;

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
        public List<Kugel> bosskglist = new List<Kugel>();
        public int kugelaktiv;

        public Boss(int tot1)
        {
            this.tot = tot1+1;
            tothalb = tot / 2;
            totviertel = tothalb / 2;
            this.kugelaktiv = 0;
        }

        public void bossschuss(Spieler sp1, Graphics l, System.Windows.Forms.Timer timer)
        {
            if (kugelaktiv == 0)
            {   

                this.bosskglist.Add(new Kugel(this.x, this.y));
                this.bosskglist.Add(new Kugel(this.x, this.y));
                this.bosskglist.Add(new Kugel(this.x, this.y));
                
                Vector v = new Vector(sp1.x - this.x, sp1.y - this.y);
                int laenge = Convert.ToInt32(v.Length);

               

                foreach (Kugel bosskg in bosskglist)
                {
                    bosskg.speedx = Convert.ToInt32((v.X / laenge) * 10);
                    bosskg.speedy = Convert.ToInt32((v.Y / laenge) * 10);

                }

              

                for (int i = 0; i < this.bosskglist.Count; i++)
                {

                    bosskglist[i].x += i * bosskglist[i].speedx;
                    bosskglist[i].y += i * bosskglist[i].speedy;
                }

                kugelaktiv = 3;
            }


            SolidBrush b = new SolidBrush(Color.White);
            for (int i = 0; i < this.bosskglist.Count; i++)
            {
             
                bosskglist[i].x += bosskglist[i].speedx;
                bosskglist[i].y += bosskglist[i].speedy;
                l.FillEllipse(b, bosskglist[i].x, bosskglist[i].y, 6, 6);
            }


            foreach (Kugel bosskg in bosskglist)
            {
                if (bosskg.x > 700 || bosskg.x < 0 || bosskg.y > 700 || bosskg.y < 0)
                {
                    kugelaktiv--;
                    bosskglist.Remove(bosskg);

                    return;
                }

                if (Math.Sqrt(Math.Pow((sp1.x + 5) - (bosskg.x + 3), 2) + Math.Pow((sp1.y + 5) - (bosskg.y + 3), 2)) < 8)
                {
                    sp1.leben--;
                    if (sp1.leben <= 0)
                    {
                        sp1.stop(timer);
                        return;
                    }
                    kugelaktiv--;
                    bosskglist.Remove(bosskg);
                    
                    return;

                }

            }
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
