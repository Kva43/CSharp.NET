namespace Ejercicio_IO2_CLASE_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parametro1 = textBox1.Text;
            string parametro2 = textBox2.Text;

            try
            {
                if (string.IsNullOrEmpty(parametro1) || string.IsNullOrEmpty(parametro2))
                {
                    throw new ParametrosVaciosException();
                }

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                int numero1 = int.Parse(parametro1);
                int numero2 = int.Parse(parametro2);

                richTextBox1.Text = (numero1 + numero2).ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en la conversión de parámetros. Asegúrate de ingresar valores numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}