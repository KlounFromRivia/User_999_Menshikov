using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Techno.Context.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        [Required]
        public string RoleTitle { get; set; }
        public ICollection<User> User { get; set; }
    }
}