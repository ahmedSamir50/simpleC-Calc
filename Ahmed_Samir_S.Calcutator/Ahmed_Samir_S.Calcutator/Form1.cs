using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmed_Samir_S.Calcutator
{
    public partial class Form1 : Form
    {
        Double result = 0.0;
        string operator_sign ="";
        bool ent_value = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void sampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void scienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //842, 389
            this.Width = 562;
            textBox1.Width = 530;

        }

        private void sampleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 281;
            textBox1.Width = 251;

            //281, 389;
        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (ent_value) )
                textBox1.Text = "";
            ent_value = false;
            Button numKey = (Button)sender;
            if (numKey.Text == ".") 
            { 
             if (textBox1.Text.Contains(".")==false )
             
             textBox1.Text=textBox1.Text+numKey.Text;
            }
             else
             textBox1.Text = textBox1.Text + numKey.Text;
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblshowOP.Text="";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblshowOP.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "") { textBox1.Text = "0"; }

        }

        private void Arith_operat(object sender, EventArgs e)
        {
            Button numOper= (Button)sender;
            operator_sign = numOper.Text;
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            lblshowOP.Text = Convert.ToString(result) + "" + operator_sign;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblshowOP.Text = "";
            switch(operator_sign)
            {
                case"+":textBox1.Text=(  (result+(Convert.ToDouble(textBox1.Text) ) ).ToString()  ) ;break;
                case "-": textBox1.Text = ((result - (Convert.ToDouble(textBox1.Text))).ToString()); break;
                case "*": textBox1.Text = ((result * (Convert.ToDouble(textBox1.Text))).ToString()); break;
                case "/": textBox1.Text = ((result / (Convert.ToDouble(textBox1.Text))).ToString()); break;
                case "Mod": lblshowOP.Text = result + " MOD( " + textBox1.Text + " )"; 
                    textBox1.Text = ((result % (Convert.ToDouble(textBox1.Text))).ToString());
                    break;
                case "^": textBox1.Text = ((result + (Convert.ToDouble(textBox1.Text))).ToString()); break;
                case "EXP": lblshowOP.Text = result + " EXP ( " + textBox1.Text + " )"; 
                    textBox1.Text = ( ( Math.Exp(Convert.ToDouble(textBox1.Text)*Math.Log(result*4) ) ).ToString()); break;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265358979323846";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double eLog = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " log10 " + "( " + textBox1.Text + " ) ";
            eLog = Math.Log10(eLog);
            textBox1.Text = eLog.ToString();
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double eSqrt = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " √ " + textBox1.Text ;
            eSqrt = Math.Sqrt(eSqrt);
            textBox1.Text = eSqrt.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double sinH = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " SinH " + textBox1.Text;
            sinH = Math.Sinh(sinH);
            textBox1.Text = sinH.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " Sin " + textBox1.Text;
            sin = Math.Sin(sin);
            textBox1.Text = sin.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double cosinH = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " CosinH " + textBox1.Text;
            cosinH = Math.Cosh(cosinH);
            textBox1.Text = cosinH.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double cosinH = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " Cosin " + textBox1.Text;
            cosinH = Math.Cosh(cosinH);
            textBox1.Text = cosinH.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double cosinH = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " tanh " + textBox1.Text;
            cosinH = Math.Tanh(cosinH);
            textBox1.Text = cosinH.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double cosinH = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " Tan " + textBox1.Text;
            cosinH = Math.Tan(cosinH);
            textBox1.Text = cosinH.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                int curr = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(curr, 2);
                lblshowOP.Text="Binary Sys.>> "+"( "+curr+" )";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Wrong Type Converting Or Error Occured");
                textBox1.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                int curr = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(curr, 16);
                lblshowOP.Text = "Hexa-Decimal Sys.>> " + "( " + curr + " )";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Wrong Type Converting Or Error Occured");
                textBox1.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                int curr = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(curr, 8);
                lblshowOP.Text = "Octal Sys.>> " + "( " + curr + " )";
            }
            catch (Exception exp) {
                MessageBox.Show("Wrong Type Converting Or Error Occured");
                textBox1.Text = "0";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                int curr = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(curr);
                lblshowOP.Text = "Decimal Sys.>> " + "( " + curr + " )";
            }

            catch (Exception exp)
            {
                MessageBox.Show("Wrong Type Converting Or Error Occured");
                textBox1.Text = "0";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            lblshowOP.Text = "POW( " + textBox1.Text + " )"+"^"+"(2)";
            double getPow = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = getPow.ToString();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            lblshowOP.Text = "POW ( " + textBox1.Text + " )" + "^" + "(3)";
            double getPow = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)  *Convert.ToDouble(textBox1.Text);
            textBox1.Text = getPow.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double len = Convert.ToDouble(textBox1.Text);
            lblshowOP.Text = " log " + "( " + textBox1.Text + " ) ";
            len = Math.Log(len);
            textBox1.Text = len.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            lblshowOP.Text = "POW ( " + textBox1.Text + " )" + "^" + "(-1)";
            double getPow = Convert.ToDouble(1 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = getPow.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
          
            double getPow = Convert.ToDouble(textBox1.Text)/Convert.ToDouble(100);
            textBox1.Text = getPow.ToString();

        }


    }
}
