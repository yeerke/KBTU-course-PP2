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

namespace GraphicPath
{
    public partial class Form1 : Form
    {
        GraphicsPath gp = new GraphicsPath();
        int x = 200, y = 200, r = 100;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPath(pen.Brush, gp);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gp.IsVisible(e.Location))
            {
                pen = new Pen(Color.Blue);
            }
            else
            {
                pen = new Pen(Color.Red);
            }
            Refresh();
        }

        Pen pen = new Pen(Color.Red);
        public Form1()
        {
            InitializeComponent();
            gp.AddEllipse(new Rectangle(x - r, y - r, 2 * r, 2 * r));
            gp.AddRectangle(new Rectangle(x + r, y + r, r, r));
        }
    }
}
