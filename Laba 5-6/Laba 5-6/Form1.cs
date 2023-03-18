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
            chart1.Titles.Add("График синусоиды");
            label7.Visible = false;
        }

        private int foundWordsCount = 0;
        private string filePath = @"F:\Короткий текст.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10); // заполняем массив случайными числами от -10 до 9
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
                MessageBox.Show("В массиве нет отрицательных элементов");
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

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // установка стиля выпадающего списка
            comboBox1.Items.Add("Опция 1"); // добавление опций в выпадающий список
            comboBox1.Items.Add("Опция 2");
            comboBox1.Items.Add("Опция 3");

            ToolTip toolTip1 = new ToolTip(); // создание объекта ToolTip
            toolTip1.SetToolTip(comboBox1, "Выберите опцию"); // установка подсказки для ComboBox
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel3.Text = "Путь к файлу: " + filePath;
            toolStripStatusLabel2.Text = "Количество найденных слов: " + string.Format("Количество слов: {0}", foundWordsCount);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            // Устанавливаем размеры графика
            chart1.Size = new System.Drawing.Size(550, 600);

            // Создаем новую область графика
            ChartArea chartArea1 = new ChartArea();

            // Добавляем область графика в Chart
            chart1.ChartAreas.Add(chartArea1);

            // Создаем новую серию данных
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;

            // Задаем интервал на оси X
            double intervalStart = -10;
            double intervalEnd = double.Parse(textBox3.Text);

            // Добавляем точки данных в серию
            for (double x = intervalStart; x < intervalEnd; x += 0.1)
            {
                double y = Math.Sin(x);
                series1.Points.AddXY(x, y);
            }

            // Добавляем серию данных в Chart
            chart1.Series.Add(series1);

            // Добавляем Chart на форму
            this.Controls.Add(chart1);

        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                toolStripStatusLabel3.Text = "Путь к файлу: " + filePath;
            }
            string content = File.ReadAllText(openFileDialog1.FileName);
                
            // Считаем количество слов
            int wordsCount = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            foundWordsCount = wordsCount;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e) // Информация о координатах
        {
            // Вызываем метод HitTest для определения точки под курсором мыши
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            // Если на графике есть точка, на которую указывает курсор
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Получаем координаты точки
                double x = result.ChartArea.AxisX.PixelPositionToValue(e.X);
                double y = result.ChartArea.AxisY.PixelPositionToValue(e.Y);

                // Выводим информацию о координатах точки
                label7.Visible = true;
                label7.Text = string.Format("X = {0:0.##}, Y = {1:0.##}", x, y);
            }
            else
            {
                // Если курсор не находится на точке, то очищаем информацию
                label7.Text = "";
            }
        }
    }

}