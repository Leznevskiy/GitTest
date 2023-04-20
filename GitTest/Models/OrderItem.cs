using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GitTest.Models
{
    public class OrderItem
    {
        public int Id { get; set; } 
        public int OrderId { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "nvarchar(max)")]
        [Required]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Quantity { get; set; }
        [Required]
        public string? Unit { get; set; }

    }
}
