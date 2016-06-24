namespace WebApi.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public abstract class Repository<TEntity>: IRepository<TEntity> where TEntity : Entity
    {
        private readonly IEFUnitOfWork unitOfWork;

        public Repository( IEFUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork
        {
            get { return this.unitOfWork; }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.unitOfWork.GetSet<TEntity>();
        }

        public TEntity GetById( int id )
        {
            return this.unitOfWork.GetSet<TEntity>().FirstOrDefault( entity => entity.Id == id );
        }

        public void Add( TEntity entity )
        {
            this.unitOfWork.GetSet<TEntity>().Add( entity );
        }
    }
}