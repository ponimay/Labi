using System.Windows.Forms;

namespace Laba_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}