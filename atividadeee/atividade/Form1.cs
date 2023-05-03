namespace atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //class Circulo
            Circulo circulo = new Circulo();
            //valor ja definido "3"

            circulo.Raio = 0;
            //armazenar um numero na variavel raio

            double raio = Convert.ToDouble(textBox1.Text);

            //atribuir o valor da variavel raio para a propriedade Raio

            circulo.Raio = raio;



            MessageBox.Show("A área do círculo é: " + circulo.CalcularArea);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();

            retangulo.LadoA = 0;
            retangulo.LadoB = 0;

            //armazenar um numero na variavel LadoA

            retangulo.LadoA = Convert.ToDouble(textBox2.Text);

            //armazenar um numero na variavel LadoB

            retangulo.LadoB = Convert.ToDouble(textBox3.Text);

            MessageBox.Show("A área do retângulo é: " + retangulo.CalcularArea);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.A = 0;
            triangulo.B = 0;
            triangulo.C = 0;

            //armazenar um numero na variavel A

            triangulo.A = Convert.ToDouble(textBox4.Text);

            //armazenar um numero na variavel B

            triangulo.B = Convert.ToDouble(textBox5.Text);

            //armazenar um numero na variavel C



            MessageBox.Show("A área do triângulo é: " + triangulo.CalcularArea);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //armazenar um numero na variavel raio

            //double raio = Convert.ToDouble(textBox1.Text);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
