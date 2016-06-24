namespace WebApi.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public interface IEFUnitOfWork: IUnitOfWork
    {
        DbSet<TEntity> GetSet<TEntity>() where TEntity : Entity;
    }
}