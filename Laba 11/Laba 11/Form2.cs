using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Laba_11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string fileName = "Untitled";
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "Untitled";
            textBoxEdit.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Text Documents(*.txt) | *.txt | SE Documents(*.setxt) | *.setxt | All Files | *.*";
            Open.FilterIndex = 2;
            if (Open.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                try
                {
                    using (StreamReader reader = File.OpenText(fileName))
                    {
                        textBoxEdit.Clear();
                        textBoxEdit.Text = reader.ReadToEnd();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Documents (*.txt)|*.txt| SE Documents (*.setxt) |*.setxt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgSave.FileName;
                // запись в файл
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBoxEdit.Text);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "Untitled")
                saveAsToolStripMenuItem_Click(sender, e);
            else
            {
                try
                {
                    Stream stream = File.OpenWrite(fileName);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(textBoxEdit.Text);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Simple Editor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void downloadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Данные файла");
            dataGridView1.Columns[0].Width = 600;

            Stream stre = null;
            OpenFileDialog OpenTags = new OpenFileDialog();
            OpenTags.Filter = "All file (*.*) | *.*| Text file |*.txt";
            OpenTags.FilterIndex = 2;
            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((stre = OpenTags.OpenFile()) != null)
                {
                    StreamReader read = new StreamReader(stre, Encoding.Default);
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

        private void addDataToAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text Documents (*.txt)|*.txt| SE Documents (*.setxt) |*.setxt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSave.FileName;
                    // запись в файл
                    try
                    {
                        Stream stream = File.OpenWrite(fileName);
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(textBox1.Text);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Simple Editor",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Возникла ошибка!", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
