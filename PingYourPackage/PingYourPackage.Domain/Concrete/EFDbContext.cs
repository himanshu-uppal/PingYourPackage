using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingYourPackage.Domain.Entities;

namespace PingYourPackage.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("PingYourPackage")
        { }
           public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }   

        }
    }

