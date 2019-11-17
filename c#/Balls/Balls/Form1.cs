using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls
{
    public partial class Form1 : Form
    {
        int score = 0;
        Color checker;
        int q = 1000;
        Color[] colors;
        List<Ball> box;еп
        int r = 40;
        SolidBrush sb;
        public Form1()
        {
            InitializeComponent();
            colors = new Color[5] { Color.Red, Color.Blue, Color.Green, Color.Black, Color.Yellow};
            box = new List<Ball>();
            Random rand = new Random(DateTime.Now.Second);
            box.Add(new Ball(rand.Next(0, pictureBox1.Width), 0, colors[rand.Next(0, 100) % 5]));
            sb = new SolidBrush(Color.Black);
            checker = new Color();
            checker = Color.White;
            textBox1.Text = "score = 0";
            timer1.Start();
            timer2.Start();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < box.Count; i++)
            {
                if (q == i)
                {
                    sb.Color = Color.Violet;
                    e.Graphics.FillEllipse(sb, box[i].x-4, box[i].y-4, r+8, r+8);
                    sb.Color = box[i].color;
                    e.Graphics.FillEllipse(sb, box[i].x, box[i].y, r, r);
                }
                else
                {
                    sb.Color = box[i].color;
                    e.Graphics.FillEllipse(sb, box[i].x, box[i].y, r, r);
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < box.Count; i++)
            {
                if(box[i].y > pictureBox1.Height)
                {
                    if(q == i)
                    {
                        q = 1000;
                        checker = Color.White;
                    }
                    box.RemoveAt(i);
                    q--;
                    i--;
                }
                else
                {
                    box[i].y += 5;
                }
            }
            pictureBox1.Refresh();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            box.Add(new Ball(rand.Next(0, pictureBox1.Width), 0, colors[rand.Next()%5]));
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < box.Count; i++)
            {
                if((box[i].x + r - e.Location.X)*(box[i].x + r - e.Location.X) + (box[i].y + r - e.Location.Y)* (box[i].y + r - e.Location.Y) <= r * r)
                {
                    if(box[i].color == checker)
                    {
                        if (i != q)
                        {
                            if (i < q)
                            {
                                box.RemoveAt(q);
                                box.RemoveAt(i);
                            }
                            else
                            {
                                box.RemoveAt(i);
                                box.RemoveAt(q);
                            }
                            score += 10;
                            textBox1.Text = "score = " + score.ToString();
                            q = 1000;
                            checker = Color.White;
                        }
                        else
                        {
                            q = 1000;
                            checker = Color.White;
                        }
                    }
                    else
                    {
                        q = i;
                        checker = box[i].color;
                    }
                    break;
                }
            }
        }

    }
}
