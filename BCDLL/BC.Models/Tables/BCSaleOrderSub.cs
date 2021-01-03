namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCSaleOrderSub")]
    public partial class BCSaleOrderSub
    {
        [Key]
        public int ROWORDER { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

        public short? TaxType { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

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
        public decimal? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? DeliveryQty { get; set; }

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

        [StringLength(10)]
        public string UnitCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositePrice2 { get; set; }

        [StringLength(10)]
        public string OppositeUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositeQty { get; set; }

        [StringLength(20)]
        public string StkReserveNo { get; set; }

        public short? SOStatus { get; set; }

        public short? HoldingStatus { get; set; }

        public short? RefType { get; set; }

        public short? ItemType { get; set; }

        public short? ExceptTax { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public short? TransState { get; set; }

        public short? IsCancel { get; set; }

        public short? LineNumber { get; set; }

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

        [StringLength(20)]
        public string BarCode { get; set; }

        public short? IsPromotion { get; set; }

        public short? PremiumStatus { get; set; }

        public short? IsUseRobotSale { get; set; }

        public short? IsConditionSend { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransportAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? REMAINPAYQTY { get; set; }

        public short? ISPAYMENT { get; set; }

        [StringLength(10)]
        public string Colorcode { get; set; }

        [StringLength(10)]
        public string SizeCode { get; set; }

        [StringLength(10)]
        public string StyleCode { get; set; }

        [StringLength(25)]
        public string itemsetcode { get; set; }

        [StringLength(20)]
        public string PORefNo { get; set; }

        public short? BehindIndex { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TaxRate { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate1 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate2 { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        public short? IsProcess { get; set; }

        public short? IsLockCost { get; set; }

        [StringLength(20)]
        public string promotioncode { get; set; }

        [StringLength(25)]
        public string masteritemcode { get; set; }

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

        [Column(TypeName = "money")]
        public decimal? FactorPrice { get; set; }

        public short? REFLINENUMBER { get; set; }

        public short? POLINENUMBER { get; set; }

        [Column(TypeName = "money")]
        public decimal? POQTY { get; set; }

        [Column(TypeName = "money")]
        public decimal? RETAILPRICE { get; set; }

        [Column(TypeName = "money")]
        public decimal? RETAILAMOUNT { get; set; }
    }
}
