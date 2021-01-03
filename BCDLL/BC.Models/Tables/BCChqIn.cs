namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCChqIn")]
    public partial class BCChqIn
    {
        [Key]
        public int ROWORDER { get; set; }

        [StringLength(10)]
        public string BankCode { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(20)]
        public string ChqNumber { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(10)]
        public string ExtendStatus { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(30)]
        public string BookNo { get; set; }

        public short? Status { get; set; }

        public short? SaveFrom { get; set; }

        public DateTime? StatusDate { get; set; }

        [StringLength(20)]
        public string StatusDocNo { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(10)]
        public string BankBranchCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        public short? ChqUseStatus { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        [StringLength(10)]
        public string RECIVECHQBY { get; set; }

        public short? PrintCount { get; set; }

        public short? RECIVECONFIRM { get; set; }

        public short? ISCANCEL { get; set; }

        public short? ISCONFIRM { get; set; }

        public int? REFCHQROWORDER { get; set; }

        public short? ISMANUALKEY { get; set; }
    }
}
