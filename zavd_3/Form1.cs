namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int symbol = 0;
            Random random = new Random();

            string str1 = textBox1.Text;
            string str2 = textBox2.Text;

            int a = Int32.Parse(str1);
            int b = Int32.Parse(str2);
            if (b > a)
            {
                MessageBox.Show("Error: Number of symbols cannot exceed the length of the password.");
                return;
            }

            string abetka = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string password = "";
            string passwordSymbol = "";

            for (int i = 0; i < a - b; i++)
            {
                int number = random.Next(0, 9);
                password += number.ToString();
            }

            for (int i = 0; i < b; i++)
            {
                int rand = random.Next(0, abetka.Length);
                char adolf = abetka[rand];
                passwordSymbol += adolf;
            }

            char[] Pass = new char[a];

            for (int j = 0; j < a; j++)
            {
                int type = random.Next(1, 3);
                if (type == 1)
                {
                    Pass[j] = password[random.Next(0, password.Length)];
                }
                else
                {
                    Pass[j] = passwordSymbol[random.Next(0, passwordSymbol.Length)];
                }
            }

            label3.Text = new string(Pass);
            label3.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}