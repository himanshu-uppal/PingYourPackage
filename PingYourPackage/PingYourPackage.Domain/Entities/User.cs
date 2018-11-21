using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingYourPackage.Domain.Abstract;

namespace PingYourPackage.Domain.Entities
{
    class User:IEntity
    {
        [Key]
        public Guid Key { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string HashedPassword { get; set; }
        [Required]
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public User()
        {
            UserRoles = new HashSet<UserRole>();

        }
    }
    
}
