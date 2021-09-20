using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_PRODUCT, Schema = SD.DEFAULT_SCHEMA)]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Code")]
        public int CodeId { get; set; }
        public Code Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public decimal Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Rate { get; set; }
    }
}