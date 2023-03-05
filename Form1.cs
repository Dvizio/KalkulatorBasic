namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bilangan1 = double.Parse(textBox1.Text);
            double bilangan2 = double.Parse(textBox2.Text);
            double hasil = bilangan1 + bilangan2;
            textBox3.Text = hasil.ToString();
            textBox4.Text = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bilangan1 = double.Parse(textBox1.Text);
            double bilangan2 = double.Parse(textBox2.Text);
            double hasil = bilangan1 - bilangan2;
            textBox3.Text = hasil.ToString();
            textBox4.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double bilangan1 = double.Parse(textBox1.Text);
            double bilangan2 = double.Parse(textBox2.Text);
            double hasil = bilangan1 * bilangan2;
            textBox3.Text = hasil.ToString();
            textBox4.Text = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double bilangan1 = double.Parse(textBox1.Text);
            double bilangan2 = double.Parse(textBox2.Text);
            double hasil = bilangan1 / bilangan2;
            textBox3.Text = hasil.ToString();
            textBox4.Text = ":";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}