using Biblioteca;

namespace AppListaDeTareas
{
    public partial class FrmPrincipal : Form
    {
        private GestorTareas gestorTareas;

        public FrmPrincipal()
        {
            InitializeComponent();
            gestorTareas = new GestorTareas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de la nueva tarea
                string descripcion = txtDescripcion.Text;
                bool completada = chkCompletada.Checked;

                // Crear una instancia de TareaSimple o TareaImportante según corresponda
                Tarea nuevaTarea;
                if (chkImportante.Checked)
                {
                    nuevaTarea = new TareaImportante();
                }
                else
                {
                    nuevaTarea = new TareaSimple();
                }

                // Establecer los datos de la nueva tarea
                nuevaTarea.Descripcion = descripcion;
                nuevaTarea.Completada = completada;

                // Agregar la tarea al gestor
                gestorTareas.AgregarTarea(nuevaTarea);

                // Limpiar los controles de entrada de datos
                txtDescripcion.Text = string.Empty;
                chkCompletada.Checked = false;
                chkImportante.Checked = false;

                // Actualizar la lista de tareas
                ActualizarListaTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActualizarListaTareas();
        }

        private void ActualizarListaTareas()
        {
            lstTareas.Items.Clear();

            List<Tarea> tareas = gestorTareas.ListarTareas();

            foreach (Tarea tarea in tareas)
            {
                lstTareas.Items.Add(tarea);
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTareas.SelectedItem != null)
                {
                    Tarea tareaSeleccionada = (Tarea)lstTareas.SelectedItem;
                    tareaSeleccionada.Completada = true;
                    ActualizarListaTareas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar la tarea como completada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}