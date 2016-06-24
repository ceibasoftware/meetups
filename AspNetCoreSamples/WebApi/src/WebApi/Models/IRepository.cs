namespace WebApi.Models
{
    using System.Collections.Generic;

    public interface IRepository<TEntity> where TEntity: Entity
    {
        IUnitOfWork UnitOfWork { get; }

        IEnumerable<TEntity> GetAll();

        TEntity GetById( int id );

        void Add( TEntity entity );
    }
}