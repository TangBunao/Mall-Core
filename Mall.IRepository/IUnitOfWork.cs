using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.IRepository
{
    public interface IUnitOfWork
    {
        IPmsProductCategoryRepository PmsProductCategoryRepo { get; }

        Task SaveAsync();
    }
}
