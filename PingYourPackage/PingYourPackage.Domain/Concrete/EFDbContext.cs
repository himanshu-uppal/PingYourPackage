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
        public IDbSet<ShipmentType> PackageTypes { get; set; }
        public IDbSet<Affiliate> Affiliates { get; set; }
        public IDbSet<Shipment> Shipments { get; set; }
        public IDbSet<ShipmentState> ShipmentStates { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<UserRole> UserRoles { get; set; }   

        }
    }

