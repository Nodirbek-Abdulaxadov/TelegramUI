namespace TelegramUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            BrushGray();
        }

        private void BrushGray()
        {
            pictureBox2.BackColor = label1.BackColor = label2.BackColor = label3.BackColor = Color.FromArgb(63, 72, 82);
        }
        private void BrushBlue()
        {
            pictureBox2.BackColor = label1.BackColor = label2.BackColor = label3.BackColor = Color.FromArgb(23, 33, 43);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BrushBlue();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}