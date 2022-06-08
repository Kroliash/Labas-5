using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Labas_5
{
    class Block4
    {
        Image hammerTexture = Image.FromFile("hammer.png");
        Image nailTexture = Image.FromFile("nail.png");
        Image woodPlankTexture = Image.FromFile("wood_plank.png");
       
         Graphics g;
         Pen myPen;
         int height;
         int width;

        public Block4(Graphics g, Pen myPen, int height, int width)
        {
            this.g = g;
            this.myPen = myPen;
            this.height = height;
            this.width = width;
        }
        public void DrawBoard()
        {
            g.DrawImage(woodPlankTexture, 0,315);
        }

        public void DrawHammerBottom(int stepX, int stepY)
        {
            g.DrawImage(hammerTexture, stepX, stepY);
        }
        public void DrawHammerTop(int stepTop)
        {
            g.DrawImage(hammerTexture, 50, stepTop);
        }
        public void DrawNail(int step)
        {
            g.DrawImage(nailTexture, 50, step);
        }
    }
}
