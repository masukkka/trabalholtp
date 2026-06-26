namespace TESTEZADA
{
    public partial class Form1 : Form
    {
        double numero1;
        string operacao;
        Calculadora calc = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text);
            operacao = "*";
            txtDisplay.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }    
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Calculadora.Cosseno(numero).ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text);
            operacao = "+";
            txtDisplay.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double numero2 = Convert.ToDouble(txtDisplay.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = Calculadora.Somar(numero1, numero2);
                    break;

                case "-":
                    resultado = Calculadora.Subtrair(numero1, numero2);
                    break;

                case "*":
                    resultado = Calculadora.Multiplicar(numero1, numero2);
                    break;

                case "/":
                    resultado = Calculadora.Dividir(numero1, numero2);
                    break;
            }

            txtDisplay.Text = resultado.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text);
            operacao = "-";
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text);
            operacao = "/";
            txtDisplay.Clear();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Text = Calculadora.ConverterBinario(numero);
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Text = Calculadora.Fatorial(numero).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Calculadora.Tangente(numero).ToString();
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Calculadora.Seno(numero).ToString();
        }
    }
}
