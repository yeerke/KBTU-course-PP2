using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    enum ToolState
    {
        Eraser,
        Pen,
        Rectangle,
        Ellipse,
        Line
    }
    public partial class Form1 : Form
    {
        ToolState activeTool;
        Bitmap bmp;
        Point prevPoint;
        Point curPoint;
        Graphics gfx;
        Pen pen;
        Pen Eraser = new Pen(Color.White, 10);
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White;
            pen = new Pen(Color.Black);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            activeTool = ToolState.Pen;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void Button_Pen(object sender, EventArgs e)
        {
            activeTool = ToolState.Pen;
        }

        private void Button_Rect(object sender, EventArgs e)
        {
            activeTool = ToolState.Rectangle;
        }

        private void Button_Line(object sender, EventArgs e)
        {
            activeTool = ToolState.Line;
        }

        private void Button_Ellipse(object sender, EventArgs e)
        {
            activeTool = ToolState.Ellipse;
        }

        private void Button_Eraser(object sender, EventArgs e)
        {
            activeTool = ToolState.Eraser;
        }
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curPoint = e.Location;
                switch (activeTool)
                {
                    case ToolState.Line:
                        gfx.DrawLine(pen, prevPoint, curPoint);
                        prevPoint = curPoint;
                        break;
                    case ToolState.Eraser:
                        gfx.DrawLine(Eraser, prevPoint, curPoint);
                        prevPoint = curPoint;
                        break;
                }
                pictureBox1.Refresh();
            }
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            curPoint = e.Location;
            switch (activeTool)
            {
                case ToolState.Pen:
                    gfx.DrawLine(pen, prevPoint, curPoint);
                    break;
                case ToolState.Rectangle:
                    gfx.DrawRectangle(pen, Math.Min(prevPoint.X,curPoint.X), Math.Min(prevPoint.Y, curPoint.Y), Math.Abs(prevPoint.X - curPoint.X), Math.Abs(prevPoint.Y - curPoint.Y));
                    break;
                case ToolState.Ellipse:
                    gfx.DrawEllipse(pen, Math.Min(prevPoint.X, curPoint.X), Math.Min(prevPoint.Y, curPoint.Y), Math.Abs(prevPoint.X - curPoint.X), Math.Abs(prevPoint.Y - curPoint.Y));
                    break;
            }
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (activeTool)
            {
                case ToolState.Pen:
                    e.Graphics.DrawLine(pen, prevPoint, curPoint);
                    break;
                case ToolState.Rectangle:
                    e.Graphics.DrawRectangle(pen, Math.Min(prevPoint.X, curPoint.X), Math.Min(prevPoint.Y, curPoint.Y), Math.Abs(prevPoint.X - curPoint.X), Math.Abs(prevPoint.Y - curPoint.Y));
                    break;
                case ToolState.Ellipse:
                    e.Graphics.DrawEllipse(pen, Math.Min(prevPoint.X, curPoint.X), Math.Min(prevPoint.Y, curPoint.Y), Math.Abs(prevPoint.X - curPoint.X), Math.Abs(prevPoint.Y - curPoint.Y));
                    break;
            }
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            if (activeTool == ToolState.Pen)
            {
                textBox1.Text = "Thickness : " + trackBar1.Value.ToString();
                pen.Width = trackBar1.Value;
            }
        }
        private void Color_Changing(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }
    }
}