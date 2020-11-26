using System;
using System.Collections.Generic;
using Entity;
using IRepository;

namespace Repository
{
    public class AdminService : IAdminService<AdminModel>
    {
        List<AdminModel> adminModels = new List<AdminModel>();

        public int Create(AdminModel Entity)
        {
            adminModels.Add(Entity);
            return adminModels.Count;
        }

        public IEnumerable<AdminModel> GetAll()
        {
            return adminModels;
        }
    }
}
