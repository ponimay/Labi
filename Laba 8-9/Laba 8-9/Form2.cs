using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Reflection;

namespace Laba_8_9
{
    public partial class Form2 : Form
    {
        DataTable dataTable = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //считывает каждую строку и проверяет на дубликат
        {
            for (int count = 0; count < dataGridView1.Rows.Count - 1; count++)
            {
                DataGridViewRow rc = dataGridView1.Rows[count];

                for (int th = count + 1; th < dataGridView1.Rows.Count; th++)
                {
                    DataGridViewRow row = dataGridView1.Rows[th];

                    row.Selected = true;
                    if (!rc.Cells["Column1"].Value.Equals(row.Cells["Column1"].Value))
                    {
                        row.Selected = false;
                        break;
                    }
                    if (row.Selected)
                    {
                        rc.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)//перенести выделенные строки
            {
                object[] items = new object[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                dataGridView2.Rows.Add(items);
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Фамилия");
            dataGridView1.Columns.Add("Column2", "Имя");
            dataGridView1.Columns.Add("Column3", "Название класса (год обучения и буква)");
            dataGridView1.Columns.Add("Column4", "Математика");
            dataGridView1.Columns.Add("Column5", "Русский Язык");
            dataGridView1.Columns.Add("Column6", "Английский");

            dataGridView2.Columns.Add("Column1", "Фамилия");
            dataGridView2.Columns.Add("Column2", "Имя");
            dataGridView2.Columns.Add("Column3", "Название класса (год обучения и буква)");
            dataGridView2.Columns.Add("Column4", "Математика");
            dataGridView2.Columns.Add("Column5", "Русский Язык");
            dataGridView2.Columns.Add("Column6", "Английский");

        }

        private void button2_Click(object sender, EventArgs e) // вывод списка в таблицу
        {
            System.IO.Stream stre = null;
            OpenFileDialog OpenTags = new OpenFileDialog();
            OpenTags.Filter = "All file (*.*) | *.*| Text file |*.txt";
            OpenTags.FilterIndex = 2;
            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((stre = OpenTags.OpenFile()) != null)
                {
                    StreamReader read = new StreamReader(stre, System.Text.Encoding.Default);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = read.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num + 1;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('$');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                    dataGridView1.Sort(dataGridView1.Columns[dataGridView1.Rows.Count], ListSortDirection.Descending);//вывод списка по алфавиту по фамилии
                                }

                                catch (Exception ex)
                                {
                                    return;
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
