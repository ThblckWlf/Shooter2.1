using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shooter
{
    public partial class Form1 : Form
    {
        Spieler sp1 = new Spieler(200, 200);

        Random r = new Random();


        public bool boss1gespawnt = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics l = this.CreateGraphics();
            sp1.Bewegen(e, l);
            sp1.schuss(e);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.SolidBrush b1 = new System.Drawing.SolidBrush(System.Drawing.Color.DeepPink);
            System.Drawing.SolidBrush b2 = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            System.Drawing.SolidBrush b4 = new System.Drawing.SolidBrush(Color.OrangeRed);


            Graphics l = e.Graphics;
            sp1.zeichenen(l);


            if (sp1.score == 1 && boss1gespawnt == true)
            {
                boss1gespawnt = false;
                sp1.bosslist.Add(new Boss(20));
            }

            foreach (Kugel kg in sp1.kglist)
            {
                kg.x += kg.speedx;
                kg.y += kg.speedy;
                kg.zeichnen(l, b);
            }

            for (int i = sp1.kglist.Count - 1; i > 0; i--)
            {
                sp1.kglist[i].loeschen(sp1);
            }

            foreach (Zombies zb in sp1.zomlist)
            {
                zb.x += zb.xspeed;
                zb.y += zb.yspeed;
                zb.zeichnen(l);

            }

            for (int i = sp1.zomlist.Count - 1; i > 0; i--)
            {
                sp1.zomlist[i].loeschen(sp1);
            }

            foreach (Boss bo1 in sp1.bosslist)
            {


                bo1.Verfolgen(sp1.x, sp1.y);
                bo1.Zeichnen(l, b1);
                bo1.bossschuss(sp1,l,zeichner);
            }



            foreach (Granate gr in sp1.granlist)
            {
                gr.x += gr.speedx;
                gr.y += gr.speedy;
                gr.zeichnen(l, b2);

                if (gr.x >= sp1.xgra + 150 ||
                    gr.x <= sp1.xgra - 150 ||
                    gr.y >= sp1.ygra + 150 ||
                    gr.y <= sp1.ygra - 150)
                {
                    foreach (Granate gr1 in sp1.granlist)
                    {
                        foreach (Zombies zb1 in sp1.zomlist)
                        {
                            if (Math.Sqrt(Math.Pow(gr1.x - (zb1.x + 5), 2) + Math.Pow(gr1.y - (zb1.y + 5), 2)) <= 100)
                            {
                                zb1.tot -= 5;

                                if (zb1.tot <= 0)
                                {
                                    sp1.score++;
                                    sp1.zomlist.Remove(zb1);


                                    return;
                                }






                            }
                        }

                        foreach (Boss bo1 in sp1.bosslist)
                        {
                            if (Math.Sqrt(Math.Pow((bo1.x + 10) - (gr.x + 3), 2) + Math.Pow((bo1.y + 10) - (gr.y + 3), 2)) <= 100)
                            {
                                bo1.tot -= 5;

                                if (bo1.tot == 0)
                                {
                                    sp1.bosslist.Remove(bo1);
                                    sp1.score += 10;

                                    return;
                                }






                            }
                        }
                    }
                    l.FillEllipse(b4, gr.x - 100, gr.y - 100, 200, 200);
                    sp1.granlist.Remove(gr);
                    return;


                }
            }

            sp1.getroffen(zeichner);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {



            int seite = r.Next(4);
            int schwere = r.Next(3);




            int speed = 0;
            int leben = 0;
            System.Drawing.SolidBrush b = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);



            switch (schwere)
            {
                case 0:
                    speed = 7;
                    leben = 0;
                    b.Color = Color.Green;
                    break;
                case 1:
                    speed = 5;
                    leben = 1;
                    b.Color = Color.Yellow;
                    break;
                case 2:
                    speed = 3;
                    leben = 2;
                    b.Color = Color.Blue;
                    break;
            }



            switch (seite)
            {
                case 0:
                    sp1.zomlist.Add(new Zombies(r.Next(50), r.Next(700), speed, 0, leben, b));
                    break;
                case 1:
                    sp1.zomlist.Add(new Zombies(r.Next(50) + 600, r.Next(700), -speed, 0, leben, b));
                    break;
                case 2:
                    sp1.zomlist.Add(new Zombies(r.Next(700), r.Next(50), 0, 5, leben, b));
                    break;
                case 3:
                    sp1.zomlist.Add(new Zombies(r.Next(700), r.Next(50) + 600, 0, -5, leben, b));
                    break;
            }



            kills.Text = "Kills: " + sp1.score;
            kills.Update();



            muni.Text = "Munition: " + sp1.munition;
            muni.Update();



            granaten.Text = "Granaten: " + sp1.granaten;
            granaten.Update();

            lebenl.Text = "Leben: " + sp1.leben;
            lebenl.Update();


        }

        private void zeichner_Tick(object sender, EventArgs e)
        {


            this.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
                sp1.geschossen = true;



            if (e.KeyCode == Keys.A)
                sp1.xspeed = 0;
            if (e.KeyCode == Keys.D)
                sp1.xspeed = 0;
            if (e.KeyCode == Keys.W)
                sp1.yspeed = 0;
            if (e.KeyCode == Keys.S)
                sp1.yspeed = 0;



        }
    }
}
