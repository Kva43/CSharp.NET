namespace _06_Colecciones_Ejercicio3
{
    public partial class FrmContador : Form
    {
        private Dictionary<string, int> diccionario = new Dictionary<string, int>();
        private List<string> palabrasLista = new List<string>();

        public FrmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContadorPalabras(rtbContador.Text);
        }

        private void ContadorPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            palabrasLista.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach (string palabra in palabrasLista)
            {
                if (!diccionario.ContainsKey(palabra) && palabra != " ")
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] += 1;
                }
            }

        }
    }
}