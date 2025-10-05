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
            int sayi1 = Convert.ToInt32(textBox1Sayý.Text);
            int sayi2 = Convert.ToInt32(textBox2Sayý.Text);
            textBox1Sonuç.Text = (sayi1 + sayi2).ToString();
        }

        private void buttonÇýkar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Sayý.Text);
            int sayi2 = Convert.ToInt32(textBox2Sayý.Text);
            textBox1Sonuç.Text = (sayi1 - sayi2).ToString();
        }

        private void buttonÇarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Sayý.Text);
            int sayi2 = Convert.ToInt32(textBox2Sayý.Text);
            textBox1Sonuç.Text = (sayi1 * sayi2).ToString();
        }

        private void buttonBöl_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1Sayý.Text);
            int sayi2 = Convert.ToInt32(textBox2Sayý.Text);
            if (sayi2 != 0)
            {
                float sonuç = (float)sayi1 / sayi2;
                textBox1Sonuç.Text = sonuç.ToString();
            }
            else
            { textBox1Sonuç.Text = "Tanýmsýz";
            }
        }
    }
}
