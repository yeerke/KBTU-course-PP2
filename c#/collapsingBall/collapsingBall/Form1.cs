using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collapsingBall
{
    public partial class Form1 : Form
    {
        Ball ball;
        int r = 20;
        SolidBrush sb = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
            ball = new Ball(0, 200);
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(ball.x < 200 && ball.y < 200)
            {
                ball.x++;
                ball.y--;
            }
            if (ball.x > 200 && ball.y < 180)
            {
                ball.x++;
                ball.y++;
            }
            if (ball.x > 200 && ball.y > 180)
            {
                ball.x--;
                ball.y++;
            }
            if (ball.x < 200 && ball.y > 200)
            {
                ball.x--;
                ball.y--;
            }
            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(sb, ball.x, ball.y, r, r);
        }
    }
}
