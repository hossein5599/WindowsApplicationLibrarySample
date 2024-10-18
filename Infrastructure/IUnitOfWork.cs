using System.Threading.Tasks;
using WindowsAppLibrarySample.Infrastructure.Repositories;

namespace WindowsAppLibrarySample.Infrastructure
{
    public interface IUnitOfWork
    {
        void Dispose();
        IRepositoryBase<T> Repository<T>() where T : class;
        void Save();
        Task SaveAsync();
    }
}