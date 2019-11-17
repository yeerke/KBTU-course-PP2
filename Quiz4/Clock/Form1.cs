using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        int x, y;
        int r = 150;
        double xs, ys;
        double xm, ym;
        int asec = 90;
        int amin = 90;
        Pen pen;

        private void Timer2_Tick(object sender, EventArgs e)
        {
            amin -= 6;
            xm = x + r + r * Math.Cos(amin * Math.PI / 180);
            ym = y + r - r * Math.Sin(amin * Math.PI / 180);
            pictureBox1.Refresh();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            asec -= 6;
            xs = x+r + r * Math.Cos(asec * Math.PI / 180);
            ys = y+r - r * Math.Sin(asec * Math.PI / 180);
            pictureBox1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            x = pictureBox1.Width / 2 - r;
            y = pictureBox1.Height / 2 - r;
            xs = x+r + r * Math.Cos(asec * Math.PI / 180);
            ys = y+r - r * Math.Sin(asec * Math.PI / 180);
            xm = x + r + r * Math.Cos(asec * Math.PI / 180);
            ym = y + r - r * Math.Sin(asec * Math.PI / 180);
            pen = new Pen(Color.Black);
            timer2.Start();
            timer1.Start();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pen.Color = Color.Black;
            e.Graphics.DrawEllipse(pen, x, y, 2 * r, 2 * r);
            e.Graphics.DrawLine(pen, x + r, y + r, Convert.ToSingle(xm), Convert.ToSingle(ym));
            pen.Color = Color.Red;
            e.Graphics.DrawLine(pen, x+r, y+r, Convert.ToSingle(xs), Convert.ToSingle(ys));
        }
    }
}
