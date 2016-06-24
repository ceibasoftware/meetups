namespace WebApi.Models
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}