using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    public partial class Form1 : Form
    {
        int Ox, Oy;
        GraphicsPath gp = new GraphicsPath();
        Pen pen = new Pen(Color.Black);
        Bitmap bmp;
        Graphics gfx;
        PointF prev;
        PointF last;
        PointF prev1;
        PointF last1;
        int dx = 1;
        public Form1()
        {
            InitializeComponent();
            Ox = pictureBox1.Width / 2;
            Oy = pictureBox1.Height / 2;
            prev = new PointF(0, Oy);
            prev1 = new PointF(0, Oy);
            last = prev;
            last1 = prev1;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            prev = last;
            prev1 = last1;
            last = new PointF(prev.X + dx, Oy - 50*Convert.ToSingle(Math.Sin((prev.X + dx)/50)));
            last1 = new PointF(prev1.X + dx, Oy - 50*Convert.ToSingle(Math.Sin((prev.X + dx) / 50)));
            gfx.DrawLine(pen, prev, last);
            gfx.DrawLine(pen, prev1, last1);
            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2));
            e.Graphics.DrawLine(pen, new Point(pictureBox1.Width/2-7, 0), new Point(pictureBox1.Width/2 -7, pictureBox1.Height));
        }
    }
}
