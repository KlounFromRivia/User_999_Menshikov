using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno.Context.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string UserFIO { get; set; }
        [Required]
        public string UserPhone { get; set; }
        [Required]
        public string UserLogin { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public ICollection<Order> OrderClient { get; set; }
        public ICollection<Order> OrderMaster { get; set; }
    }
}
