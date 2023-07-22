using Library;
using Newtonsoft.Json;

namespace AltaBajaAerolinea
{
    public partial class FrmMain : Form
    {
        private List<Datos> datos;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string rutaArchivo = "C:\\Users\\crist\\OneDrive\\Escritorio\\MOCK_DATA.json";
            string contenidoArchivo = File.ReadAllText(rutaArchivo);
            datos = JsonConvert.DeserializeObject<List<Datos>>(contenidoArchivo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}