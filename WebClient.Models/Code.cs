using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class Code
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}