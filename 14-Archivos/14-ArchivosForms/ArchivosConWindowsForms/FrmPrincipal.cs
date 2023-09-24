using Newtonsoft.Json;
using System;
using System.Text.Json.Nodes;

namespace ArchivosConWindowsForms
{
    public partial class FrmPrincipal : Form
    {
        private List<Datos> datos;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaArchivo = "C:\\Users\\crist\\OneDrive\\Escritorio\\MOCK_DATA.json";
            string contenidoArchivo = File.ReadAllText(rutaArchivo);
            datos = JsonConvert.DeserializeObject<List<Datos>>(contenidoArchivo);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            MostrarDato("nombre");
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            MostrarDato("apellido");
        }

        private void btnLegajo_Click(object sender, EventArgs e)
        {
            MostrarDato("legajo");
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            MostrarDato("correo");
        }

        private void btnClave_Click(object sender, EventArgs e)
        {
            MostrarDato("clave");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MostrarDato("perfil");
        }

        private void MostrarDato(string campo)
        {
            // Obtiene el primer objeto de la lista y busca el valor del campo especificado
            Datos primerObjeto = datos[0];
            Datos segundoObjeto = datos[1];
            string valor = null;

            switch (campo)
            {
                case "nombre":
                    valor = segundoObjeto.nombre;
                    break;
                case "apellido":
                    valor = primerObjeto.apellido;
                    break;
                case "legajo":
                    valor = primerObjeto.legajo.ToString();
                    break;
                case "correo":
                    valor = primerObjeto.correo;
                    break;
                case "clave":
                    valor = primerObjeto.clave;
                    break;
                case "perfil":
                    valor = primerObjeto.perfil;
                    break;
            }

            MessageBox.Show(valor);
        }
    }

    public class Datos
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int legajo { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string perfil { get; set; }
    }
}

    