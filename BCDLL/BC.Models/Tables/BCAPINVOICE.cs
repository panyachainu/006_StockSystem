namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCAPINVOICE")]
    public partial class BCAPINVOICE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        public DateTime DocDate { get; set; }

        public short? TaxType { get; set; }

        [Required]
        [StringLength(20)]
        public string ApCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        public short? CreditDay { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? StatementDate { get; set; }

        public short? StatementState { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        public short? BillType { get; set; }

        [StringLength(20)]
        public string BillGroup { get; set; }

        [StringLength(10)]
        public string ContactCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfItemAmount { get; set; }

        [StringLength(35)]
        public string DiscountWord { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? AfterDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? BeforeTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public short? DiscountCase { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExceptTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZeroTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PettyCashAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumCashAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumChqAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumBankAmount { get; set; }

        public short? DepositIncTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfDeposit1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfDeposit2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfWTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetDebtAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherIncome { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherExpense { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillBalance { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(5)]
        public string GLFormat { get; set; }

        public short? GLStartPosting { get; set; }

        public short? GRBillStatus { get; set; }

        public short? GRIRBillStatus { get; set; }

        public short? IsPostGL { get; set; }

        public short? IsCancel { get; set; }

        public short? IsCreditNote { get; set; }

        public short? IsDebitNote { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        public short? GLTransData { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(40)]
        public string RecurName { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeProfit { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        [StringLength(30)]
        public string Remark1 { get; set; }

        [StringLength(30)]
        public string Remark2 { get; set; }

        [StringLength(30)]
        public string Remark3 { get; set; }

        [StringLength(30)]
        public string Remark4 { get; set; }

        [StringLength(30)]
        public string Remark5 { get; set; }

        [StringLength(20)]
        public string OwnerTransport { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayBillAmount { get; set; }

        [StringLength(255)]
        public string RefDocNo { get; set; }

        public short? IsImport { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfWTaxCash { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumBaseWTaxCash { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumComWTaxCash { get; set; }

        [StringLength(20)]
        public string APInvoiceNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgTaxAmount { get; set; }

        public short? PrePayStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrePayAmount { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string wtaxrate { get; set; }

        [Column(TypeName = "money")]
        public decimal? sumofwtax_forshow { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }
    }
}
