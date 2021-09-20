using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_STATUS, Schema = SD.DEFAULT_SCHEMA)]
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}