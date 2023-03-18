using System.Net.NetworkInformation;

namespace Laba_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double CalcGeoSum(int b1, int b2, int n)
        {
            double q, sum = 0;
            q = b2 / b1;

            if (q <= 1)
                sum = 0;
            else
                sum = (b1 * (Math.Pow(q, n) - 1)) / (q - 1);

            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            CalcGeoSum(a,b,c);
            textBox4.Text = CalcGeoSum(Convert.ToInt32(a),Convert.ToInt32(b),Convert.ToInt32(c)).ToString();

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "b1");
            dataGridView1.Columns.Add("Column1", "q");
            dataGridView1.Columns.Add("Column1", "n");
            dataGridView1.Columns.Add("Column1", "Ответ");

        }

        
    }
}