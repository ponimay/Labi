using System.Text.RegularExpressions;

namespace Laba_8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    a[i, j] = r.Next(-10, 10);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    textBox3.Text = Math.Abs(a[i, j]).ToString();
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown2.Value;
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            int[,] arr = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            Random rnd = new Random();
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    arr[i, j] = rnd.Next(-2, 1);

                }
            }
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}