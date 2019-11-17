using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        int width = 50, height = 50;
        Block block = new Block(150, 0);
        List<List<Block>> blocks = new List<List<Block>>();
        public Form1()
        {
            InitializeComponent();
            pictureBox2.BackColor = Color.Blue;
            timer1.Start();
            blocks.Add(new List<Block> { block});
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            SolidBrush sb = new SolidBrush(Color.Blue);
            for(int i = 0; i < blocks.Count; i++)
            {
                for (int j = 0; j < blocks[i].Count; i++)
                {
                    e.Graphics.FillRectangle(sb, blocks[i][j].x, blocks[i][j].y, width, height);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            bool check = true;
            if (e.KeyCode == Keys.A)
            {
                for(int i = 0; i < blocks[blocks.Count-1].Count; i++)
                {
                    blocks[blocks.Count - 1][i].x -= 50;
                }
            }
            else
            {
                if (e.KeyCode == Keys.D)
                {
                    for (int i = 0; i < blocks[blocks.Count - 1].Count; i++)
                    {
                        blocks[blocks.Count - 1][i].x += 50;
                    }
                }
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            /*if (blocks.Count > 2)
            {
                if (blocks[blocks.Count - 2].y <= 50)
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over!");
                }
            }*/
            bool check = false;
            int cnt = 0;
            bool q = false;
            /*for(int i = 0; i < blocks.Count; i++)
            {
                if(blocks[i].y > pictureBox1.Height - 70 && blocks[i].y < pictureBox1.Height-5)
                {
                        cnt++;
                    
                    if (cnt == 6)
                    {
                        foreach(List<Block> b in blocks)
                        {
                            b.y += 50;
                        }
                        blocks[blocks.Count - 1].y += 15;
                        q = true;
                        break;
                    }
                }
            }*/
            if (!q)
            {
                for (int i = 0; i < blocks.Count; i++)
                {
                    for (int j = 0; j < blocks[i].Count; j++)
                    {
                        if ((blocks[i][j].y - 50 == blocks[blocks.Count - 1][blocks[blocks.Count - 1].Count-1].y && blocks[i][j].x == blocks[blocks.Count - 1][blocks[blocks.Count - 1].Count - 1].x))
                        {
                            Block block1 = new Block(150, 0);
                            Block block2 = new Block(150, 50);
                            Block block3 = new Block(200, 50);
                            Block block4 = new Block(250, 50);
                            List<Block> l = new List<Block>() { block1, block2, block3, block4 };
                            blocks.Add(l);
                            check = true;
                            break;
                        }
                    }
                }
                if (!check)
                {
                    bool qw = false;
                    for (int i = 0; i < blocks[blocks.Count - 1].Count; i++)
                    {
                        if (blocks[blocks.Count - 1][i].y >= pictureBox1.Height - 50)
                        {
                            for (int j = 0; j < blocks[blocks.Count - 1].Count; j++)
                            {
                                blocks[blocks.Count - 1][j].y -= 5;
                                Block block1 = new Block(150, 0);
                                Block block2 = new Block(150, 50);
                                Block block3 = new Block(200, 50);
                                Block block4 = new Block(250, 50);
                                List<Block> l = new List<Block>() { block1, block2, block3, block4 };
                                blocks.Add(l);
                            }
                            qw = true;
                            break;
                        }
                    }
                    if (!qw)
                    {
                        for (int j = 0; j < blocks[blocks.Count - 1].Count; j++)
                        {
                            blocks[blocks.Count - 1][j].y += 5;
                        }
                    }
                    /*if (blocks[blocks.Count - 1].y >= pictureBox1.Height - 50)
                    {
                        blocks[blocks.Count - 1].y -= 5;
                        block = new Block();
                        blocks.Add(block);
                    }
                    else
                    {
                        blocks[blocks.Count - 1].y += 5;
                    }*/
                }
            }
            Refresh();            
        }
    }
}
