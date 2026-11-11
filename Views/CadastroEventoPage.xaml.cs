using AppCadastroEventos.Models;

namespace AppCadastroEventos.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
            dtpInicio.MinimumDate = DateTime.Today;
            dtpFim.MinimumDate = DateTime.Today;
        }

        private async void OnCalcularClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || pckTipoEvento.SelectedIndex == -1)
            {
                await DisplayAlert("Atenção", "Preencha o nome e selecione o tipo do evento.", "OK");
                return;
            }

            if (!int.TryParse(txtParticipantes.Text, out int nParticipantes) || nParticipantes <= 0)
            {
                await DisplayAlert("Atenção", "Informe um número válido de participantes.", "OK");
                return;
            }

            if (!decimal.TryParse(txtCustoPessoa.Text, out decimal custoPessoa) || custoPessoa <= 0)
            {
                await DisplayAlert("Atenção", "Informe um valor válido por pessoa.", "OK");
                return;
            }

            var evento = new Evento
            {
                Nome = txtNome.Text,
                TipoEvento = pckTipoEvento.SelectedItem.ToString() ?? "Geral",
                NumeroParticipantes = nParticipantes,
                CustoPorPessoa = custoPessoa,
                DataInicio = dtpInicio.Date,
                DataFim = dtpFim.Date
            };

            await Navigation.PushAsync(new ResumoEventoPage(evento));
        }
    }
}
