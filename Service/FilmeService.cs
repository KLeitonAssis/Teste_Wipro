using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Model;
using Teste_Programacao_Wipro.Repositories;

namespace Teste_Programacao_Wipro.Service
{
    public interface IFilmeService
    {
        void Add(Filme entity);
        IEnumerable<Filme> GetFilme();
        Filme GetFilme(string Titulo);
        bool Desativacao(string Titulo);
    }

    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository FilmeRepo;
        public FilmeService()
        {
            FilmeRepo = new FilmeRepository();
        }

        public void Add(Filme entity)
        {
            FilmeRepo.Add(entity);
        }

        public IEnumerable<Filme> GetFilme()
        {
            return FilmeRepo.GetFilme();
        }

        public Filme GetFilme(string Titulo)
        {
            return FilmeRepo.GetFilme(Titulo);
        }

        public bool Desativacao(string Titulo) 
        {
            return FilmeRepo.Delete(Titulo);
        }
    }
}
