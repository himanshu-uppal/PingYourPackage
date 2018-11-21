using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Entities
{
    public class Role
    {
        [Key]
        public Guid Key { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }
    }
}
