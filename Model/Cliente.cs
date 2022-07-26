using System;

namespace Teste_Programacao_Wipro.Model
{
    public class Cliente
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool ativo { get; set; }
    }
}