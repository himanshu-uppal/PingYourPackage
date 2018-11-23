﻿using PingYourPackage.Domain.Abstract;
using PingYourPackage.Domain.Entities;
using PingYourPackage.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Extensions
{
    public static class RoleRepositoryExtensions
    {
        public static Role GetSingleByRoleName(this IEntityRepository<Role> roleRepository, string roleName)
        {
            return roleRepository.GetAll().FirstOrDefault(x => x.Name == roleName);
        }
    }
}
