namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCInvCreditNote")]
    public partial class BCInvCreditNote
    {
        [Key]
        public int ROWORDER { get; set; }

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

        [StringLength(20)]
        public string CreditNoteNo { get; set; }

        public short? ReturnMoney { get; set; }

        public short? ReturnStatus { get; set; }

        [StringLength(20)]
        public string InvoiceNo { get; set; }

        [StringLength(40)]
        public string InvoiceDisc { get; set; }

        public decimal? InvExchangeRate { get; set; }

        public decimal? NewExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? OldAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfItemAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiffAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZeroTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExceptTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TrueAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeProfit { get; set; }

        public short? TransState { get; set; }

        public short? IsCancel { get; set; }

        public short? BillType { get; set; }

        [StringLength(10)]
        public string Custgroupcode { get; set; }

        [StringLength(255)]
        public string InvoiceMyDesc { get; set; }
    }
}
