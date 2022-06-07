using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Labas_5;

namespace Labas_5
{
    public partial class Form1 : Form
    {
        public Pen pen = new Pen(Color.Black, 1);
        public Graphics g;
        public Bitmap bitmap;
        Stopwatch swTimeSinceStart;
        int frameSinceStart;
        Block1 block1;
        Block2 block2;
        Block3 block3;
        Block4 block4;
        int degrees;
        int framesSinceStart;
        int framesSinceStart2;
        Stopwatch timeSinceStart1;
        Stopwatch timeSinceStart2;
        int a;
        int padding;
        int stepForHammer;
        int stepForNail;


        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            g = Graphics.FromImage(bitmap);
            swTimeSinceStart = new Stopwatch();
            block1 = new Block1(g, pen);
            block2 = new Block2(g, pen);
            block3 = new Block3(g, pen, Canvas.Height, Canvas.Width);
            block4 = new Block4(g, pen, Canvas.Height, Canvas.Width);
            timeSinceStart1 = new Stopwatch();
            timeSinceStart2 = new Stopwatch();

        }

        private void Block1_Click(object sender, EventArgs e)
        {
            Canvas.Image = bitmap;
            block1.Draw();
        }


        private void Block2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            Canvas.Image = bitmap;
            g.ResetTransform();
            block2.Draw();
        }

        private void Block3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            g.Clear(Color.White);
            framesSinceStart = 0;
            degrees = 500;
            timer1.Start();
            timer1.Interval = Convert.ToInt32(Math.Round(1000 / numericUpDown1.Value));
            timeSinceStart1.Start();
        }

        private void Block4_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            a = 0;
            Canvas.Image = bitmap;
            framesSinceStart = 0;
            timer2.Start();
            timer2.Interval = Convert.ToInt32(Math.Round(1000 / numericUpDown2.Value));
            timeSinceStart2.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(Math.Round(1000 / numericUpDown1.Value));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Canvas.Image = bitmap;
            degrees += Convert.ToInt32(numericUpDown2.Value);
            block3.Draw(degrees);
            framesSinceStart++;
            double tms = timeSinceStart1.ElapsedMilliseconds;
            label1.Text = $"Interval:{timer1.Interval}\n{tms} ms\n{framesSinceStart} frames({Math.Round((framesSinceStart * 1000 / tms), 2)} fps)";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Canvas.Image = bitmap;
            if (stepForHammer < 100 + padding)
            {
                stepForHammer += 5;
                block4.DrawHammer(stepForHammer);
            }
            if (stepForNail > 0 && stepForHammer == 100 + padding)
            {
                stepForNail -= 5;
                block4.DrawHammer(stepForNail);
            }

            if (stepForHammer == 100 + padding && stepForNail == 0)
            {
                stepForNail = 100 + padding;
                stepForHammer = 0;
                padding += 50;
            }

            if (stepForHammer == 100 + padding)
            {
                a += 1;
            }

            block4.DrawNail(a + 200);
        }
    }
}