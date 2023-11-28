using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp144
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            Point p1 = new Point(100, 100);
            Point p2 = new Point(200, 100);
            Point p3 = new Point(50, 150);
            Point p4 = new Point(250, 150);
            Point p5 = new Point(100, 300);
            Point p6 = new Point(200, 300);
            Pen pe = new Pen(System.Drawing.Color.Red);
            pe.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;//CTRL+SPACE
            pe.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(pe, p1, p2);
            g.DrawLine(pe, p3, p4);
            g.DrawLine(pe, p5, p6);
        }
    }
}
