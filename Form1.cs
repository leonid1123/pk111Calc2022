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
        { //переписать по нормальному
            var a = (Button)sender;
            if (a.Text ==",") 
            {
                if (textBox1.Text.IndexOf(",") == -1)
                {
                    textBox1.Text += a.Text;
                }

            } else
            {
                textBox1.Text += a.Text;
            }
            

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            button6.Text = "X\u00B2";
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
            if (textBox1.Text.Length<1)
            {
                textBox1.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//стереть всё
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {//расчет обратного числа
            float x = float.Parse(textBox1.Text);
            if (x!=0)
            {
                x = 1 / x;
                textBox1.Text = x.ToString(); 
            }
             
        }

        private void button6_Click(object sender, EventArgs e)
        {//возведение в квадрат
            float x = float.Parse(textBox1.Text);
            x = x * x;
            textBox1.Text = x.ToString();

        }
    }
}