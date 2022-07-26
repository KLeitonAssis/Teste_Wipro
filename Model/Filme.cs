using System;

namespace Teste_Programacao_Wipro.Model
{
    public class Filme
    {
        public string IdFilme { get; set; } = Guid.NewGuid().ToString();
        public string Titulo { get; set; }
        public bool ativo { get; set; }
    }
}