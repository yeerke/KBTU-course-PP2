using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        Point center = new Point(145, 150);
        double alphaSeconds = -102;
        double alphaMinutes = -102;
        double x, y;
        int r = 40;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Text = "cos(" + alphaSeconds.ToString() + ") = " + Math.Cos(alphaSeconds).ToString() + " = " + (center.X + (r * Math.Cos(alphaSeconds))).ToString();
            textBox2.Text = "sin(" + alphaSeconds.ToString() + ") = " + Math.Sin(alphaSeconds).ToString() + " = " + (center.Y + (r * Math.Sin(alphaSeconds))).ToString();
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawEllipse(pen, 75, 80, 140, 140);
            /*e.Graphics.DrawLine(pen, center, new Point(145, 110));
            e.Graphics.DrawLine(pen, center, new Point(185, 150));
            e.Graphics.DrawLine(pen, center, new Point(145, 190));
            e.Graphics.DrawLine(pen, center, new Point(105, 150));*/
            x = center.X + (r * Math.Cos(alphaSeconds));
            y = center.Y + (r * Math.Sin(alphaSeconds));
            e.Graphics.DrawLine(pen, center, new PointF(Convert.ToSingle(x), Convert.ToSingle(y)));
            pen.Color = Color.Red;
            x = center.X + (r * Math.Cos(alphaMinutes));
            y = center.Y + (r * Math.Sin(alphaMinutes));
            e.Graphics.DrawLine(pen, center, new PointF(Convert.ToSingle(x), Convert.ToSingle(y)));

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            alphaMinutes -= 6;
            pictureBox1.Refresh();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            alphaSeconds -= 6;
            pictureBox1.Refresh();
        }
    }
}
