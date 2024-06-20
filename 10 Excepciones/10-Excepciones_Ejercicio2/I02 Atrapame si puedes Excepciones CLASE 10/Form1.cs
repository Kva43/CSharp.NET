namespace I02_Atrapame_si_puedes_Excepciones_CLASE_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
                {
                    throw new ParametrosVaciosException("Los parametros estan vacios");
                }
                if (!Int32.TryParse(textBox1.Text, out int num1) || !Int32.TryParse(textBox2.Text, out int num2))
                {
                    throw new FormatException("Formato incorrecto");
                }
                float var = Calculador.Calcular(num1, num2);
                this.richTextBox1.Text = $"Km/l : {var}";

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParametrosNoParseadosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}