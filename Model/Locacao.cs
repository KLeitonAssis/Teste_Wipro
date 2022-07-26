using System;

namespace Teste_Programacao_Wipro.Model
{
    public class Locacao
    {
        public string idLocacao { get; set; } = Guid.NewGuid().ToString();
        public DateTime DataLocacao { get; set; }
        public DateTime DataEsperadaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string IdFilme { get; set; }
        public string IdCliente { get; set; }
    }
}