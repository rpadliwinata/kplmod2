namespace modul2_1302200028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == " ")
            {
                result.Text = "1";
            } else
            {
                result.Text = result.Text + "1";
            }
        }
    }
}