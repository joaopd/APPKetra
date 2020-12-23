using AppKetra.Dto.DtoPedido.Interfaces;
using AppKetraInfraData.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace AppKetra.InfraData.Repository
{
    public class EFRepository<TEntity> : IPedido<TEntity> where TEntity : class
    {
        protected readonly AppKetraContexto _dbContext;

        public EFRepository(AppKetraContexto dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();          
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public TEntity ObterPorID(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();           
        }
    }
}
