using JogoDaVelha.Negocios.Interfaces.Repositorios;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Negocios.Servicos
{
    public class BaseServico<TEntity> : IDisposable, IBaseServico<TEntity> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> repositorio;

        public BaseServico(IBaseRepositorio<TEntity> repositorio)
        {
            this.repositorio = repositorio;

        }
        
        public void Add(TEntity obj)
        {
            repositorio.Add(obj);
        }
        

        public IEnumerable<TEntity> GetAll()
        {
            return repositorio.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repositorio.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repositorio.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repositorio.Update(obj);
        }
        public void Dispose()
        {
            repositorio.Dispose();
        }
    }
}
