namespace AppCadastroEventos.Models
{
    public class Evento
    {
        // 1. DADOS BASE DO EVENTO
        public string Nome { get; set; } = "Casamento Ouro";
        public string TipoEvento { get; set; } = "Buffet Gourmet";
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now.AddDays(1);
        public int NumeroParticipantes { get; set; } = 300;
        public decimal CustoPorPessoa { get; set; } = 148.00m; // Inclui prato principal + ilha oriental fusion

        // 2. CÁLCULOS DA ENGENHARIA DE INSUMOS DO CHEF (300 Pessoas)
        // Coquetel Volante (Massa Filo Lírio & Carpaccio)
        public decimal QtdCamaraoSeteBarbasKg => NumeroParticipantes * 0.04m; // 12 kg
        public decimal QtdMassaFiloKg => NumeroParticipantes * 0.02m;       // 6 kg

        // Prato Principal (Filet Mignon + Dueto Cogumelos + Gorgonzola)
        public decimal QtdFiletMignonKg => NumeroParticipantes * 0.25m;     // 75 kg
        public decimal QtdShitakeFrescoKg => NumeroParticipantes * 0.026m;  // 8 kg
        public decimal QtdFunghiSecchiKg => NumeroParticipantes * 0.010m;   // 3 kg
        public decimal QtdQueijoGorgonzolaKg => NumeroParticipantes * 0.04m; // 12 kg

        // 3. REGRAS DE NEGÓCIO DA ETEC + BUFFET
        public int DuracaoDias => (DataFim - DataInicio).Days > 0 ? (DataFim - DataInicio).Days : 1;
        
        // Custo Direto de Insumos e Mão de Obra
        public decimal CustoEquipeEMaoDeObra => 6200.00m; // Cozinha, Garçons, Barmen, Maître
        public decimal CustoLogisticaEGas => 1800.00m;

        // Custo Total Calculado
        public decimal CustoTotal => (NumeroParticipantes * CustoPorPessoa * DuracaoDias) + CustoEquipeEMaoDeObra + CustoLogisticaEGas;

        // Margem de Lucro Líquida do Chef (45%)
        public decimal LucroLiquidoChef => CustoTotal * 0.45m;
        public decimal ValorFinalOrcamento => CustoTotal + LucroLiquidoChef;
    }
}
