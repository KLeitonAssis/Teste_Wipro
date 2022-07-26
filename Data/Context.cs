using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Model;

namespace Teste_Programacao_Wipro.Data
{
    public class Context
    {
        public static List<Cliente> Clientes = new List<Cliente> { 
                new Model.Cliente {
                Id = "1",
                Nome = "Kleiton",
                Cpf = "10434537686",
                ativo = true},
               
                new Model.Cliente {
                Id = "2",
                Nome = "João",
                Cpf = "24255678597",
                ativo = true},

                new Model.Cliente {
                Id = "3",
                Nome = "Paulo",
                Cpf = "30966425194",
                ativo = true},

                new Model.Cliente {
                Id = "4",
                Nome = "Rosi",
                Cpf = "44532654394",
                ativo = true},

                new Model.Cliente {
                Id = "5",
                Nome = "Kethelen",
                Cpf = "50490977688",
                ativo = true},

                new Model.Cliente {
                Id = "6",
                Nome = "Victor",
                Cpf = "64214355632",
                ativo = true},

                new Model.Cliente {
                Id = "7",
                Nome = "Maria",
                Cpf = "78734523221",
                ativo = true}
        };


        public static List<Filme> Filmes = new List<Filme> { 
                new Model.Filme {
                IdFilme = "1",
                Titulo = "Dr. Estranho",
                ativo = true},

               new Model.Filme {
                IdFilme = "2",
                Titulo = "Vingadores",
                ativo = true},

               new Model.Filme {
                IdFilme = "3",
                Titulo = "Um espião e meio",
                ativo = true},

               new Model.Filme {
                IdFilme = "4",
                Titulo = "Top Gun",
                ativo = true},

               new Model.Filme {
                IdFilme = "5",
                Titulo = "Homem Aranha",
                ativo = true}
        };

        public static List<Locacao> locacoes = new List<Locacao> { 
                new Model.Locacao {
                idLocacao = "1",
                DataLocacao = DateTime.Today,
                DataEsperadaDevolucao = new DateTime(2022,07,26),
                DataDevolucao = new DateTime(2022,07,26),
                IdFilme = "1",
                IdCliente = "1"
                },

                new Model.Locacao {
                idLocacao = "2",
                DataLocacao = DateTime.Today,
                DataEsperadaDevolucao = new DateTime(2022,07,26),
                DataDevolucao = new DateTime(2022,07,26),
                IdFilme = "3",
                IdCliente = "5"
                },

                new Model.Locacao {
                idLocacao = "3",
                DataLocacao = DateTime.Today,
                DataEsperadaDevolucao = new DateTime(2022,07,26),
                DataDevolucao = new DateTime(2022,07,26),
                IdFilme = "5",
                IdCliente = "6"
                }
        };

        public static object Locacao { get; internal set; }
    }
}
