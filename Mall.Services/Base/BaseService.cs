using Mall.IServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        

        public Task<int> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> FindById(object Id)
        {
            throw new NotImplementedException();
        }
    }
}
