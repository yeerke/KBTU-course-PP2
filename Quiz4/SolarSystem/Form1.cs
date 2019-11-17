using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        Planet Earth, Sun, Jupiter, Mercury;
        double aE = 90;
        double aJ = 180;
        double aM = 270;
        double rE;
        double rJ;
        double rM;
        Pen pen = new Pen(Color.Black);
        SolidBrush sb = new SolidBrush(Color.Blue);
        public Form1()
        {
            InitializeComponent();
            Earth = new Planet(pictureBox1.Width/2, 40, 15);
            Sun = new Planet(pictureBox1.Width/2, pictureBox1.Height/2, 40);
            Jupiter = new Planet(30, pictureBox1.Height / 2, 10);
            Mercury = new Planet(120, pictureBox1.Height / 2, 20);
            rE = Sun.y - Earth.y;
            rJ = Sun.x - Jupiter.x;
            rM = Sun.x - Mercury.x;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            aE -= 2;
            aJ -= 3;
            aM -= 1;
            Earth.x = Sun.x + rE * Math.Cos(aE * Math.PI / 180);
            Jupiter.x = Sun.x + rJ * Math.Cos(aJ * Math.PI / 180);
            Mercury.x = Sun.x + rM * Math.Cos(aM * Math.PI / 180);
            Earth.y = Sun.y - rE * Math.Sin(aE * Math.PI / 180);
            Jupiter.y = Sun.y - rJ * Math.Sin(aJ * Math.PI / 180);
            Mercury.y = Sun.y - rM * Math.Sin(aM * Math.PI / 180);
            
            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, Convert.ToSingle(pictureBox1.Width / 2 - rE), Convert.ToSingle(pictureBox1.Height/2 - rE), Convert.ToSingle(2 * rE), Convert.ToSingle(2 * rE));
            e.Graphics.DrawEllipse(pen, Convert.ToSingle(pictureBox1.Width / 2 - rJ), Convert.ToSingle(pictureBox1.Height/2 - rJ), Convert.ToSingle(2 * rJ), Convert.ToSingle(2 * rJ));
            e.Graphics.DrawEllipse(pen, Convert.ToSingle(pictureBox1.Width / 2 - rM), Convert.ToSingle(pictureBox1.Height/2 - rM), Convert.ToSingle(2 * rM), Convert.ToSingle(2 * rM));
            sb.Color = Color.Blue;
            e.Graphics.FillEllipse(sb, Convert.ToSingle(Earth.x - Earth.r), Convert.ToSingle(Earth.y - Earth.r), Convert.ToSingle(2 *Earth.r), Convert.ToSingle(2 *Earth.r));
            sb.Color = Color.Orange;
            e.Graphics.FillEllipse(sb, Convert.ToSingle(Jupiter.x - Jupiter.r), Convert.ToSingle(Jupiter.y - Jupiter.r), Convert.ToSingle(2 *Jupiter.r), Convert.ToSingle(2 *Jupiter.r));
            sb.Color = Color.Red;
            e.Graphics.FillEllipse(sb, Convert.ToSingle(Mercury.x - Mercury.r), Convert.ToSingle(Mercury.y - Mercury.r), Convert.ToSingle(2 *Mercury.r), Convert.ToSingle(2 *Mercury.r));
            sb.Color = Color.Yellow;
            e.Graphics.FillEllipse(sb, Convert.ToSingle(Sun.x - Sun.r), Convert.ToSingle(Sun.y - Sun.r), Convert.ToSingle(2 * Sun.r), Convert.ToSingle(2 * Sun.r));

        }
    }
}
