using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        Worm worm;
        Fruit fruit;
        public Form1()
        {
            InitializeComponent();
            worm = new Worm(pictureBox1.Width / 2, pictureBox1.Height / 2);
            fruit = new Fruit(pictureBox1.Width, pictureBox1.Height);
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    worm.dy = -5;
                    worm.dx = 0;
                    break;
                case Keys.S:
                    worm.dy = 5;
                    worm.dx = 0;
                    break;
                case Keys.A:
                    worm.dx = -5;
                    worm.dy = 0;
                    break;
                case Keys.D:
                    worm.dx = 5;
                    worm.dy = 0;
                    break;
            }
            if (worm.IsEaten(fruit.point.x, fruit.point.y))
            {
                fruit = new Fruit(pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sbWorm = new SolidBrush(Color.Black);
            SolidBrush sbFruit = new SolidBrush(Color.Red);
            for (int i = 0; i < worm.body.Count; i++)
            {
                e.Graphics.FillEllipse(sbWorm, worm.body[i].x, worm.body[i].y, 20, 20);
            }
            e.Graphics.FillRectangle(sbFruit, fruit.point.x, fruit.point.y, 15, 15);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = fruit.point.x.ToString() + " " + fruit.point.y.ToString();
            textBox2.Text = worm.body[0].x.ToString() + " " + worm.body[0].y.ToString();
            worm.Move();
            pictureBox1.Refresh();
        }
    }
}
