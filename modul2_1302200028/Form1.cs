namespace modul2_1302200028
{
    public partial class Form1 : Form
    {
        int first_number, second_number, result_number;
        public Form1()
        {
            InitializeComponent();
            result_number = -1;
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            second_number = int.Parse(result.Text);
            result_number = first_number + second_number;
            result.Text = result_number.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "1";
            } else
            {
                result.Text = result.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "2";
            }
            else
            {
                result.Text = result.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "3";
            }
            else
            {
                result.Text = result.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "4";
            }
            else
            {
                result.Text = result.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "5";
            }
            else
            {
                result.Text = result.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "6";
            }
            else
            {
                result.Text = result.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "7";
            }
            else
            {
                result.Text = result.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "8";
            }
            else
            {
                result.Text = result.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == " " || result_number != -1)
            {
                result_number = -1;
                result.Text = "9";
            }
            else
            {
                result.Text = result.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (result.Text == " ")
            {
                result.Text = "0";
            }
            else
            {
                result.Text = result.Text + "0";
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            first_number = int.Parse(result.Text);
            result.Text = " ";
        }
    }
}