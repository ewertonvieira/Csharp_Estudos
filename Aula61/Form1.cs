namespace Aula61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = textBox1.Text + "@gmail.com";
            }
            else
            {
                label1.Text = textBox1 + "?????";
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}