using System.Threading.Tasks;

namespace Todo.Services.Contracts
{
    public interface IService<T, Tkey>
    {
        Task<T> GetAsync(Tkey id);
    }
}