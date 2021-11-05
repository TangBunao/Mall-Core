using Mall.IRepository.Base;
using Mall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected AppDbContext _appDbContext;

        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(T entity)
        {
            _appDbContext.Add<T>(entity);
        }
    }
}
