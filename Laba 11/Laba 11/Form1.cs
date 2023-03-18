using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Laba_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "All file (*.*) | *.*| Text file |*.txt";
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    string path = Open.FileName;
                    List<string> lines = new List<string>();
                    using (StreamReader r = new StreamReader(Open.OpenFile()))
                    {
                        listBox1.DataSource = File.ReadAllLines(path);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "All file (*.*) | *.*| Text file |*.txt";
                string path = save.FileName;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter w = new StreamWriter(save.FileName);

                    foreach (var item in listBox1.Items)
                        w.WriteLine(item.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 q=new Form2();
            q.ShowDialog();
        }
    }
}