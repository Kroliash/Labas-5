using System;
using System.Drawing;

namespace Labas_5
{
    class Block1
    {
        Graphics g;
        Pen pen;
        public Block1(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        public void Draw()
        {
            g.Clear(Color.White);
            Point[] hexagon =
            {
                new Point(0, 100), new Point(60, 150), new Point(140, 150), new Point(200, 100), new Point(140, 50), new Point(60, 50)
            };
            Rectangle circle = new Rectangle(240, 0, 120, 120);
            Rectangle elipse = new Rectangle(340, 120, 120, 60);
            Point[] rectangle =
            {
                new Point(160, 200), new Point(340, 200), new Point(340, 350), new Point(160, 350)
            };
            SolidBrush hexagonCol = new SolidBrush(Color.BlueViolet);
            SolidBrush elipseCol = new SolidBrush(Color.Crimson);
            g.FillPolygon(hexagonCol, hexagon);
            g.DrawEllipse(pen, circle);
            g.FillPie(elipseCol, elipse, 0, 360);
            g.DrawPolygon(pen, rectangle);

        }
    }
}