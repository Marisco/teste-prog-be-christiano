using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Aplicacao.Servicos
{
    public class BaseServicoAplicacao<TEntity> : IDisposable, IBaseServicoAplicacao<TEntity> where TEntity : class
    {
        private readonly IBaseServico<TEntity> baseServico;
        
        public BaseServicoAplicacao(IBaseServico<TEntity> baseServico)
        {
            this.baseServico = baseServico;

        }
        
        public void Add(TEntity obj)
        {
            baseServico.Add(obj);
        }
        

        public IEnumerable<TEntity> GetAll()
        {
            return baseServico.GetAll();
        }

        public TEntity GetById(int id)
        {
            return baseServico.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            baseServico.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            baseServico.Update(obj);
        }
        public void Dispose()
        {
            baseServico.Dispose();
        }
    }
}
