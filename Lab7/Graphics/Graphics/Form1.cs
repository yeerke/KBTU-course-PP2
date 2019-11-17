using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float dxx = 20.0F;
        public float dyy = 17.32F;
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sbrect = new SolidBrush(Color.Blue);
            Rectangle rect = new Rectangle(10, 10, pictureBox1.Width - 20, pictureBox1.Height - 20);
            e.Graphics.FillRectangle(sbrect, rect);
            SolidBrush sbPolygon = new SolidBrush(Color.Red);
            SolidBrush sbEllipse = new SolidBrush(Color.White);
            e.Graphics.FillPolygon(sbPolygon, polygon(150.0F, 150.0F, dxx, dyy));
            e.Graphics.FillPolygon(sbPolygon, polygon(270.0F, 370.0F, dxx, dyy));
            e.Graphics.FillPolygon(sbPolygon, polygon(500.0F, 232.0F, dxx, dyy));
            e.Graphics.FillPolygon(sbPolygon, polygon(600.0F, 40.0F, dxx, dyy));
            e.Graphics.FillEllipse(sbEllipse, 20, 20, 40, 40);
            e.Graphics.FillEllipse(sbEllipse, 140, 210, 40, 40);
            e.Graphics.FillEllipse(sbEllipse, 300, 120, 40, 40);
            e.Graphics.FillEllipse(sbEllipse, 672, 250, 40, 40);
            e.Graphics.FillEllipse(sbEllipse, 450, 320, 40, 40);
            float dx = 50;
            float dy = 25;
            float x = (pictureBox1.Width / 2 - dx);
            float y = pictureBox1.Height / 2 - dy;
            PointF point1 = new PointF(x, y);
            x += dx;
            y -= dy;
            PointF point2 = new PointF(x, y);
            x += dx;
            y += dy;
            PointF point3 = new PointF(x, y);
            y += 2 * dy;
            PointF point4 = new PointF(x, y);
            x -= dx;
            y += dy;
            PointF point5 = new PointF(x, y);
            x -= dx;
            y -= dy;
            PointF point6 = new PointF(x, y);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
             };
            SolidBrush sbHexagon = new SolidBrush(Color.Yellow);
            e.Graphics.FillPolygon(sbHexagon, curvePoints);
        }
        static PointF[] polygon(float x, float y, float dx, float dy)
        {
            PointF point1 = new PointF(x, y);
            x += dx;
            PointF point2 = new PointF(x, y);
            x += dx / 2;
            y -= dy;
            PointF point3 = new PointF(x, y);
            y += dy;
            x += dx / 2;
            PointF point4 = new PointF(x, y);
            x += dx;
            PointF point5 = new PointF(x, y);
            x -= dx / 2;
            y += dy;
            PointF point6 = new PointF(x, y);
            y += dy;
            x += dx / 2;
            PointF point7 = new PointF(x, y);
            x -= dx;
            PointF point8 = new PointF(x, y);
            x -= dx / 2;
            y += dy;
            PointF point9 = new PointF(x, y);
            x -= dx / 2;
            y -= dy;
            PointF point10 = new PointF(x, y);
            x -= dx;
            PointF point11 = new PointF(x, y);
            x += dx / 2;
            y -= dy;
            PointF point12 = new PointF(x, y);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7,
                 point8,
                 point9,
                 point10,
                 point11,
                 point12
             };
            return curvePoints;
        }
    }    
}
