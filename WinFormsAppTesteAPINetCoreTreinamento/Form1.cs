using System.Runtime.ConstrainedExecution;
using static System.Net.WebRequestMethods;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinFormsAppTesteAPINetCoreTreinamento
{
    public partial class FrmTesteJson : Form
    {
        private readonly HttpClient http = new HttpClient { BaseAddress = new Uri("https://localhost:7184/") };
        public FrmTesteJson()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Sair
            Close();
        }

        private async void BtnTeste_Click(object sender, EventArgs e)
        {
            try
            {
                // Testando o comando
                var ceps = await http.GetFromJsonAsync<List<Ceps>>("api/v1/Cep");

                // Exibir no DataGridView
                DgvListagem.DataSource = ceps;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
