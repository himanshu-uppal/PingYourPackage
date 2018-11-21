using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Entities
{
    public class UserRole
    {
        [Key]
        public Guid Key { get; set; }
        public Guid UserKey { get; set; }
        public Guid RoleKey { get; set; }

        public User user { get; set; }
        public Role role { get; set; }
    }
}
