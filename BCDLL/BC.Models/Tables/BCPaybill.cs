namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCPaybill")]
    public partial class BCPaybill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        public DateTime? DocDate { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfInvoice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfDebitNote { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfCreditNote { get; set; }

        [Column(TypeName = "money")]
        public decimal? BeforeTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(20)]
        public string BillGroup { get; set; }

        public short? CreditDay { get; set; }

        public short? BillStatus { get; set; }

        public DateTime? DueDate { get; set; }

        public short? PayServiceOnly { get; set; }

        public short? PrintItemOfBill { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(40)]
        public string RecurName { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public short? IsPrintAuto { get; set; }

        public DateTime? CancelDateTime { get; set; }

        public short? PrintCount { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillTemporary { get; set; }

        [StringLength(255)]
        public string DiscountWord { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? WithHoldTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        public short? Iscancel { get; set; }

        [StringLength(25)]
        public string BillsDiscount { get; set; }
    }
}
