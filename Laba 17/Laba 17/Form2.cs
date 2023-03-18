using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            g.DrawLine(pen, 110, 40, 140, 140);
            g.DrawLine(pen, 140, 140, 60, 90);
            g.DrawLine(pen, 60, 90, 160, 90);
            g.DrawLine(pen, 160, 90, 80, 140);
            g.DrawLine(pen, 80, 140, 110, 40);
        }
    }
}
