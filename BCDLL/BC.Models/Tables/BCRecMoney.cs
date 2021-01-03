namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCRecMoney")]
    public partial class BCRecMoney
    {
        [Key]
        public int ROWORDER { get; set; }

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
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChqTotalAmount { get; set; }

        public short? PaymentType { get; set; }

        public short? SaveFrom { get; set; }

        public short? PayChqState { get; set; }

        [StringLength(10)]
        public string CreditType { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChargeAmount { get; set; }

        [StringLength(40)]
        public string ChargeWord { get; set; }

        [StringLength(30)]
        public string ConfirmNo { get; set; }

        public short? LineNumber { get; set; }

        [StringLength(30)]
        public string RefNo { get; set; }

        [StringLength(10)]
        public string BankCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(10)]
        public string SaleAreaCode { get; set; }

        [StringLength(10)]
        public string BankBranchCode { get; set; }

        public DateTime? TransBankDate { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        public DateTime? RefDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChangeAmount { get; set; }
    }
}
