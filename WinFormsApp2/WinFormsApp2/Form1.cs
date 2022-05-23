using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char islem;
        double sayi, sayi2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label2.Text += sayi.ToString() + " + ";
            islem = '+';

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label2.Text += sayi.ToString() + " - ";
            islem = '-';
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(label1.Text);
            label1.Text = "0"; 
            label2.Text += sayi.ToString() + " x ";
            islem = 'x';

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label2.Text += sayi.ToString() + " / ";
            islem = '/';

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += ".";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(label1.Text);
            label2.Text += sayi2.ToString() + " = ";
            if (islem == '+')
            {
                label1.Text = (sayi + sayi2).ToString();
                sayi = sayi + sayi2;
            }
            else if (islem == '-')
            {
                label1.Text = (sayi - sayi2).ToString();
            }
            else if (islem == 'x')
            {
                label1.Text = (sayi * sayi2).ToString();
            }
            else if (islem == '/')
            {
                label1.Text = (sayi / sayi2).ToString();
            }

        }
    }
}