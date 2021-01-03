namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCITEM")]
    public partial class BCITEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(25)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Name1 { get; set; }

        [StringLength(255)]
        public string Name2 { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(255)]
        public string ShortName { get; set; }

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

        [StringLength(255)]
        public string ColorCode { get; set; }

        [StringLength(40)]
        public string MyGrade { get; set; }

        [StringLength(255)]
        public string MyClass { get; set; }

        [StringLength(10)]
        public string GenericCode { get; set; }

        public short? UnitType { get; set; }

        [StringLength(10)]
        public string DefStkUnitCode { get; set; }

        [StringLength(10)]
        public string DefSaleUnitCode { get; set; }

        [StringLength(10)]
        public string DefBuyUnitCode { get; set; }

        [StringLength(10)]
        public string OppositeUnit { get; set; }

        [StringLength(10)]
        public string OppositeUnit2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Opposite1Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositeRate { get; set; }

        [StringLength(255)]
        public string MySize { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Wide { get; set; }

        [Column(TypeName = "money")]
        public decimal? Long { get; set; }

        [Column(TypeName = "money")]
        public decimal? High { get; set; }

        public DateTime? LastUpdate { get; set; }

        public short? StockType { get; set; }

        public short? StockProcess { get; set; }

        [StringLength(20)]
        public string VenderCode { get; set; }

        [StringLength(35)]
        public string DepositCondit { get; set; }

        [StringLength(35)]
        public string DeliveryCharge { get; set; }

        [StringLength(35)]
        public string InstallCharge { get; set; }

        [StringLength(255)]
        public string ReturnRemark { get; set; }

        public short? ReturnStatus { get; set; }

        [StringLength(30)]
        public string ReturnCharge { get; set; }

        [StringLength(10)]
        public string ItemStatus { get; set; }

        public short? NewItemStatus { get; set; }

        public short? RenovateStatus { get; set; }

        public short? ExceptTax { get; set; }

        public short? PromotionType { get; set; }

        [Column(TypeName = "money")]
        public decimal? WTaxRate { get; set; }

        [StringLength(50)]
        public string WaveFile { get; set; }

        public short? CostType { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderPoint { get; set; }

        [Column(TypeName = "money")]
        public decimal? StockMin { get; set; }

        [Column(TypeName = "money")]
        public decimal? StockMax { get; set; }

        [Column(TypeName = "money")]
        public decimal? StockQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AverageCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CostOfArea { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastBuyPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? StandardCost { get; set; }

        [StringLength(255)]
        public string PicFileName1 { get; set; }

        [StringLength(255)]
        public string PicFileName2 { get; set; }

        [StringLength(255)]
        public string PicFileName3 { get; set; }

        [StringLength(255)]
        public string PicFileName4 { get; set; }

        [StringLength(255)]
        public string SpecFileName { get; set; }

        [StringLength(255)]
        public string AviFileName { get; set; }

        [StringLength(10)]
        public string AccGroupCode { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(10)]
        public string DefBuyWHCode { get; set; }

        [StringLength(15)]
        public string DefBuyShelf { get; set; }

        [StringLength(10)]
        public string DefSaleWHCode { get; set; }

        [StringLength(15)]
        public string DefSaleShelf { get; set; }

        [StringLength(10)]
        public string DefBadWHCode { get; set; }

        [StringLength(15)]
        public string DefBadShelf { get; set; }

        [StringLength(10)]
        public string DefFGWHCode { get; set; }

        [StringLength(15)]
        public string DefFGShelf { get; set; }

        [StringLength(10)]
        public string DefRepairWHCode { get; set; }

        [StringLength(15)]
        public string DefRepairShelf { get; set; }

        [StringLength(10)]
        public string DefRawWHCode { get; set; }

        [StringLength(15)]
        public string DefRawShelf { get; set; }

        [StringLength(10)]
        public string Formula1 { get; set; }

        [StringLength(10)]
        public string Formula2 { get; set; }

        [StringLength(10)]
        public string Formula3 { get; set; }

        [StringLength(35)]
        public string Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReserveQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainOutQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainInQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? BasePrice { get; set; }

        public short? ActiveStatus { get; set; }

        public short? CanMakePO { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePrice8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceVatOut8 { get; set; }

        [StringLength(10)]
        public string DefFixUnitCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefFixUnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? FixCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePriceNV1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePriceNV2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalePriceNV3 { get; set; }

        public short? ProcessStatus { get; set; }

        public short? IsGift { get; set; }

        public short? PromoMember { get; set; }

        public short? PromoType { get; set; }

        [Column(TypeName = "money")]
        public decimal? AverageCostReal { get; set; }

        [Column(TypeName = "money")]
        public decimal? OverReceive { get; set; }

        [Column(TypeName = "money")]
        public decimal? ContainerCapacity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ContainerWeight { get; set; }

        [StringLength(20)]
        public string CapacityUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastBuyPriceHome { get; set; }

        [StringLength(10)]
        public string LastBuyCurrencyCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastAvgCost { get; set; }

        [StringLength(255)]
        public string UserGroup { get; set; }

        [Column(TypeName = "money")]
        public decimal? stockqty1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? stockqty2 { get; set; }

        [StringLength(255)]
        public string StockQtyWord { get; set; }

        [StringLength(255)]
        public string CustGroup { get; set; }

        [StringLength(10)]
        public string PublisherCode { get; set; }

        [StringLength(255)]
        public string WriterCode { get; set; }

        public short? PrintOrdinal { get; set; }

        public short? PrintYear { get; set; }

        public DateTime? LastSaleDate { get; set; }

        public DateTime? LastBuyDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastSalePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastSalePriceHome { get; set; }

        [StringLength(10)]
        public string LastSaleCurrencyCode { get; set; }

        [StringLength(255)]
        public string Specification { get; set; }

        [StringLength(10)]
        public string ManufactoryCode { get; set; }

        [StringLength(255)]
        public string AFT_remark { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitWeight { get; set; }

        [StringLength(10)]
        public string WeightUnitCode { get; set; }

        [StringLength(60)]
        public string LeadTime { get; set; }

        [StringLength(255)]
        public string OfferedBy { get; set; }

        public DateTime? OfferedDate { get; set; }

        [StringLength(255)]
        public string HS_SMX_remark { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string ItemBarCode { get; set; }

        [StringLength(10)]
        public string PriceCode { get; set; }

        [StringLength(10)]
        public string Classfication { get; set; }

        public short? DiscCashCard { get; set; }

        [Column(TypeName = "money")]
        public decimal? STOCKQTYSTANDARD { get; set; }

        public short? ISCHANGEQTY { get; set; }

        [Column(TypeName = "money")]
        public decimal? DOSTOCKQTY { get; set; }

        public short? INSURANCEDAY { get; set; }

        public short? INSURANCEDAY2 { get; set; }

        public short? AGERANGEDAY { get; set; }

        [Column(TypeName = "money")]
        public decimal? LASTBUYPRICE2 { get; set; }

        [StringLength(35)]
        public string LASTBUYDISCOUNT { get; set; }

        [StringLength(35)]
        public string FORMATRUNSERIAL { get; set; }

        [Column(TypeName = "money")]
        public decimal? LASTBUYPRICE3 { get; set; }

        public short? POSPRICEEDITAUTHORIZED { get; set; }
    }
}
