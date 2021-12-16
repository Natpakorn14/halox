namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = Box2.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;
            Box1.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Box1.Text;
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            Box2.Text = f.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Box1.Text = "";
            Box2.Text = "";
        }
    }
}