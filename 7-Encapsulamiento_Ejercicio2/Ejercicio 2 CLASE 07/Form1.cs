using System.Windows.Forms;

namespace Ejercicio_2_CLASE_07
{
    public partial class Form1 : Form
    {
        private string? lastFilePath;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.TextChanged += RichTextBox_TextChanged;
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Actualizar la cantidad de caracteres en el StatusStrip
            toolStripStatusLabel1.Text = $"Caracteres: {richTextBox1.TextLength}";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    lastFilePath = filePath;

                    // Leer el contenido del archivo y mostrarlo en el RichTextBox
                    richTextBox1.Text = File.ReadAllText(filePath);
                }
                catch (Exception ex)
                {
                    MostrarError(ex);
                }
            }
        }


        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    lastFilePath = filePath;

                    // Guardar el contenido del RichTextBox en el archivo seleccionado
                    File.WriteAllText(filePath, richTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MostrarError(ex);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastFilePath))
            {
                // Si no hay un último archivo guardado, se comporta como "Guardar como..."
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                try
                {
                    // Guardar el contenido del RichTextBox en el último archivo guardado
                    File.WriteAllText(lastFilePath, richTextBox1.Text);
                }
                catch (Exception ex)
                {
                    MostrarError(ex);
                }
            }
        }

        private void MostrarError(Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}