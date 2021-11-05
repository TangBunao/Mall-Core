﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.IRepository.Base
{
    public interface IBaseRepository<T>
    {
        void Create(T entity);
    }
}
