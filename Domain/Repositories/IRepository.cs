using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> FindById(int id);
        Task<T> Create(T t);
        Task Update(T t);
        Task Delete(int id);
        Task<IEnumerable<T>> GetAll(Predicate<T> pre);

    }
}
