using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Data;
using Teste_Programacao_Wipro.Model;

namespace Teste_Programacao_Wipro.Repositories
{
    public interface IFilmeRepository
    {
        void Add(Filme entity);
        IEnumerable<Filme> GetFilme();
        Filme GetFilme(string IdFilme);
        bool Delete(string Titulo);
    }

    public class FilmeRepository : IFilmeRepository
    {
        public void Add(Filme entity)
        {
            Context.Filmes.Add(entity);
        }

        public IEnumerable<Filme> GetFilme()
        {
            return Context.Filmes;
        }

        public Filme GetFilme(string Titulo)
        {
            var FilmeUnico = Context.Filmes.Where(x => x.Titulo == Titulo).FirstOrDefault();
            return FilmeUnico;
        }

        public bool Delete(string Titulo)
        {
            var Desativacao = GetFilme(Titulo);
             Desativacao.ativo = false;
            return Desativacao.ativo;
        }
    }
}
