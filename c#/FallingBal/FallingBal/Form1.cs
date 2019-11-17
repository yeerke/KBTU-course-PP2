using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingBal
{
    public partial class Form1 : Form
    {
        int r = 30;
        SolidBrush sb = new SolidBrush(Color.Blue);
        List<Ball> box;
        public Form1()
        {
            InitializeComponent();
            box = new List<Ball>();
            timer1.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            box.Add(new Ball(rand.Next(0, pictureBox1.Width), 0));
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < box.Count; i++)
            {
                box[i].y += 10;
            }
            pictureBox1.Refresh();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < box.Count; i++)
            {
                e.Graphics.FillEllipse(sb, box[i].x, box[i].y, r, r);
            }
        }
    }
}
