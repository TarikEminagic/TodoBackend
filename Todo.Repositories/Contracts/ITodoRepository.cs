using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Repositories.Contracts
{
    public interface ITodoRepository: IRepository<Db.Models.Todo, int>
    {
    }
}
