using AppCadastroEventos.Models;

namespace AppCadastroEventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            lblNome.Text = evento.Nome;
            lblTipo.Text = $"Tipo: {evento.TipoEvento}";
            lblPeriodo.Text = $"Período: {evento.DataInicio:dd/MM/yyyy} até {evento.DataFim:dd/MM/yyyy}";
            lblDuracao.Text = $"Duração: {evento.DuracaoDias} dia(s)";
            lblParticipantes.Text = $"Nº de Convidados: {evento.NumeroParticipantes}";
            lblCustoPessoa.Text = $"Custo p/ Pessoa: {evento.CustoPorPessoa:C2}";
            lblCustoTotal.Text = $"Custo Total: {evento.CustoTotal:C2}";
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
