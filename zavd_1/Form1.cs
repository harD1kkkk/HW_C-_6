namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int c = a + b;
            label3.Text = $"{c}";
            label3.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            double a = Int32.Parse(str1);
            double b = Int32.Parse(str2);

            double c = a / b;
            label3.Text = $"{c}";
            label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int c = a - b;
            label3.Text = $"{c}";
            label3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);

            int c = a * b;
            label3.Text = $"{c}";
            label3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
