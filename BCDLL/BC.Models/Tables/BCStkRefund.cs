namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCStkRefund")]
    public partial class BCStkRefund
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        public DateTime? DocDate { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        public DateTime? DueDate { get; set; }

        public short? TaxType { get; set; }

        [StringLength(20)]
        public string ApCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfItemAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOldAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumTrueAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumofDiffAmount { get; set; }

        [StringLength(30)]
        public string DiscountWord { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumofBeforeTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfTotalTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfExceptTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfZeroTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfWTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetDebtAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumExchangeProfit { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillBalance { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(5)]
        public string GLFormat { get; set; }

        public short? GLStartPosting { get; set; }

        public short? IsPostGL { get; set; }

        public short? IsCancel { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        public short? GLTransData { get; set; }

        public short? ReturnMoney { get; set; }

        public short? ReturnStatus { get; set; }

        public short? StatementState { get; set; }

        public short? BillType { get; set; }

        public short? CauseType { get; set; }

        [StringLength(10)]
        public string CauseCode { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(20)]
        public string BillGroup { get; set; }

        [StringLength(40)]
        public string RecurName { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayBillAmount { get; set; }

        public short? IsImport { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        public short? IsCNDeposit { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgTaxAmount { get; set; }

        public short? PrePayStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrePayAmount { get; set; }
    }
}
