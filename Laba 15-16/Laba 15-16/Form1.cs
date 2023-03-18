using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;

namespace Laba_15_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\Laba 15-16\\Laba 15-16\\image\\dog.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Графика графика = new Графика();
            графика.ShowDialog();
        }
    }
}