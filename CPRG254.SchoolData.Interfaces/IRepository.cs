using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Interfaces
{
    public interface IRepository<T>
    {
        int Add(T item);
        int Update(T item);
        int Delete(T item);
        IList<T> Items { get; }
    }
}
