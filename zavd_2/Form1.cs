namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;

            double a = Int32.Parse(str1);

            double c = (a * 9 / 5) + 32;
            label3.Text = $"{c}";
            label3.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text;

            double a = Int32.Parse(str1);

            double c = (a - 32) * 5 / 9;
            label4.Text = $"{c}";
            label4.Visible = true;
        }
    }
}
