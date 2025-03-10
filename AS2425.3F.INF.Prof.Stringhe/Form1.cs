using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            // pulisci i campi di inserimento
            txtNomeCognome.Text = "";
            txtEmail.Text = "";
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            switch (cmbScelte.Text.ToUpper())
            {
                case "ELENCO CONTATTI":
                    lstElenco.Items.Clear();
                    for (int i = 0; i < nContatti; i++)
                    {
                        lstElenco.Items.Add($"Nome {nomiCognomi[i]} email {email[i]}");
                    }
                    break;

                case "ELENCO CONTATTI CONTENENTI IL NOME INDICATO":
                    lstElenco.Items.Clear();
                    for (int i = 0; i < nContatti; i++)
                    {
                        if (chkSearchCase.Checked == true)
                        {
                            if (nomiCognomi[i].ToUpper().Contains(txtParametro.Text.ToUpper()))
                                lstElenco.Items.Add($"Nome {nomiCognomi[i]} email {email[i]}");
                        }
                        else
                        {

                            if (nomiCognomi[i].Contains(txtParametro.Text))
                                lstElenco.Items.Add($"Nome {nomiCognomi[i]} email {email[i]}");
                        }
                    }
                    break;

                case "ELENCO CONTATTI CONTENENTI LA EMAIL INDICATA":
                    lstElenco.Items.Clear();
                    for (int i = 0; i < nContatti; i++)
                    {
                        if (chkSearchCase.Checked == true)
                        {
                            if (email[i].ToUpper().Contains(txtParametro.Text.ToUpper()))
                                lstElenco.Items.Add($"Nome {nomiCognomi[i]} email {email[i]}");
                        }
                        else
                        {

                            if (email[i].Contains(txtParametro.Text))
                                lstElenco.Items.Add($"Nome {nomiCognomi[i]} email {email[i]}");
                        }
                    }
                    break;
            }
        }
    }
}
