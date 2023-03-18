using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Laba_13
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        private string fileName = "D:\\t4.txt";
        public Form1()
        {
            InitializeComponent();

            table.Columns.Add("Название_игрушки");
            table.Columns.Add("Стоимость");
            table.Columns.Add("Возрастные_границы");
            table.Rows.Add("Юла", "300", "от 7 до 9 лет");
            table.Rows.Add("Мяч", "150", "от 3 до 5 лет");
            table.Rows.Add("Паровоз", "500", "от 1 до 2 лет");
            

            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All file (*.*) | *.*| Text file |*.txt";
            saveFileDialog1.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter write = new StreamWriter(File.OpenWrite(fileName));

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            write.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        write.WriteLine("");
                        write.WriteLine("-----------------------------------------------------");
                    }
                    write.Close();
                }

                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Стоимость <= 200";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = " [Возрастные_границы] = '" + "от 3 до 5 лет" + "'";

        }
    }
}

