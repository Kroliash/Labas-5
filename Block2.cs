using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labas_5 
{
    class Block2
    {
        Graphics g;
        Pen pen;
        public Block2(Graphics g, Pen pen)
        {
            this.g = g;
            this.pen = pen;
        }

        public void Draw()
        {
            g.Clear(Color.White);
            Point[] carMiddle =
            {
                new Point(150, 100), new Point(500, 100), new Point(500, 175), new Point(150, 175),
            };
            Point[] carTop =
            {
                new Point(250, 100), new Point(275, 25), new Point(375, 25), new Point(400, 100),
            };
            Point[] headlightLeft =
            {
                new Point(140, 120), new Point(150, 120), new Point(150, 140), new Point(140, 140),
            };
            Point[] headlightRight =
            {
                new Point(500, 120), new Point(510, 120), new Point(510, 140), new Point(500, 140),
            };
            Point[] downlightLeft =
            {
                new Point(140, 160), new Point(160, 160), new Point(160, 180), new Point(140, 180),
            };
            Point[] downlightRight =
            {
                new Point(490, 160), new Point(510, 160), new Point(510, 180), new Point(490, 180),
            };
            Point[] windowLeft =
            {
                new Point(260, 100), new Point(275, 40), new Point(320, 40), new Point(320, 100),
            };
            Point[] windowRight =
            {
                new Point(330, 100), new Point(330, 40), new Point(370, 40), new Point(390, 100),
            };
            Rectangle wheelIn1 = new Rectangle(225, 150, 50, 50);
            Rectangle wheelIn2 = new Rectangle(375, 150, 50, 50);
            Rectangle wheelOut1 = new Rectangle(212, 137, 75, 75);
            Rectangle wheelOut2 = new Rectangle(363, 137, 75, 75);
            SolidBrush car = new SolidBrush(Color.Green);
            SolidBrush wheel1 = new SolidBrush(Color.Gray);
            SolidBrush wheel2 = new SolidBrush(Color.Black);
            SolidBrush lightCol = new SolidBrush(Color.Yellow);
            SolidBrush downlightCol = new SolidBrush(Color.Red);
            SolidBrush windowCol = new SolidBrush(Color.LightSkyBlue);
            g.FillPolygon(car, carMiddle);
            g.FillPolygon(car, carTop);
            g.FillPie(wheel1, wheelOut1, 0, 360);
            g.FillPie(wheel1, wheelOut2, 0, 360);
            g.FillPie(wheel2, wheelIn1, 0, 360);
            g.FillPie(wheel2, wheelIn2, 0, 360);
            g.DrawEllipse(pen, wheelOut1);
            g.DrawEllipse(pen, wheelOut2);
            g.FillPolygon(lightCol, headlightLeft);
            g.FillPolygon(lightCol, headlightRight);
            g.DrawLine(pen, new Point(320, 100), new Point(320, 175)); // door left
            g.DrawLine(pen, new Point(330, 100), new Point(330, 175)); // door right
            g.FillPolygon(windowCol, windowLeft);
            g.FillPolygon(windowCol, windowRight);
            g.FillPolygon(downlightCol, downlightLeft);
            g.FillPolygon(downlightCol, downlightRight);

        }
    }
}