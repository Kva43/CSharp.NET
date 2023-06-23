namespace _05_Forms_EjercicioExtra3
{
    public partial class FrmDescuento : Form
    {
        public FrmDescuento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CalcularCostos();
        }

        private void CalcularCostos()
        {
            if (int.TryParse(txtBoxIngreso.Text, out int numero))
            {

                if (numero >= 3000 && numero <= 5000)
                {
                    double total = numero * 0.9;
                    txtBoxTotal.Text = total.ToString();

                    double descuento = numero * 0.1;
                    txtBoxDescuento.Text = descuento.ToString();
                }
                else if (numero > 5000)
                {
                    double total = numero * 0.8;
                    txtBoxTotal.Text = total.ToString();

                    double descuento = numero * 0.2;
                    txtBoxDescuento.Text = descuento.ToString();
                }
                else
                {
                    txtBoxTotal.Text = numero.ToString();
                }
            }
            else
            {
                MessageBox.Show($"Ingrese un número válido!");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxIngreso.Clear();
            txtBoxDescuento.Clear();
            txtBoxTotal.Clear();
        }
    }
}