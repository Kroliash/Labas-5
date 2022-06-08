
namespace Labas_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Block1 = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Block2 = new System.Windows.Forms.Button();
            this.Block3 = new System.Windows.Forms.Button();
            this.Block4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Block1
            // 
            this.Block1.Location = new System.Drawing.Point(12, 2);
            this.Block1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(130, 60);
            this.Block1.TabIndex = 0;
            this.Block1.Text = "Block1";
            this.Block1.UseVisualStyleBackColor = true;
            this.Block1.Click += new System.EventHandler(this.Block1_Click);
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(414, 38);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(600, 400);
            this.Canvas.TabIndex = 1;
            this.Canvas.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Block2
            // 
            this.Block2.Location = new System.Drawing.Point(12, 88);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(130, 60);
            this.Block2.TabIndex = 0;
            this.Block2.Text = "Block2";
            this.Block2.Click += new System.EventHandler(this.Block2_Click);
            // 
            // Block3
            // 
            this.Block3.Location = new System.Drawing.Point(12, 174);
            this.Block3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Block3.Name = "Block3";
            this.Block3.Size = new System.Drawing.Size(130, 60);
            this.Block3.TabIndex = 2;
            this.Block3.Text = "Block3";
            this.Block3.UseVisualStyleBackColor = true;
            this.Block3.Click += new System.EventHandler(this.Block3_Click);
            // 
            // Block4
            // 
            this.Block4.Location = new System.Drawing.Point(12, 314);
            this.Block4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Block4.Name = "Block4";
            this.Block4.Size = new System.Drawing.Size(130, 60);
            this.Block4.TabIndex = 3;
            this.Block4.Text = "Block4";
            this.Block4.UseVisualStyleBackColor = true;
            this.Block4.Click += new System.EventHandler(this.Block4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 174);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(148, 207);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "FPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "AV Ω";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Block4);
            this.Controls.Add(this.Block3);
            this.Controls.Add(this.Block2);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Block1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Block1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button Block2d;
        internal System.Windows.Forms.Button Block2;
        internal System.Windows.Forms.Button Block3;
        internal System.Windows.Forms.Button Block4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
