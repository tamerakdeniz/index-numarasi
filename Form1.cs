namespace arama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
           
            textBox3.Text = textBox1.Text.IndexOf(textBox2.Text).ToString();
            listBox1.Items.Add(textBox1.Text + " " + "İçerisinden" + " " + textBox2.Text + " " +
                 "Öbeğinin İlk Harfinin Bulunan İLK İndex Numarası " + textBox3.Text + " " + "'dir.");

            listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            textBox4.Text= textBox1.Text.LastIndexOf(textBox2.Text).ToString();
            listBox1.Items.Add(textBox1.Text + " " + "İçerisinden" + " " + textBox2.Text + " " +
                 "Öbeğinin İlk Harfinin Bulunan SON İndex Numarası " + textBox4.Text + " " + "'dir.");

            listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}