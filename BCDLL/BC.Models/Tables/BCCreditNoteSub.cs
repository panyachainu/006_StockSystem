namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCCreditNoteSub")]
    public partial class BCCreditNoteSub
    {
        [Key]
        public int ROWORDER { get; set; }

        public short? BehindIndex { get; set; }

        public short? MyType { get; set; }

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

        [StringLength(10)]
        public string CashierCode { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        [StringLength(10)]
        public string WHCode { get; set; }

        [StringLength(15)]
        public string ShelfCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TempQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(30)]
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

        [StringLength(10)]
        public string UnitCode { get; set; }

        [StringLength(10)]
        public string OppositeUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositeQty { get; set; }

        [StringLength(20)]
        public string InvoiceNo { get; set; }

        public short? ItemType { get; set; }

        public short? ExceptTax { get; set; }

        public short? IsPos { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

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

        public decimal? ExchangeRate { get; set; }

        public short? TransState { get; set; }

        public short? IsCancel { get; set; }

        public short? StockProcess { get; set; }

        public short? LineNumber { get; set; }

        public short? RefLineNumber { get; set; }

        [StringLength(20)]
        public string BarCode { get; set; }

        [StringLength(10)]
        public string ReturnCode { get; set; }

        [StringLength(30)]
        public string Salediscword { get; set; }

        [Column(TypeName = "money")]
        public decimal? Salediscamount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Oldamount { get; set; }

        public short? IsPromotion { get; set; }

        public short? PremiumStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixUnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixUnitQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AVERAGECOST { get; set; }

        [StringLength(50)]
        public string LotNumber { get; set; }

        public DateTime? LotExpireDate { get; set; }

        [StringLength(255)]
        public string LotMyDesc { get; set; }

        [StringLength(10)]
        public string Colorcode { get; set; }

        [StringLength(10)]
        public string SizeCode { get; set; }

        [StringLength(10)]
        public string StyleCode { get; set; }

        public short? CauseType { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TaxRate { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate1 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate2 { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        [StringLength(10)]
        public string Custgroupcode { get; set; }

        [StringLength(10)]
        public string PriceCode { get; set; }

        [StringLength(10)]
        public string InvoiceType { get; set; }

        public short? IsProcess { get; set; }

        public short? IsLockCost { get; set; }

        [StringLength(10)]
        public string BranchCode { get; set; }

        [StringLength(25)]
        public string ItemSetCode { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [Column(TypeName = "money")]
        public decimal? CNCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFCOST2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? RETAILPRICE { get; set; }

        [Column(TypeName = "money")]
        public decimal? RETAILAMOUNT { get; set; }

        [Column(TypeName = "money")]
        public decimal? oldamount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? bals { get; set; }
    }
}
