using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Utility;

namespace WebClient.Models
{
    [Table(SD.TABLE_PURCHASE_REQUISITION, Schema = SD.DEFAULT_SCHEMA)]
    public class PurchaseRequisition
    {
        public PurchaseRequisition()
        {
            LineItems = new HashSet<PurchaseRequisitionLineItem>();
        }

        [Key]
        public int Id { get; set; }


        public string Number { get; set; }

        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RequiredBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        [ForeignKey("Creator")]
        public int CreatorId { get; set; }
        public ApplicationUser Creator { get; set; }

        public string Notes { get; set; }

        [ForeignKey("Approver")]
        public int ApproverId { get; set; }
        public ApplicationUser Approver { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalExclVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal GrandTotal { get; set; }

        public ICollection<PurchaseRequisitionLineItem> LineItems { get; set; }
    }
}
