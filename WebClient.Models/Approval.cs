using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_APPROVAL, Schema = SD.DEFAULT_SCHEMA)]
    public class Approval
    {
        [Key, ForeignKey("PurchaseRequisition")]
        public int PurchaseRequisitionId { get; set; }
        public PurchaseRequisition PurchaseRequisition { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
