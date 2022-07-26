using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Model;
using Teste_Programacao_Wipro.Repositories;

namespace Teste_Programacao_Wipro.Service
{
    public interface ILocacaoService
    {
        void Add(Locacao entity);
        IEnumerable<Locacao> GetLocacao();
        Locacao Getlocacao(string IdLocacao);
        string DevolverFilme(Locacao entity);
    }

    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository locacaoRepo;


        public LocacaoService()
        {
            locacaoRepo = new LocacaoRepository();
        }

        public void Add(Locacao entity)
        {
            if (locacaoRepo.LocacaoDisponivel(entity) == true) 
            {
                locacaoRepo.Add(entity);
                return;
            }

            throw new Exception("Filme indisponivel");
        }

        public IEnumerable<Locacao> GetLocacao()
        {
            return locacaoRepo.GetLocacao();
        }

        public Locacao Getlocacao(string IdLocacao)
        {
            return locacaoRepo.Getlocacao(IdLocacao);
        }

        public string DevolverFilme(Locacao entity)
        {
            entity.DataDevolucao = DateTime.Now;
            locacaoRepo.Update(entity);

            if (entity.DataDevolucao > entity.DataEsperadaDevolucao) 
            {
                return "Devolução com atraso";
            }

            return string.Empty;
        }
    }
}
