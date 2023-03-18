namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);
            double c = int.Parse(textBox3.Text);
            if ((a > b) && (a > c))
            {
                MessageBox.Show($"{a} = максимальное число");
                textBox4.Text = Convert.ToString(a);
            }
            else if ((b > a) && (b > c))
            {
                MessageBox.Show($"{b} = максимальное число");
                textBox4.Text = Convert.ToString(b);
            }
            else
            {
                MessageBox.Show($"{c} = максимальное число"); textBox4.Text = Convert.ToString(c);
            }
                
        }
    }
}