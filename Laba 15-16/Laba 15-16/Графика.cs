using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Laba_15_16
{
    public partial class Графика : Form
    {
        public Графика()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Графика_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Yellow);
            pen.Width = 5; // установка толщины линий в 5 пикселей
            g.FillEllipse(Brushes.Yellow, 830, -75, 150, 150);
            g.DrawLine(pen, 800, 70, 650, 150);
            g.DrawLine(pen, 860, 85, 780, 250);
            g.DrawLine(pen, 780, 40, 600, 100);

            // Рисуем крышу
            g.DrawLine(Pens.Black, 20, 50, 60, 20);
            g.DrawLine(Pens.Black, 60, 20, 100, 50);

            // Рисуем стены
            g.DrawLine(Pens.Black, 20, 50, 20, 150);
            g.DrawLine(Pens.Black, 100, 50, 100, 150);
            g.DrawLine(Pens.Black, 20, 150, 100, 150);

            // Рисуем дверь
            g.DrawLine(Pens.Black, 45, 150, 45, 100);
            g.DrawLine(Pens.Black, 45, 100, 75, 100);
            g.DrawLine(Pens.Black, 75, 100, 75, 150);

        }
    }
}
