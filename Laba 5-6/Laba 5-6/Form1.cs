using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Laba_5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("������ ���������");
            label7.Visible = false;
        }

        private int foundWordsCount = 0;
        private string filePath = @"F:\�������� �����.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10); // ��������� ������ ���������� ������� �� -10 �� 9
            }

            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && arr[i] < min)
                {
                    min = arr[i];
                }
            }

            if (min == int.MaxValue)
            {
                MessageBox.Show("� ������� ��� ������������� ���������");
            }
            else
            {
                textBox1.Text = min.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // ��������� ����� ����������� ������
            comboBox1.Items.Add("����� 1"); // ���������� ����� � ���������� ������
            comboBox1.Items.Add("����� 2");
            comboBox1.Items.Add("����� 3");

            ToolTip toolTip1 = new ToolTip(); // �������� ������� ToolTip
            toolTip1.SetToolTip(comboBox1, "�������� �����"); // ��������� ��������� ��� ComboBox
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel3.Text = "���� � �����: " + filePath;
            toolStripStatusLabel2.Text = "���������� ��������� ����: " + string.Format("���������� ����: {0}", foundWordsCount);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            // ������������� ������� �������
            chart1.Size = new System.Drawing.Size(550, 600);

            // ������� ����� ������� �������
            ChartArea chartArea1 = new ChartArea();

            // ��������� ������� ������� � Chart
            chart1.ChartAreas.Add(chartArea1);

            // ������� ����� ����� ������
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;

            // ������ �������� �� ��� X
            double intervalStart = -10;
            double intervalEnd = double.Parse(textBox3.Text);

            // ��������� ����� ������ � �����
            for (double x = intervalStart; x < intervalEnd; x += 0.1)
            {
                double y = Math.Sin(x);
                series1.Points.AddXY(x, y);
            }

            // ��������� ����� ������ � Chart
            chart1.Series.Add(series1);

            // ��������� Chart �� �����
            this.Controls.Add(chart1);

        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                toolStripStatusLabel3.Text = "���� � �����: " + filePath;
            }
            string content = File.ReadAllText(openFileDialog1.FileName);
                
            // ������� ���������� ����
            int wordsCount = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            foundWordsCount = wordsCount;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e) // ���������� � �����������
        {
            // �������� ����� HitTest ��� ����������� ����� ��� �������� ����
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            // ���� �� ������� ���� �����, �� ������� ��������� ������
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // �������� ���������� �����
                double x = result.ChartArea.AxisX.PixelPositionToValue(e.X);
                double y = result.ChartArea.AxisY.PixelPositionToValue(e.Y);

                // ������� ���������� � ����������� �����
                label7.Visible = true;
                label7.Text = string.Format("X = {0:0.##}, Y = {1:0.##}", x, y);
            }
            else
            {
                // ���� ������ �� ��������� �� �����, �� ������� ����������
                label7.Text = "";
            }
        }
    }

}