using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBlog2025.Core.Domain.Content
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Slug { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }
    }
}
