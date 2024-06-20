using Biblioteca;

namespace _05_Forms_Ejercicio2
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            Ingresante alumnoNuevo = new Ingresante(textBoxNombre.Text, textBoxDireccion.Text, buscarRadioButtonSeleccionado(), listBoxPais.Text, (int)numericUpDownEdad.Value, buscarCursosSeleccionados());
            MessageBox.Show(alumnoNuevo.Mostrar());
        }

        private string buscarRadioButtonSeleccionado()
        {
            string opcionSeleccionada = "";

            if (radioButtonMasculino.Checked)
            {
                opcionSeleccionada = "Masculino";
            }
            else if (radioButtonFemenino.Checked)
            {
                opcionSeleccionada = "Femenino";
            }
            else if (radioButtonNoBinario.Checked)
            {
                opcionSeleccionada = "No binario";
            }

            return opcionSeleccionada;
        }

        private string[] buscarCursosSeleccionados()
        {
            List<string> cursosSeleccionados = new List<string>();

            if (checkBoxCPlus.Checked)
            {
                cursosSeleccionados.Add("C++");
            }

            if (checkBoxCSharp.Checked)
            {
                cursosSeleccionados.Add("C#");
            }

            if (checkBoxJS.Checked)
            {
                cursosSeleccionados.Add("Javascript");
            }

            return cursosSeleccionados.ToArray();
        }
    }
}