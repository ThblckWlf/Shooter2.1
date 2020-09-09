using System.Drawing;
using System.Security.Cryptography;

namespace Shooter
{
    class Kugel
    {
        public int x;
        public int y;
        public int speedx;
        public int speedy;

        public Kugel(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public void schießen(int richtung)
        {

            switch (richtung)
            {
                case 1:
                    speedy = -8;

                    break;
                case 2:
                    speedy = 8;
                    break;
                case 3:
                    speedx = -8;
                    break;
                case 4:
                    speedx = 8;
                    break;
            }


        }
    
    public void zeichnen(Graphics l, SolidBrush b)
        {
            l.FillEllipse(b, x,y, 6, 6);
        }
    
    }

}
