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
        public void Draw()
        {
            g.Clear(Color.White);
            g.DrawImage(hammerTexture, 280,-100);
            g.DrawImage(nailTexture, 280,155);
            g.DrawImage(woodPlankTexture, 150,250);
        }

        public void DrawHammer(int step)
        {
            g.DrawImage(hammerTexture, 280, step-80);
        }

        public void DrawNail(int step)
        {
            g.DrawImage(nailTexture, 280, step+80);
        }






    }
}
