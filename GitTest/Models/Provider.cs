using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GitTest.Models
{
    public class Provider
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "nvarchar(max)")]
        [Required]
        public string? Name { get; set; }
        public Provider(int id, string name)
        {
            Id = id; Name = name;
        }
    }
}
