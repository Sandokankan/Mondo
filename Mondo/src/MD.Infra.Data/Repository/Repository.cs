using MD.Domain.Interfaces.Repository;
using MD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MD.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected MondoContext DB;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            DB = new MondoContext();
            DbSet = DB.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity pObjeto)
        {
            var objAdd = DbSet.Add(pObjeto);
            SaveChanges();
            return objAdd;
        }

        public virtual TEntity Atualizar(TEntity pObjeto)
        {
            var obEntrada = DB.Entry(pObjeto);
            DbSet.Attach(pObjeto);
            obEntrada.State = EntityState.Modified;
            SaveChanges();

            return pObjeto;
        }

        public virtual void Remover(Guid pID)
        {
            DbSet.Remove(DbSet.Find(pID));
            SaveChanges();
        }
        
        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterPaginado(int pinNumRegistros, int pinNumPulados)
        {
            return DbSet.Skip(pinNumPulados).Take(pinNumRegistros).ToList();
        }

        public virtual TEntity ObterPorID(Guid pID)
        {
            return DbSet.Find(pID);
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> pPredicate)
        {
            return DbSet.Where(pPredicate);
        }

        public void Dispose()
        {
            DB.Dispose();
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            return DB.SaveChanges();
        }
    }
}
