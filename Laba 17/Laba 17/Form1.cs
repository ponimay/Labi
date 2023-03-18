namespace Laba_17
{
    public partial class Form1 : Form
    {
        private int x = 300;
        private int y = 200;
        private int radius = 10; // по заданию 10 
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 50; // 50 мс между срабатываниями таймера
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Изменяем координату по оси x на -5
            x -= 5;

            // Перерисовываем круг с новыми координатами
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Рисуем круг с текущими координатами
            e.Graphics.FillEllipse(Brushes.Red, x - radius, y - radius, 2 * radius, 2 * radius);
        }
    }
}
