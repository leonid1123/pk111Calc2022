namespace pk111
{
    public partial class Form1 : Form
    {
        public int by = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var a = (Button)sender;
            textBox1.Text += a.Text;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>14)
            {
                string txt = textBox1.Text;
                textBox1.Text = txt.Substring(0, 14); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            textBox1.Text = txt.Substring(0, textBox1.Text.Length-1);
        }
    }
}