using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace Labas_5
{
    class Block3
    {
        Graphics g;
        Pen myPen;
        int width;
        int height;
        Rectangle Circle;
        public Block3(Graphics g, Pen myPen, int height, int width)
        {
            this.g = g;
            this.myPen = myPen;
            this.height = height;
            this.width = width;
        }

        public void Draw(double degree)
        {
            int centerX = width / 2;
            int centerY = height / 2;
            Circle = new Rectangle(centerX - 100, centerY - 100, 200, 200);
            g.DrawEllipse(myPen, Circle);
            int x1 = Convert.ToInt32(100 * Math.Cos(degree / 180.0) + centerX - 19);
            int y1 = Convert.ToInt32(100 * Math.Sin(degree / 180.0) + centerY - 19);
            int x2 = Convert.ToInt32(100 * Math.Cos((degree + 200) / 180.0) + centerX - 19);
            int y2 = Convert.ToInt32(100 * Math.Sin((degree + 200) / 180.0) + centerY - 19);
            g.DrawEllipse(myPen, x1, y1, 50, 30);
            g.DrawEllipse(myPen, x2, y2, 50, 30);
        }
    }
}