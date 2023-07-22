using Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AppAerolinea
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private List<Usuario> usuarios;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("C:\\Users\\crist\\OneDrive\\Escritorio\\MOCK_DATA.json"); // Ruta al archivo JSON de usuarios
                usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                // Verificar el correo y contraseña ingresados
                string correo = txtBoxCorreo.Text;
                string contraseña = txtBoxContraseña.Text;

                Usuario usuario = usuarios.Find(u => u.Correo == correo && u.Clave == contraseña);
                if (usuario != null)
                {
                    // Iniciar sesión exitosamente
                    // Realiza las acciones necesarias después de iniciar sesión
                    MessageBox.Show("Hola");
                }
                else
                {
                    MessageBox.Show("Chau");
                    // Mostrar mensaje de error de inicio de sesión inválido
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error de deserialización o lectura del archivo
            }
        }
    }
}