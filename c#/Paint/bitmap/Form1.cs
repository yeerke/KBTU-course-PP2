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

namespace bitmap
{
    enum ActiveTool
    {
        Eraser,
        Pen,
        Line,
        Rectangle,
        Ellipse,
        Star,
        Fill1,
        Fill2
    }
    public partial class Form1 : Form
    {
        ActiveTool tool;
        Bitmap bmp; // bmp is a layer for drawing instantly changing picture
        Graphics gfx; // its like a tool for drawing which has a lot of drawing methods
        Pen pen = new Pen(Color.Black);
        Pen eraser = new Pen(Color.White, 10);
        Point prevp, curp;
        bool mouseClicked = false;
        public Form1()
        {
            InitializeComponent();
            tool = ActiveTool.Pen;
            pictureBox1.BackColor = Color.White;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp); // choosing a layer on which gfx will draw;
            //after this everything drawn by gfx will show up on bmp;
            //and then setting that picturebox will take picture from bmp;
            pictureBox1.Image = bmp;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Pen_button_Click(object sender, EventArgs e)
        {
            tool = ActiveTool.Pen;
        }

        private void Rectangle_button_Click(object sender, EventArgs e)
        {
            tool = ActiveTool.Rectangle;
        }

        private void Line_button_Click(object sender, EventArgs e)
        {
            tool = ActiveTool.Line;
        }

        private void Ellipse_button_Click(object sender, EventArgs e)
        {
            tool = ActiveTool.Ellipse;
        }

        private void Button_Eraser(object sender, EventArgs e)
        {
            tool = ActiveTool.Eraser;
        }
        private void Fill1_Click(object sender, EventArgs e)
        {
            tool = ActiveTool.Fill1;
        }
        private void Fill2_Click(object sender, EventArgs e)
        {
            tool = ActiveTool.Fill2;
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevp = e.Location;
            if(tool == ActiveTool.Fill2)
            {
                BFSFill fill2 = new BFSFill();
                fill2.Fill(bmp, pen.Color, e.Location);
                pictureBox1.Refresh();
            }
            if(tool == ActiveTool.Fill1)
            {
                //MapFill
            }
            mouseClicked = true;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                curp = e.Location;
                switch (tool)
                {
                    case ActiveTool.Eraser:
                        gfx.DrawLine(eraser, prevp, curp);
                        prevp = curp;
                        break;
                    case ActiveTool.Pen:
                        gfx.DrawLine(pen, prevp, curp);
                        prevp = curp;
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private Rectangle GetRectangle(Point prevp, Point curp)
        {
            return new Rectangle
            {
                X = Math.Min(prevp.X, curp.X),
                Y = Math.Min(prevp.Y, curp.Y),
                Width = Math.Abs(prevp.X - curp.X),
                Height = Math.Abs(prevp.Y - curp.Y)
            };
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            curp = e.Location;
            switch (tool)
            {
                case ActiveTool.Eraser:
                    gfx.DrawLine(eraser, prevp, curp);
                    break;
                case ActiveTool.Pen:
                    gfx.DrawLine(pen, prevp, curp);
                    break;
                case ActiveTool.Line:
                    gfx.DrawLine(pen, prevp, curp);
                    break;
                case ActiveTool.Rectangle:
                    gfx.DrawRectangle(pen, GetRectangle(prevp, curp));
                    break;
                case ActiveTool.Ellipse:
                    gfx.DrawEllipse(pen, GetRectangle(prevp, curp));
                    break;
                case ActiveTool.Star:
                    GraphicsPath gp = new GraphicsPath();
                    gp.AddPolygon(new Point[]
                    {
                        new Point(prevp.X, curp.Y),
                        new Point((curp.X - prevp.X)/2 + prevp.X, prevp.Y),
                        new Point(curp.X, curp.Y),
                        new Point(prevp.X, prevp.Y + (curp.Y-prevp.Y)/2),
                        new Point(curp.X,  prevp.Y + (curp.Y-prevp.Y)/2),
                        new Point(prevp.X, curp.Y)
                    });
                    gfx.DrawPath(pen, gp);
                    break;
            }

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void Button_Star(object sender, EventArgs e)
        {
            tool = ActiveTool.Star;
        }

        private void Color_Button_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void Open_File(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = Bitmap.FromFile(openFileDialog1.FileName) as Bitmap;
                gfx = Graphics.FromImage(bmp);
                pictureBox1.Image = bmp;
            }
        }

        private void Save_File(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch(tool)
            {
                case ActiveTool.Eraser:
                    break;
                case ActiveTool.Pen:
                    break;
                case ActiveTool.Line:
                    e.Graphics.DrawLine(pen, prevp, curp);
                    break;
                case ActiveTool.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(prevp, curp));
                    break;
                case ActiveTool.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle(prevp, curp));
                    break;
                case ActiveTool.Star:
                    GraphicsPath gp = new GraphicsPath();
                    gp.AddPolygon(new Point[]
                    {
                        new Point(prevp.X, curp.Y),
                        new Point((curp.X - prevp.X)/2 + prevp.X, prevp.Y),
                        new Point(curp.X, curp.Y),
                        new Point(prevp.X, prevp.Y + (curp.Y-prevp.Y)/2),
                        new Point(curp.X,  prevp.Y + (curp.Y-prevp.Y)/2),
                        new Point(prevp.X, curp.Y)
                    });
                    e.Graphics.DrawPath(pen, gp);
                    break;
            }
        }
    }
}