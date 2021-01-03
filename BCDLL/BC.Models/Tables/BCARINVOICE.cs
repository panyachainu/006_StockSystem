namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCARINVOICE")]
    public partial class BCARINVOICE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        public DateTime DocDate { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        public short? TaxType { get; set; }

        [Required]
        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(20)]
        public string PassBillTo { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        public short? CreditDay { get; set; }

        public short? DeliveryDay { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? PayBillDate { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(10)]
        public string SaleAreaCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(255)]
        public string InvoiceMyDesc { get; set; }

        public short? BillType { get; set; }

        [StringLength(10)]
        public string BillGroup { get; set; }

        [StringLength(20)]
        public string RefDocNo { get; set; }

        [StringLength(20)]
        public string CrAuthorizeMan { get; set; }

        [StringLength(10)]
        public string DeliveryAddr { get; set; }

        [StringLength(10)]
        public string ContactCode { get; set; }

        [StringLength(10)]
        public string TransportCode { get; set; }

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
        public decimal? ZeroTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExceptTaxAmount { get; set; }

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

        public short? IsCancel { get; set; }

        public short? IsCreditNote { get; set; }

        public short? IsDebitNote { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        public short? IsPostGL { get; set; }

        public short? GLTransData { get; set; }

        public short? PayBillStatus { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(40)]
        public string RecurName { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeProfit { get; set; }

        [StringLength(10)]
        public string CustTypeCode { get; set; }

        [StringLength(10)]
        public string CustGroupCode { get; set; }

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

        public short? IsReceiveMoney { get; set; }

        public short? IsConditionSend { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTransport { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayBillAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? GrossWeight { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(255)]
        public string SORefNo { get; set; }

        [StringLength(255)]
        public string DORefNo { get; set; }

        public short? HoldingStatus { get; set; }

        [StringLength(10)]
        public string TimeTransport { get; set; }

        public short? IsImport { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        public short? RefType { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillTemporary { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        [Column(TypeName = "money")]
        public decimal? Netweight { get; set; }

        [Column(TypeName = "money")]
        public decimal? NumOfPallet { get; set; }

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

        [StringLength(20)]
        public string promotioncode { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfWTaxCash { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumBaseWTaxCash { get; set; }

        public short? IsPackingList { get; set; }

        [StringLength(255)]
        public string VesselOr { get; set; }

        public DateTime? ETADate { get; set; }

        public DateTime? ETDDate { get; set; }

        [StringLength(255)]
        public string FromVia { get; set; }

        [StringLength(255)]
        public string ToVia { get; set; }

        [StringLength(255)]
        public string MarkAndNos { get; set; }

        [StringLength(255)]
        public string DeliverTo { get; set; }

        [StringLength(255)]
        public string CountryOrigin { get; set; }

        [StringLength(255)]
        public string PayDateRemark { get; set; }

        [StringLength(30)]
        public string BookNo { get; set; }

        [StringLength(255)]
        public string OtherPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? InsuranceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FobAmount { get; set; }

        [StringLength(255)]
        public string MyDescPort { get; set; }

        [StringLength(20)]
        public string ProformaNo { get; set; }

        [StringLength(500)]
        public string IssuingBank { get; set; }

        [StringLength(50)]
        public string LCNo { get; set; }

        [StringLength(20)]
        public string LCDate { get; set; }

        [StringLength(10)]
        public string FormUnit { get; set; }

        [StringLength(1000)]
        public string FootNote { get; set; }

        public short? ISMULTITAXABB { get; set; }

        [StringLength(20)]
        public string TAXABBNO_1 { get; set; }

        [StringLength(20)]
        public string TAXABBNO_2 { get; set; }

        [StringLength(20)]
        public string TAXABBNO_3 { get; set; }

        [StringLength(20)]
        public string TAXABBNO_4 { get; set; }

        [StringLength(20)]
        public string TAXABBNO_5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? TAXABBAMOUNT1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? TAXABBAMOUNT2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? TAXABBAMOUNT3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? TAXABBAMOUNT4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? TAXABBAMOUNT5 { get; set; }

        [StringLength(10)]
        public string APPROVEDCODE { get; set; }

        public DateTime? APPROVEDDATE { get; set; }

        [StringLength(100)]
        public string CANCELDESC { get; set; }

        [StringLength(200)]
        public string ARNAME { get; set; }

        [StringLength(255)]
        public string ARADDRESS { get; set; }

        [StringLength(10)]
        public string CASHIERCODE { get; set; }

        [StringLength(10)]
        public string SHIFTCODE { get; set; }

        [StringLength(10)]
        public string MACHINENO { get; set; }

        [StringLength(30)]
        public string MACHINECODE { get; set; }

        public short? POSSTATUS { get; set; }

        [StringLength(15)]
        public string BILLTIME { get; set; }

        [StringLength(10)]
        public string CREDITTYPE { get; set; }

        [StringLength(40)]
        public string CREDITBRANCH { get; set; }

        public DateTime? CREDITDUEDATE { get; set; }

        [StringLength(20)]
        public string CREDITNO { get; set; }

        [StringLength(20)]
        public string COFIRMNO { get; set; }

        [StringLength(30)]
        public string CHARGEWORD { get; set; }

        [Column(TypeName = "money")]
        public decimal? CREDITBASEAMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? CREDITVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? CREDITSUMVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? GRANDTOTAL { get; set; }

        [Column(TypeName = "money")]
        public decimal? COUPONGAMOUNT { get; set; }

        [StringLength(100)]
        public string COUPONGDESC { get; set; }

        [Column(TypeName = "money")]
        public decimal? CHANGEAMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? OTHERAMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? OTHERFEE { get; set; }

        public short? SUMMARKCOUNT1 { get; set; }

        public short? SUMMARKCOUNT2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMMARKVALUE1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMMARKVALUE2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DIFFAMOUNT { get; set; }

        public short? ISREWARD { get; set; }

        public short? POSCREDIT { get; set; }

        [StringLength(10)]
        public string BranchCode { get; set; }

        [StringLength(50)]
        public string CUST_REFCOUPON { get; set; }

        [StringLength(50)]
        public string CUST_MOBILEPHONE { get; set; }

        [StringLength(50)]
        public string CUST_MEMBERCARD { get; set; }

        public short? CUST_SEX { get; set; }

        public short? CUST_AGE { get; set; }

        [StringLength(10)]
        public string RECEIVEITEMTYPE { get; set; }

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
    }
}
