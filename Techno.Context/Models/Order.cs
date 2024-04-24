using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Techno.Context.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        [Required]
        public DateTime CreateOrder {  get; set; }
        public DateTime? CompleteOrder { get; set; }
        [Required]
        public string ModelEquipment { get; set; }
        [Required]
        public string DescriptionDefect { get; set; }
        public int TypeEquipmentId { get; set; }
        [ForeignKey("TypeEquipmentId")]
        public TypeEquipment TypeEquipment { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public User Client { get; set; }
        public int? MasterId { get; set; }
        [ForeignKey("MasterId")]
        public User Master { get; set; }
        public string Zapchasty { get; set; } = string.Empty;

        public ICollection<Comment>Comments { get; set; }
    }
}