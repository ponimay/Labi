namespace Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 st = new Form2();
            st.Show();
            this.Hide();

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}