namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCARINVOICESUB")]
    public partial class BCARINVOICESUB
    {
        [Key]
        public int ROWORDER { get; set; }

        public short? BehindIndex { get; set; }

        public short? MyType { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        public short? TaxType { get; set; }

        [StringLength(25)]
        public string ItemCode { get; set; }

        public DateTime? DocDate { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        [StringLength(10)]
        public string WHCode { get; set; }

        [StringLength(15)]
        public string ShelfCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? CNQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(35)]
        public string DiscountWord { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? BalanceAmount { get; set; }

        [StringLength(10)]
        public string UnitCode { get; set; }

        [StringLength(10)]
        public string OppositeUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositeQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositePrice2 { get; set; }

        [StringLength(20)]
        public string SORefNo { get; set; }

        [StringLength(20)]
        public string PORefNo { get; set; }

        public short? StockType { get; set; }

        public short? ExceptTax { get; set; }

        public short? LineNumber { get; set; }

        public short? RefLineNumber { get; set; }

        public short? TransState { get; set; }

        public short? IsCancel { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [StringLength(20)]
        public string BarCode { get; set; }

        [StringLength(10)]
        public string CustTypeCode { get; set; }

        [StringLength(10)]
        public string CustGroupCode { get; set; }

        [StringLength(10)]
        public string SaleAreaCode { get; set; }

        [StringLength(10)]
        public string CategoryCode { get; set; }

        [StringLength(10)]
        public string GroupCode { get; set; }

        [StringLength(10)]
        public string BrandCode { get; set; }

        [StringLength(10)]
        public string TypeCode { get; set; }

        [StringLength(10)]
        public string FormatCode { get; set; }

        [StringLength(10)]
        public string MACHINENO { get; set; }

        [StringLength(30)]
        public string MACHINECODE { get; set; }

        [StringLength(15)]
        public string BILLTIME { get; set; }

        [StringLength(10)]
        public string CASHIERCODE { get; set; }

        [StringLength(10)]
        public string SHIFTCODE { get; set; }

        public short? POSSTATUS { get; set; }

        public short? PRICESTATUS { get; set; }

        public short? PROMOSTATUS { get; set; }

        [Column(TypeName = "money")]
        public decimal? OLDPRICE { get; set; }

        [StringLength(10)]
        public string USERCODE { get; set; }

        public short? USERMODIFY { get; set; }

        public short? POSCREDIT { get; set; }

        public short? PremiumStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixUnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixUnitQty { get; set; }

        public short? IsConditionSend { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransportAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? AVERAGECOST { get; set; }

        [StringLength(50)]
        public string LotNumber { get; set; }

        [StringLength(10)]
        public string Colorcode { get; set; }

        [StringLength(10)]
        public string SizeCode { get; set; }

        [StringLength(10)]
        public string StyleCode { get; set; }

        [StringLength(25)]
        public string itemsetcode { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TaxRate { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate1 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate2 { get; set; }

        public short? RefType { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        [StringLength(10)]
        public string PriceCode { get; set; }

        [StringLength(10)]
        public string InvoiceType { get; set; }

        public short? IsProcess { get; set; }

        public short? IsLockCost { get; set; }

        [StringLength(20)]
        public string DORefNo { get; set; }

        public short? DeliveryStatus { get; set; }

        [StringLength(255)]
        public string ItemNameDesc { get; set; }

        [StringLength(20)]
        public string promotioncode { get; set; }

        [StringLength(25)]
        public string masteritemcode { get; set; }

        [Column(TypeName = "money")]
        public decimal? BTDisc { get; set; }

        public short? DiscCashCard { get; set; }

        [Column(TypeName = "money")]
        public decimal? WTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaseWTax { get; set; }

        public short? IsPackingList { get; set; }

        [Column(TypeName = "money")]
        public decimal? Netweight { get; set; }

        [Column(TypeName = "money")]
        public decimal? GrossWeight { get; set; }

        [StringLength(255)]
        public string Measurement { get; set; }

        [Column(TypeName = "money")]
        public decimal? MeasureWide { get; set; }

        [Column(TypeName = "money")]
        public decimal? MeasureLong { get; set; }

        [Column(TypeName = "money")]
        public decimal? MeasureHigh { get; set; }

        [StringLength(10)]
        public string BranchCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? FactorPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFCOST2 { get; set; }

        [StringLength(10)]
        public string RECEIVEITEMTYPE { get; set; }

        [Column(TypeName = "money")]
        public decimal? RETAILPRICE { get; set; }

        [Column(TypeName = "money")]
        public decimal? RETAILAMOUNT { get; set; }

        public short? INSURANCEDAY { get; set; }

        public DateTime? INSURANCEDATE { get; set; }
    }
}
