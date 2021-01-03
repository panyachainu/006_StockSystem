namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCAR")]
    public partial class BCAR
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string Name1 { get; set; }

        [StringLength(255)]
        public string Name2 { get; set; }

        [StringLength(10)]
        public string DefDeliveryAddr { get; set; }

        [StringLength(10)]
        public string DefContactCode { get; set; }

        [StringLength(10)]
        public string DefTransport { get; set; }

        [StringLength(255)]
        public string BillAddress { get; set; }

        [StringLength(255)]
        public string WorkAddress { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string AccountCode { get; set; }

        [StringLength(30)]
        public string IDCardNo { get; set; }

        public DateTime? LastContactDate { get; set; }

        public DateTime? LastPayDate { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [StringLength(20)]
        public string ParentCode { get; set; }

        public short? BillCredit { get; set; }

        public short? TransportCredit { get; set; }

        public short? CreditStatus { get; set; }

        [StringLength(35)]
        public string DetailDiscount { get; set; }

        [StringLength(35)]
        public string Discount { get; set; }

        [StringLength(35)]
        public string CashDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebtLimit1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebtLimit2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebtLimitBal { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebtAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChqOnHand { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditOnHand { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChqReturn { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount { get; set; }

        public short? IsMakeTrans { get; set; }

        public short? TaxType { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultTaxRate { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        [StringLength(50)]
        public string PaymentRemark { get; set; }

        [StringLength(50)]
        public string StatementRemark { get; set; }

        [StringLength(50)]
        public string PicFileName { get; set; }

        [StringLength(10)]
        public string TypeCode { get; set; }

        [StringLength(10)]
        public string GroupCode { get; set; }

        [StringLength(10)]
        public string SaleAreaCode { get; set; }

        [StringLength(255)]
        public string HomePage { get; set; }

        [StringLength(40)]
        public string EmailAddress { get; set; }

        [StringLength(10)]
        public string GroupOfDebt { get; set; }

        public short? PersonType { get; set; }

        [Column(TypeName = "money")]
        public decimal? AuthorizeAmount { get; set; }

        [StringLength(255)]
        public string DocPicRefFile1 { get; set; }

        [StringLength(255)]
        public string DocPicRefFile2 { get; set; }

        public DateTime? BirthDay { get; set; }

        public short? CustAge { get; set; }

        public short? CustStatus { get; set; }

        public short? CustCreditType { get; set; }

        [StringLength(30)]
        public string ReceiveByDay { get; set; }

        [StringLength(30)]
        public string ReceiveByDate { get; set; }

        public short? ReceiveByWeek { get; set; }

        [StringLength(30)]
        public string PayBillByDay { get; set; }

        [StringLength(30)]
        public string PayBillByDate { get; set; }

        public short? PayBillByWeek { get; set; }

        [StringLength(10)]
        public string RouteStep1 { get; set; }

        [StringLength(10)]
        public string RouteStep2 { get; set; }

        [StringLength(10)]
        public string RouteStep3 { get; set; }

        [StringLength(10)]
        public string RouteStep4 { get; set; }

        [StringLength(10)]
        public string RouteStep5 { get; set; }

        [StringLength(10)]
        public string RouteStep6 { get; set; }

        [StringLength(10)]
        public string RouteStep7 { get; set; }

        [StringLength(10)]
        public string RouteStep8 { get; set; }

        [StringLength(10)]
        public string RouteStep9 { get; set; }

        [StringLength(10)]
        public string RouteStep10 { get; set; }

        public short? PriceLevel { get; set; }

        public short? ActiveStatus { get; set; }

        [StringLength(10)]
        public string MapCode { get; set; }

        public short? MapPosition_X { get; set; }

        public short? MapPosition_Y { get; set; }

        public short? ItemDescGroup { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        [StringLength(10)]
        public string CreditMenCode { get; set; }

        [StringLength(10)]
        public string CreditMenCode2 { get; set; }

        [StringLength(10)]
        public string CreditMenCode3 { get; set; }

        [StringLength(10)]
        public string PressMenCode { get; set; }

        [StringLength(10)]
        public string PressMenCode2 { get; set; }

        [StringLength(10)]
        public string PressMenCode3 { get; set; }

        [StringLength(10)]
        public string KeepMoneyMenCode { get; set; }

        [StringLength(10)]
        public string KeepMoneyMenCode2 { get; set; }

        [StringLength(10)]
        public string KeepMoneyMenCode3 { get; set; }

        [StringLength(10)]
        public string CondPayCode { get; set; }

        public short? UseGroupMoney { get; set; }

        [StringLength(10)]
        public string GroupCreditCode { get; set; }

        [StringLength(10)]
        public string HomeCurCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? EarnestAmount { get; set; }

        [StringLength(255)]
        public string billcompanyname { get; set; }

        public short? billisdefault { get; set; }

        [StringLength(255)]
        public string billrestype { get; set; }

        [StringLength(10)]
        public string billno { get; set; }

        [StringLength(10)]
        public string billmoo { get; set; }

        [StringLength(255)]
        public string billvillage { get; set; }

        [StringLength(255)]
        public string billbuilding { get; set; }

        [StringLength(10)]
        public string billfloor { get; set; }

        [StringLength(10)]
        public string billroom { get; set; }

        [StringLength(255)]
        public string billsoi { get; set; }

        [StringLength(255)]
        public string billroad { get; set; }

        [StringLength(255)]
        public string billsubdist { get; set; }

        [StringLength(255)]
        public string billdistrict { get; set; }

        [StringLength(255)]
        public string billprovince { get; set; }

        [StringLength(255)]
        public string billcountry { get; set; }

        [StringLength(10)]
        public string billzipcode { get; set; }

        public short? billissubdist { get; set; }

        public short? billisdistrict { get; set; }

        [StringLength(255)]
        public string homecompanyname { get; set; }

        public short? homeisdefault { get; set; }

        [StringLength(255)]
        public string homerestype { get; set; }

        [StringLength(10)]
        public string homeno { get; set; }

        [StringLength(10)]
        public string homemoo { get; set; }

        [StringLength(255)]
        public string homevillage { get; set; }

        [StringLength(255)]
        public string homebuilding { get; set; }

        [StringLength(10)]
        public string homefloor { get; set; }

        [StringLength(10)]
        public string homeroom { get; set; }

        [StringLength(255)]
        public string homesoi { get; set; }

        [StringLength(255)]
        public string homeroad { get; set; }

        [StringLength(255)]
        public string homesubdist { get; set; }

        [StringLength(255)]
        public string homedistrict { get; set; }

        [StringLength(255)]
        public string homeprovince { get; set; }

        [StringLength(255)]
        public string homecountry { get; set; }

        [StringLength(10)]
        public string homezipcode { get; set; }

        public short? homeissubdist { get; set; }

        public short? homeisdistrict { get; set; }

        public short? checkoverdueCRLimit { get; set; }

        public short? overdueCreditLimit { get; set; }

        [StringLength(255)]
        public string DiscountWord { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultWTaxCash { get; set; }

        [StringLength(10)]
        public string DefSaleWHCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(20)]
        public string MEMBERID { get; set; }

        public DateTime? BEGINDATE { get; set; }

        public DateTime? EXPIREDATE { get; set; }

        public short? REMEMBER { get; set; }

        public int? SUMOFMARK1 { get; set; }

        public int? SUMOFMARK2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFAMOUNT1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFAMOUNT2 { get; set; }

        [StringLength(100)]
        public string REFFILENAME1 { get; set; }

        [StringLength(100)]
        public string REFFILENAME2 { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [Column(TypeName = "money")]
        public decimal? CREDITAMOUNTTYPE { get; set; }

        [StringLength(255)]
        public string LINKWORDFILE { get; set; }

        //public short? PRINTADDRGROUP { get; set; }
    }
}
