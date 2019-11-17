using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kbzhldk
{
    public partial class Form1 : Form
    {
        double x = 30;
        double y = 180;
        int alpha = 45;
        double t = 0;
        double vx = 0;
        double vy = 0;
        double g = 9.8;
        int v0 = 0;
        SolidBrush sb;
        public Form1()
        {
            InitializeComponent();
            sb = new SolidBrush(Color.Red);
            v0 = int.Parse(textBox1.Text);
            vx = v0 * Math.Cos(alpha * Math.PI / 180);
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t += 0.1;
            vy = v0 * Math.Sin(alpha * Math.PI / 180) - g*t;
            x = x + vx * t;
            y = y + vy * t;
            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(sb, Convert.ToSingle(x), Convert.ToSingle(y), 30, 30);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
