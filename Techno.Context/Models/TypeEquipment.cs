using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Techno.Context.Models
{
    public class TypeEquipment
    {
        [Key]
        public int IdTypeEquipment { get; set; }
        [Required]
        public string TypeEquipmentTitle { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}