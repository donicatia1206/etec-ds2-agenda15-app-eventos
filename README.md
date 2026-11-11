# etec-ds2-agenda15-app-eventos

App de Cadastro e Cálculo de Custos de Eventos em .NET MAUI — Agenda 15 (ETEC DS II).

## 📌 Sobre o Projeto
Aplicativo móvel desenvolvido em C# e XAML para a disciplina de Desenvolvimento de Sistemas II (ETEC). O sistema realiza a gestão e o cadastro de eventos, efetuando o cálculo automático da duração em dias e o custo total estimado com base no número de participantes.

## 🚀 Funcionalidades
- **Cadastro de Evento:** Solicita nome do evento, local, data de início, data de término, número de participantes e custo por participante.
- **Cálculo da Duração:** Utilização das estruturas `DateTime` e `TimeSpan` para calcular a diferença exata de dias entre o início e o término.
- **Cálculo de Custo Total:** Multiplicação do custo por participante pela quantidade de participantes e pela duração em dias.
- **Resumo do Evento:** Exibição dos dados formatados em uma nova página com a arquitetura `BindingContext`.

## 📁 Estrutura do Repositório
- `Models/Evento.cs`: Modelo de dados da aplicação com a regra de negócio e cálculos.
- `Views/CadastroEventoPage.xaml`: Tela de formulário de cadastro.
- `Views/ResumoEventoPage.xaml`: Tela de apresentação do resumo do evento.
- `App.xaml.cs`: Gerenciamento da navegação da aplicação.

## 👨‍💻 Autor
Desenvolvido por **Donizete dos Santos** — Curso Técnico em Desenvolvimento de Sistemas (ETEC).
