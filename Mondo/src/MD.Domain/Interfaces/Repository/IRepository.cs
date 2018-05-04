using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MD.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity pObjeto);
        TEntity ObterPorID(Guid pID);
        IEnumerable<TEntity> ObterTodos();
        TEntity Atualizar(TEntity pObjeto);
        void Remover(Guid pID);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
