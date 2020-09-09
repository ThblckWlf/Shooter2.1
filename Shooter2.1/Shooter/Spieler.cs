using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shooter
{
    class Spieler
    {
        public int x;
        public int y;
        public int xspeed = 0;
        public int yspeed = 0;
        public bool geschossen = true;
        public int munition = 20;
        public int granaten = 3;
        public int leben = 1;
        public int xgra;
        public int ygra;
        public int score = 0;


        public List<Kugel> kglist = new List<Kugel>();
        public List<Zombies> zomlist = new List<Zombies>();
        public List<Granate> granlist = new List<Granate>();
        public List<Boss> bosslist = new List<Boss>();

        public int richtung;


        public Spieler(int px, int py)
        {
            x = px;
            y = px;
        }

        public void Bewegen(KeyEventArgs e, Graphics l)
        {
            if (e.KeyCode == Keys.W)
            {
                yspeed = -3;
                richtung = 1;
            }
            if (e.KeyCode == Keys.S)
            {
                yspeed = 3;
                richtung = 2;
            }
            if (e.KeyCode == Keys.A)
            {
                xspeed = -3;
                richtung = 3;
            }

            if (e.KeyCode == Keys.D)
            {
                xspeed = 3;
                richtung = 4;
            }

            if (e.KeyCode == Keys.R)
            {
                if (munition == 0)
                    munition = 20;
            }

            if (e.KeyCode == Keys.Space)
            {

                if (geschossen && munition != 0)
                {

                    kglist.Add(new Kugel(x + 5, y + 5));
                    int i = kglist.Count();
                    geschossen = false;
                    kglist[i - 1].schießen(richtung);
                    munition--;
                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (granaten != 0)
                {
                    xgra = x;
                    ygra = y;

                    granlist.Add(new Granate(x + 5, y + 5));
                    int i = granlist.Count();
                    granlist[i - 1].Werfen(richtung);
                    granaten--;
                }
            }
        }

        public void zeichenen(Graphics l)
        {
            y += yspeed;
            x += xspeed;

            System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            l.FillEllipse(b, x, y, 10, 10);

        }
        public void stop(System.Windows.Forms.Timer timer)
        {
            timer.Stop();
            MessageBox.Show("Tod. Du hast " + score + " Kills gemacht");
            Application.Exit();
        }
        public void schuss(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                richtung = 1;
                if (geschossen && munition != 0)
                {



                    kglist.Add(new Kugel(x + 5, y + 5));
                    int i = kglist.Count();
                    geschossen = false;
                    kglist[i - 1].schießen(richtung);
                    munition--;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                richtung = 2;
                if (geschossen && munition != 0)
                {



                    kglist.Add(new Kugel(x + 5, y + 5));
                    int i = kglist.Count();
                    geschossen = false;
                    kglist[i - 1].schießen(richtung);
                    munition--;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                richtung = 3;
                if (geschossen && munition != 0)
                {



                    kglist.Add(new Kugel(x + 5, y + 5));
                    int i = kglist.Count();
                    geschossen = false;
                    kglist[i - 1].schießen(richtung);
                    munition--;
                }
            }



            if (e.KeyCode == Keys.Right)
            {
                richtung = 4;
                if (geschossen && munition != 0)
                {



                    kglist.Add(new Kugel(x + 5, y + 5));
                    int i = kglist.Count();
                    geschossen = false;
                    kglist[i - 1].schießen(richtung);
                    munition--;
                }
            }

        }
        //TEST TEXT 

        public void getroffen(System.Windows.Forms.Timer timer)
        {
            foreach (Zombies zb1 in zomlist)
            {
                if (Math.Sqrt(Math.Pow((zb1.x + 6) - (this.x + 5), 2) + Math.Pow((zb1.y + 6) - (this.y + 5), 2)) < 11)
                {
                    stop(timer);

                    return;
                }
            }

            foreach (Boss b1 in bosslist)
            {
                if (Math.Sqrt(Math.Pow((b1.x + 10) - (this.x + 5), 2) + Math.Pow((b1.y + 10) - (this.y + 5), 2)) < 15)
                {
                    stop(timer);

                    return;
                }
            }

            foreach (Kugel kg1 in kglist)
            {
                foreach (Zombies zb1 in zomlist)
                {
                    if (Math.Sqrt(Math.Pow((zb1.x + 6) - (kg1.x + 3), 2) + Math.Pow((zb1.y + 6) - (kg1.y + 3), 2)) < 9)
                    {
                        kglist.Remove(kg1);


                        if (zb1.tot == 0)
                        {
                            zomlist.Remove(zb1);
                            score++;

                            return;
                        }

                        else
                        {
                            zb1.tot--;
                            return;
                        }
                    }

                }
                foreach (Boss bo1 in bosslist)
                {
                    if (Math.Sqrt(Math.Pow((bo1.x + 10) - (kg1.x + 3), 2) + Math.Pow((bo1.y + 10) - (kg1.y + 3), 2)) < 13)
                    {
                        kglist.Remove(kg1);


                        if (bo1.tot == 0)
                        {
                            bosslist.Remove(bo1);
                            score += 10;

                            return;
                        }

                        else
                        {
                            bo1.tot--;
                            return;
                        }
                    }
                }

            }
        }
    }
}
