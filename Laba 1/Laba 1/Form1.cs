namespace Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ìàòåìàòè÷åñêèåĞàñ÷åòûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 st = new Form2();
            st.Show();
            this.Hide();

        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}