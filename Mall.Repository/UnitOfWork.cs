using Mall.IRepository;
using Mall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _appDbContext;
        private IPmsProductCategoryRepository _pmsProductCategoryRepo;

        public IPmsProductCategoryRepository PmsProductCategoryRepo
        {
            get
            {
                if (_pmsProductCategoryRepo == null)
                {
                    _pmsProductCategoryRepo = new PmsProductCategoryRepository(_appDbContext);
                }
                return _pmsProductCategoryRepo;
            }
        }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task SaveAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
