using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool processed = false;
        bool memory_flag = false;
        Double memory;
        float iCelsius;
        float iFahrenheit;
        float iKevin;
        char iOperatoin;
        
        public Form1()
        {
            InitializeComponent();
            buttonMR.Enabled = false;
            buttonMC.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (processed || result.Text == "0" || memory_flag)
            {
                result.Clear();

            }
            processed = false;
            memory_flag = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text += button.Text;
                }
            }
            else
            {
                result.Text += button.Text;

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(result.Text, CultureInfo.InvariantCulture);
            result.Text = "";
            equation.Text = System.Convert.ToString(value) + " " + operation;
            processed = true;



        }

        // operations
        private void button18_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "*":
                    result.Text = (value * Double.Parse(result.Text,CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "+":
                    result.Text = (value + Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "Mod":
                    result.Text = (value % Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(result.Text);
                    double q;
                    q = (value);
                    result.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 350;
            result.Width = 275;
        }

        // memory read
        private void MR_Click(object sender, EventArgs e)
        {
            result.Text = memory.ToString();
            memory_flag = true;
        }

        // memory safe
        private void buttonMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(result.Text);

            buttonMR.Enabled = true;
            buttonMC.Enabled = true;
            memory_flag = true;
        }

        // memory clear
        private void buttonMC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            memory = 0;
            buttonMC.Enabled = false;
            buttonMR.Enabled = false;


        }

        // memory plus
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(result.Text);
        }

        // memory minus
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(result.Text);
        }

        // square root
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Double root = Math.Sqrt(Convert.ToDouble(result.Text));
            result.Text = Convert.ToString(root);

        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 350;
            result.Width = 275;

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 627;
            result.Width = 575;
        }

        private void tempritureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1080;
            result.Width = 575;
            txtConvert.Focus();
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox3.Location = new Point(823, 109);
            groupBox3.Width = 463;
            groupBox3.Height = 429;
        }

        private void unitConvertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1080;
            result.Width = 575;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1080;
            result.Width = 575;
            txtMultiply.Focus();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(610, 75);
            groupBox3.Width = 420;
            groupBox3.Height = 380;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }
            if (result.Text == "")
            {
                result.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            result.Text = "3.141592653589976323";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            iLog = Math.Log10(iLog);
            result.Text = System.Convert.ToString(iLog);

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Sqrt" + "(" + (result.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            result.Text = System.Convert.ToString(sqrt);
        }

        private void buttonSinh_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Sinh" + "(" + (result.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            result.Text = System.Convert.ToString(qSinh);
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Sin" + "(" + (result.Text) + ")");
            sin = Math.Sin(sin);
            result.Text = System.Convert.ToString(sin);

        }

        private void buttoCosh_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Cosh" + "(" + (result.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            result.Text = System.Convert.ToString(qCosh);
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Cos" + "(" + (result.Text) + ")");
            cos = Math.Cos(cos);
            result.Text = System.Convert.ToString(cos);
        }

        private void buttonTanh_Click(object sender, EventArgs e)
        {

            double tanh = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Tanh" + "(" + (result.Text) + ")");
            tanh = Math.Tanh(tanh);
            result.Text = System.Convert.ToString(tanh);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("Tan" + "(" + (result.Text) + ")");
            tan = Math.Tan(tan);
            result.Text = System.Convert.ToString(tan);
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 2);
        }

        private void buttonHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 16);
        }

        private void buttonOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a, 8);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void button3Root_Click(object sender, EventArgs e)
        {
            Double root3 = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(root3);
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(result.Text);
            result.Text = System.Convert.ToString("log" + "(" + (result.Text) + ")");
            iLog = Math.Log(iLog);
            result.Text = System.Convert.ToString(iLog);
        }
        // cel to fah
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperatoin = 'C';
        }
        private void rbFahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperatoin = 'F';
        }

        private void rbKevin_CheckedChanged(object sender, EventArgs e)
        {
            iOperatoin = 'K';
        }
        private void button_Convert(object sender, EventArgs e)
        {
            switch (iOperatoin)
            {
                case 'C':
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFahrenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    iKevin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9 * iKevin) / 5) + 32) + 273.15).ToString());
                    break;
                default:
                    break;

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            txtConvert.Clear();
            lblConvert.Text = "";

            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;
            rbKevin.Checked = false;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMultiply.Text);
            for (int i = 1; i < 21; i++)
            {
                listMultiply.Items.Add(i + " x " + a + " = " + a * i);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonResetMultiply_Click(object sender, EventArgs e)
        {
            listMultiply.Items.Clear();
            txtMultiply.Clear();
        }

        private void listMultiply_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
