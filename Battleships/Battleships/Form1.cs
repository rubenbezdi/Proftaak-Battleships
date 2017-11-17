using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void hi()
        {
            MessageBox.Show("");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(new Pen(Brushes.Black), 400, 0, 400, 400);
            //if(kaart[3,4].Schip)
            {
                g.DrawEllipse(new Pen(Brushes.Black), 400, 400, 100, 100);
            }
        }
    }
}
