using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Programacao_Wipro.Data;
using Teste_Programacao_Wipro.Model;

namespace Teste_Programacao_Wipro.Repositories
{
    public interface ILocacaoRepository
    {
        void Add(Locacao entity);
        IEnumerable<Locacao> GetLocacao();
        Locacao Getlocacao(string IdLocacao);
        bool LocacaoDisponivel(Locacao entity);
        void Update(Locacao entity);
    }

    public class LocacaoRepository : ILocacaoRepository
    {
        public void Add(Locacao entity)
        {
            Context.locacoes.Add(entity);
        }

        public IEnumerable<Locacao> GetLocacao()
        {
            return Context.locacoes;
        }

        public Locacao Getlocacao(string IdLocacao)
        {
            var LocacaoUnica = Context.locacoes.Where(x => x.idLocacao == IdLocacao).FirstOrDefault();
            return LocacaoUnica;
        }

        public void Update(Locacao entity)
        {
            var locacao = Getlocacao(entity.idLocacao);
            locacao.DataDevolucao = entity.DataDevolucao;
        }

        public bool LocacaoDisponivel(Locacao entity)
        {
            var disponivel = Context.locacoes.Where( x => x.IdFilme == entity.IdFilme && x.DataDevolucao != default(DateTime));
            return disponivel.Count() == 0 || disponivel.Any();
        }


    }
}
