using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_PURCHASE_REQUISITION_LINE_ITEM, Schema = SD.DEFAULT_SCHEMA)]
    public class PurchaseRequisitionLineItem
    {
        [Key, Column(Order = 0)]
        [ForeignKey("PurchaseRequisition")]
        public int PurchaseRequisitionId { get; set; }
        public PurchaseRequisition PurchaseRequisition { get; set; }

        [Key, Column(Order = 1)]
        public int LineNumber { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public decimal Quantity { get; set; }

        [ForeignKey("UnitOfMeasurement")]
        public int UnitOfMeasurementId { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}