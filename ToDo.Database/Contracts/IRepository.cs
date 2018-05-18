using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo.Database.Contracts
{
    interface IRepository<T, Tkey>
    {
        Task<T> Get(Tkey id);
        Task<ICollection<T>> GetAll();
        Task<T> Create(T data);
        Task<T> Update(T data);
        Task<bool> Delete(T data);
        Task<bool> Delete(Tkey id);
    }
}
