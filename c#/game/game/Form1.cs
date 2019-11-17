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

namespace game
{
    public partial class Form1 : Form
    {
        Intelegence brain;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            button11.Enabled = false;

            button10.Visible = false;
            button10.Enabled = false;

            label1.Text = "You Play For O";
            label1.Enabled = true;
            label1.Visible = true;
            Refresh();
            Thread.Sleep(2000);
            label1.Enabled = false;
            label1.Visible = false;
            brain = new Intelegence("O", false);
            brain.realAI();
            start();
            update();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            button11.Enabled = false;

            button10.Visible = false;
            button10.Enabled = false;
            label2.Text = "You Play For X";
            label2.Enabled = true;
            label2.Visible = true;
            Refresh();
            Thread.Sleep(2000);
            label2.Enabled = false;
            label2.Visible = false;
            brain = new Intelegence("X", true);
            start();
        }
        private void isGameOver()
        {
            int[,] a = brain.a;
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < 3; i++)
            {
                cnt2 = 0;
                cnt1 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (a[j, i] == 2) cnt1++;
                    if (a[j, i] == 1) cnt2++;
                }
                if (cnt1 == 3)
                {
                    MessageBox.Show("You Won!!!");
                }
                if(cnt2 == 3)
                {
                    MessageBox.Show("You Lose!!!");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                cnt2 = 0;
                cnt1 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] == 2) cnt1++;
                    if (a[i, j] == 1) cnt2++;
                }
                if (cnt1 == 3)
                {
                    MessageBox.Show("You Won!!!");
                }
                if (cnt2 == 3)
                {
                    MessageBox.Show("You Lose!!!");
                }
            }
            if(a[0,0] == 1 && a[1,1] == 1 && a[2,2] == 1)
            {
                MessageBox.Show("You Lose!!!");
            }
            if (a[0, 0] == 2 && a[1, 1] == 2 && a[2, 2] == 2)
            {
                MessageBox.Show("You Won!!!");
            }
            if (a[2, 0] == 1 && a[1, 1] == 1 && a[2, 0] == 1)
            {
                MessageBox.Show("You Lose!!!");
            }
            if (a[2, 0] == 2 && a[1, 1] == 2 && a[2,0] == 2)
            {
                MessageBox.Show("You Won!!!");
            }
        }
            private void start()
        {
            button1.Enabled = true;
            button1.Visible = true;

            button2.Enabled = true;
            button2.Visible = true;

            button3.Enabled = true;
            button3.Visible = true;

            button4.Enabled = true;
            button4.Visible = true;

            button5.Enabled = true;
            button5.Visible = true;

            button6.Enabled = true;
            button6.Visible = true;

            button7.Enabled = true;
            button7.Visible = true;

            button8.Enabled = true;
            button8.Visible = true;

            button9.Enabled = true;
            button9.Visible = true;
        }
        private void update()
        {
            int[,] a = brain.a;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(a[i,j] != 0)
                    {
                        if(i == 0 && j == 0)
                        {
                            if(a[i,j] == 1)
                            {
                                if (brain.character == "X") button1.Text = "O";
                                else button1.Text = "X";
                            }
                            button1.Enabled = false;
                        }
                        if (i == 0 && j == 1)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button2.Text = "O";
                                else button2.Text = "X";
                            }
                            button2.Enabled = false;
                        }
                        if (i == 0 && j == 2)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button3.Text = "O";
                                else button3.Text = "X";
                            }
                            button3.Enabled = false;
                        }
                        if (i == 1 && j == 0)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button4.Text = "O";
                                else button4.Text = "X";
                            }
                            button4.Enabled = false;
                        }
                        if (i == 1 && j == 1)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button5.Text = "O";
                                else button5.Text = "X";
                            }
                            button5.Enabled = false;
                        }
                        if (i == 1 && j == 2)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button6.Text = "O";
                                else button6.Text = "X";
                            }
                            button6.Enabled = false;
                        }
                        if (i == 2 && j == 0)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button7.Text = "O";
                                else button7.Text = "X";
                            }
                            button7.Enabled = false;
                        }
                        if (i == 2 && j == 1)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button8.Text = "O";
                                else button8.Text = "X";
                            }
                            button8.Enabled = false;
                        }
                        if (i == 2 && j == 2)
                        {
                            if (a[i, j] == 1)
                            {
                                if (brain.character == "X") button9.Text = "O";
                                else button9.Text = "X";
                            }
                            button9.Enabled = false;
                        }
                    }

                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[0, 0] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[0, 1] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[0, 2] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[1, 0] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[1, 1] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[1, 2] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[2, 0] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[2, 1] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.Text = brain.character;
            brain.a[2, 2] = 2;
            isGameOver();
            brain.realAI();
            update();
            Refresh();
            isGameOver();
        }
    }
}
