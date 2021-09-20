using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_UNIT_OF_MEASUREMENT, Schema = SD.DEFAULT_SCHEMA)]
    public class UnitOfMeasurement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}