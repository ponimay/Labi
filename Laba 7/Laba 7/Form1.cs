using System.Windows.Forms;

namespace Laba_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] arr = new int[4, 4];
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = rnd.Next(-2, 1);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                    if (((j + 1) % 2 == 0))
                    {
                        sum += arr[i, j];
                        textBox1.Text = Convert.ToString(sum);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;
        }
    }
}