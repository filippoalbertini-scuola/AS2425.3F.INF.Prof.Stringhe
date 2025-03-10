namespace AS2425._3F.INF.Prof.Stringhe
{
    public partial class Form1 : Form
    {
        // struttura dati
        const int N_MAX_CONTATTI = 100;
        string[] nomiCognomi = new string[N_MAX_CONTATTI];
        string[] email = new string[N_MAX_CONTATTI];

        int nContatti = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (nContatti >= N_MAX_CONTATTI)
            {
                MessageBox.Show("Numero massimo di contatti raggiunto");
                return;
            }

            nomiCognomi[nContatti] = txtNomeCognome.Text;
            email[nContatti] = txtEmail.Text;

            nContatti++;
        }
    }
}
