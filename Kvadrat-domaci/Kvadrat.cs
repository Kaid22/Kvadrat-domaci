using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Kvadrat_domaci
{
    class Kvadrat
    {
        int x, y, a;
        Color color;
        public void Postavi(int x,int y,int a,Color color)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.color = color;
        }
        public void Crtaj(Graphics g)
        {
            Pen pen = new Pen(color, 3);            
            Brush brush = new SolidBrush(Color.FromArgb(color.A-100,color.R,color.G,color.B));
            g.DrawRectangle(pen, x - a/2, y - a/2, a, a);
            g.FillRectangle(brush, x - a/2, y - a/2, a, a);
        }

    }
}
