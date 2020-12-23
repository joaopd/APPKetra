using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using static FluentValidation.Validators.PredicateValidator;

namespace AppKetra.Dto.DtoPedido.Interfaces
{
    public interface IPedido<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);

        void Atualizar(TEntity entity);

        IEnumerable<TEntity> ObterTodos();

        TEntity ObterPorID(int id);

        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>>predicado);

        void Remover(TEntity entity);
    }
}
