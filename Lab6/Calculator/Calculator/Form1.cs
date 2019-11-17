using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Brain brain;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            displayTextDel display = DisplayText;
            brain = new Brain(display);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Process(btn.Text);
        }
        void DisplayText(string msg)
        {
            textBox1.Text = msg;
        }
    }
}
