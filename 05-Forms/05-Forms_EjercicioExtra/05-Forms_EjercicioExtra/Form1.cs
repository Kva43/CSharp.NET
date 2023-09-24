namespace _05_Forms_EjercicioExtra
{
    public partial class FrmSaludo : Form
    {
        private bool labelVisible = false;

        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            lblSaludo.Visible = labelVisible;
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            labelVisible = !labelVisible;
            lblSaludo.Visible = labelVisible;

        }
    }
}