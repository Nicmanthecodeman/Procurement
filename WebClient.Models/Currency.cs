using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_CURRENCY, Schema = SD.DEFAULT_SCHEMA)]
    public class Currency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
