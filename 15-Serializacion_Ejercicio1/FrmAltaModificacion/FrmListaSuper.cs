using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAltaModificacion
{
    public partial class FrmListaSuper : Form
    {
        private static string rutaArchivo;
        private List<string> listaSupermercado;

        static FrmListaSuper()
        {
            string rutaApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);
        }

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElemento();
        }

        private void AgregarElemento()
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
                AlmacenarCambios();
                RefrescarLista();
            }
        }

    }
}
