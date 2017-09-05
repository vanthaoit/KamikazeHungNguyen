﻿using KamikazeHungNguyen.Data.Infrastructure;
using KamikazeHungNguyen.Model.Models;

namespace KamikazeHungNguyen.Data.Repositories
{
    public interface IPermissionRepository : IRepository<Permission>
    {
    }

    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}