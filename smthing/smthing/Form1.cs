using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smthing
{
    public partial class Form1 : Form
    {
        ball bal;
        podnos pod;
        public Form1()
        {
            InitializeComponent();
            bal = new ball(pictureBox1.Height/2, pictureBox1.Width / 2, 20);
            pod = new podnos(100, 20, pictureBox1.Height - 20, pictureBox1.Width / 2);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                
            }
            if(e.KeyCode == Keys.Right)
            {
                
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
