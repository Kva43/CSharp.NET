using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Forms_Ejercicio1
{
    public partial class FormSaludo : Form
    {
        public FormSaludo(string titulo, string mensaje)
        {
            InitializeComponent();

            labelSaludoWinForms.Text = titulo;
            labelSaludo.Text = mensaje;
        }
    }
}