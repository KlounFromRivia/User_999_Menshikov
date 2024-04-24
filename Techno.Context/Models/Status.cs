using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Techno.Context.Models
{
    public class Status
    {
        [Key]
        public int IdStatus { get; set; }
        [Required]
        public string StatusTitle { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}