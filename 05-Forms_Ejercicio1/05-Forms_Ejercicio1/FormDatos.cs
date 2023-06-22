using System.Text;

namespace _05_Forms_Ejercicio1
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            comboBoxMaterias.Items.Add("Programación I");
            comboBoxMaterias.Items.Add("Matematicas");
            comboBoxMaterias.Items.Add("Ingles I");
            comboBoxMaterias.Items.Add("Programación II");
            comboBoxMaterias.Items.Add("Laboratorio II");
            comboBoxMaterias.Items.Add("Estadistica");
            comboBoxMaterias.SelectedIndex = 0;
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            string titulo = "¡Hola, Windows Forms!";
            string mensaje = $"Soy {textBoxNombre.Text} {textBoxApellido.Text} y mi materia favorita es {comboBoxMaterias.SelectedItem}";

            if(Validar())
            {
                FormSaludo formSaludo = new FormSaludo(titulo, mensaje);
                formSaludo.ShowDialog();
            }

            bool Validar()
            {
                bool esValido = true;

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine("Se deben completar los siguientes campos:");

                if(String.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    stringBuilder.AppendLine("Nombre");
                    esValido = false;
                }

                if (String.IsNullOrWhiteSpace(textBoxApellido.Text))
                {
                    stringBuilder.AppendLine("Apellido");
                    esValido = false;
                }

                if(!esValido)
                {
                    MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return esValido;
            }
        }
    }
}