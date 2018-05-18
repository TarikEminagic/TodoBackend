using System.Threading.Tasks;

namespace Todo.Repositories.Contracts
{
    public interface IRepository<T, Tkey>
    {
        Task<T> GetAsync(Tkey id);
    }
}
