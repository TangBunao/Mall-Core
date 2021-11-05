using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.IServices.Base
{
    public interface IBaseService<T> where T : class
    {

        Task<T> FindById(object Id);

        Task<List<T>> FindAll();

        Task<int> Create(T entity);

    }
}
