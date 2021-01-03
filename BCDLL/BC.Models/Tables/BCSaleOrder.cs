namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCSaleOrder")]
    public partial class BCSaleOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        public DateTime? DocDate { get; set; }

        public short? TaxType { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        public short? BillType { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        public short? CreditDay { get; set; }

        public DateTime? DueDate { get; set; }

        public short? DeliveryDay { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(10)]
        public string DeliveryAddr { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(20)]
        public string RefDocNo { get; set; }

        public short? BillStatus { get; set; }

        public short? DeliveryStatus { get; set; }

        public short? SOStatus { get; set; }

        public short? HoldingStatus { get; set; }

        [StringLength(20)]
        public string CrAuthorizeMan { get; set; }

        [StringLength(20)]
        public string BillGroup { get; set; }

        [StringLength(10)]
        public string ContactCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfItemAmount { get; set; }

        [StringLength(30)]
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
        public decimal? NetAmount { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        public short? IsCancel { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(40)]
        public string RecurName { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        public short? IsConditionSend { get; set; }

        [StringLength(255)]
        public string OwnReceive { get; set; }

        [StringLength(30)]
        public string CarLicense { get; set; }

        [StringLength(10)]
        public string ApproveCode { get; set; }

        public DateTime? ApproveDateTime { get; set; }

        public short? IsUseRobotSale { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTransport { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOtherValue { get; set; }

        public short? READYFORPAY { get; set; }

        [StringLength(10)]
        public string TimeTransport { get; set; }

        [StringLength(10)]
        public string CarType { get; set; }

        [StringLength(10)]
        public string CondPayCode { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(20)]
        public string PORefNo { get; set; }

        public short? IsImport { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        [StringLength(10)]
        public string MethodePaybill { get; set; }

        [StringLength(255)]
        public string MethodePaybill2 { get; set; }

        [StringLength(20)]
        public string promotioncode { get; set; }

        public short? IsPackingList { get; set; }

        [StringLength(255)]
        public string VesselOr { get; set; }

        public DateTime? ETADate { get; set; }

        public DateTime? ETDDate { get; set; }

        [StringLength(255)]
        public string ETADateRemark { get; set; }

        [StringLength(255)]
        public string ETDDateRemark { get; set; }

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
        public string IssuingBank { get; set; }

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

        [StringLength(255)]
        public string Incoterms { get; set; }

        [StringLength(10)]
        public string ProductCategory { get; set; }

        [StringLength(10)]
        public string AdvisingBank { get; set; }

        [StringLength(1000)]
        public string FootNote { get; set; }

        [StringLength(1000)]
        public string InfavorOf { get; set; }

        [StringLength(20)]
        public string ProformaNo { get; set; }
    }
}
