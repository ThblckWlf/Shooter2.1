using System.Drawing;

namespace Shooter
{
    class Granate
    {
        public int x;
        public int y;
        public int speedx;
        public int speedy;

        public Granate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Werfen(int richtung)
        {
            switch (richtung)
            {
                case 1:
                    speedy = -6;

                    break;
                case 2:
                    speedy = 6;
                    break;
                case 3:
                    speedx = -6;
                    break;
                case 4:
                    speedx = 6;
                    break;
            }
        }
        public void zeichnen(Graphics l, SolidBrush b2)
        {
            l.FillEllipse(b2, x, y, 7, 7);
        }
    
    }
}
