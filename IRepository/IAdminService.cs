using System;
using System.Collections;
using System.Collections.Generic;

namespace IRepository
{
    public interface IAdminService<T>
    {
        int Create(T Entity);
        IEnumerable<T> GetAll();
    }
}
