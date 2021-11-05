using Mall.IRepository;
using Mall.Models;
using Mall.Models.EntityModels;
using Mall.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Repository
{
    public class PmsProductCategoryRepository : BaseRepository<PmsProductCategory>, IPmsProductCategoryRepository
    {
        public PmsProductCategoryRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
    }
}
