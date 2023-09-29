using System.ComponentModel.DataAnnotations;

namespace Crito.Models.Entity
{
    public class NewsletterFormEntity
    {
        [Key]
        [Required]
        public string Email { get; set; } = null!;
    }
}
