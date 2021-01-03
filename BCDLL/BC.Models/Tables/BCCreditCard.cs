namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCCreditCard")]
    public partial class BCCreditCard
    {
        [Key]
        public int ROWORDER { get; set; }

        [StringLength(10)]
        public string BankCode { get; set; }

        [StringLength(20)]
        public string CreditCardNo { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

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

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(10)]
        public string CreditType { get; set; }

        [StringLength(20)]
        public string ConfirmNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChargeAmount { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditVatRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditVat { get; set; }

        public short? PrintCount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditSumVat { get; set; }

        public short? ISCANCEL { get; set; }

        public short? ISCONFIRM { get; set; }

        [StringLength(25)]
        public string POSDOCNO { get; set; }

        [StringLength(6)]
        public string EDCBATCHNO { get; set; }

        [StringLength(22)]
        public string EDCCARDHOLDER { get; set; }

        [StringLength(4)]
        public string EDCCARDEXPR { get; set; }

        [StringLength(8)]
        public string EDCTID { get; set; }

        [StringLength(6)]
        public string EDCSYSTEMTRC { get; set; }

        [StringLength(4)]
        public string EDCNII { get; set; }

        [Column(TypeName = "money")]
        public decimal? EDCNETAMOUNT { get; set; }

        public short? ISMANUALKEY { get; set; }
    }
}
