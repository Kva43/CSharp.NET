using System.Text;

namespace _05_Forms_EjercicioExtra2
{
    public partial class FrmTabla : Form
    {
        public FrmTabla()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; //saca el sonido cuando presionas la tecla ENTER
                GenerarTabla();
            }
        }

        private void GenerarTabla()
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                lstTabla.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    lstTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            txtNumero.Clear();
        }

        private void FrmTabla_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Confirmar cierre", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }
    }
}