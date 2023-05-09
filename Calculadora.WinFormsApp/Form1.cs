namespace Calculadora.WinFormsApp
{
    public partial class Form1 : Form
    { 
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            double valor1 = Convert.ToDouble(textBox1.Text);
            double valor2 = Convert.ToDouble(textBox2.Text);
            double resultado = 0;
            
            switch (op)
            {
                case "+": resultado = calculadora.Somar(valor1, valor2); break;
                case "-": resultado = calculadora.Subtrair(valor1, valor2); break;
                case "*": resultado = calculadora.Multiplicar(valor1, valor2); break;
                case "/": resultado = calculadora.Dividir(valor1, valor2); break;
            }

            textBox3.Text = resultado.ToString();
        }
    }
}