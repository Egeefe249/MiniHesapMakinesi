namespace WinFormsAppMiniHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Say�.Text);
            int sayi2 = Convert.ToInt32(textBox2Say�.Text);
            textBox1Sonu�.Text = (sayi1 + sayi2).ToString();
        }

        private void button��kar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Say�.Text);
            int sayi2 = Convert.ToInt32(textBox2Say�.Text);
            textBox1Sonu�.Text = (sayi1 - sayi2).ToString();
        }

        private void button�arp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Say�.Text);
            int sayi2 = Convert.ToInt32(textBox2Say�.Text);
            textBox1Sonu�.Text = (sayi1 * sayi2).ToString();
        }

        private void buttonB�l_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Say�.Text);
            int sayi2 = Convert.ToInt32(textBox2Say�.Text);
            if (sayi2 != 0)
            {
                float sonu� = (float)sayi1 / sayi2;
                textBox1Sonu�.Text = sonu�.ToString();
            }
            else
            { textBox1Sonu�.Text = "Tan�ms�z";
            }
        }
    }
}
