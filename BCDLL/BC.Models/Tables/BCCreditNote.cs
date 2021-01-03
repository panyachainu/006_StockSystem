namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCCreditNote")]
    public partial class BCCreditNote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        public DateTime? TaxDate { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        public DateTime? DocDate { get; set; }

        public DateTime? DueDate { get; set; }

        public short? TaxType { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(10)]
        public string CashierCode { get; set; }

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
        public decimal? SumOfZeroTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfExceptTax { get; set; }

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

        public short? DebtLimitState { get; set; }

        public short? IsPostGL { get; set; }

        public short? IsCancel { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        public short? GLTransData { get; set; }

        public short? ReturnMoney { get; set; }

        public short? ReturnStatus { get; set; }

        public short? ReturnCash { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherIncome { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherExpense { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumCashAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumChqAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumCreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumBankAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChargeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChangeAmount { get; set; }

        public short? CauseType { get; set; }

        public short? PayBillStatus { get; set; }

        public short? IsCNDeposit { get; set; }

        public short? IsPos { get; set; }

        [StringLength(20)]
        public string PosDocNo { get; set; }

        [StringLength(10)]
        public string CauseCode { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(10)]
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

        [StringLength(10)]
        public string CustGroupCode { get; set; }

        public short? IsImport { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillTemporary { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        [StringLength(10)]
        public string InvoiceType { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyAmount { get; set; }

        public short? QtyDefault { get; set; }

        public short? QtyCopy { get; set; }

        public short? MergeItem { get; set; }

        public short? Newline { get; set; }

        public short? PriceCopy { get; set; }

        public short? WHCopy { get; set; }

        public short? CalcTaxFlag { get; set; }

        [StringLength(10)]
        public string MethodePaybill { get; set; }

        [StringLength(255)]
        public string MethodePaybill2 { get; set; }

        [StringLength(10)]
        public string SaleAreaCode { get; set; }

        [StringLength(100)]
        public string SHORTNAME { get; set; }

        public short? ISGIFT { get; set; }

        public short? PROMOMEMBER { get; set; }

        public short? PROMOTYPE { get; set; }

        [StringLength(10)]
        public string BranchCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? PETTYCASHAMOUNT { get; set; }

        [StringLength(10)]
        public string COUPONCODE { get; set; }

        [Column(TypeName = "money")]
        public decimal? COUPONAMOUNT { get; set; }

        public short? POSSTATUS { get; set; }

        [StringLength(255)]
        public string ARNAME { get; set; }

        [StringLength(255)]
        public string ARADDRESS { get; set; }
    }
}
