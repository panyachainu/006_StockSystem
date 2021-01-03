namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCAP")]
    public partial class BCAP
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

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string TransportRemark { get; set; }

        [StringLength(10)]
        public string DefTransport { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(20)]
        public string AccountCode { get; set; }

        [StringLength(30)]
        public string IDCardNo { get; set; }

        [StringLength(30)]
        public string BankAccNo { get; set; }

        public DateTime? LastContactDate { get; set; }

        public DateTime? LastPayDate { get; set; }

        public short? CreditDay { get; set; }

        [StringLength(35)]
        public string DetailDiscount { get; set; }

        [StringLength(35)]
        public string Discount { get; set; }

        [StringLength(35)]
        public string CashDiscount { get; set; }

        public short? LeadTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebtLimit { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebtAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChqOnHand { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChqReturn { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultTaxRate { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        [StringLength(255)]
        public string PaymentRemark { get; set; }

        [StringLength(255)]
        public string StatementRemark { get; set; }

        [StringLength(50)]
        public string PicFileName { get; set; }

        [StringLength(10)]
        public string TypeCode { get; set; }

        [StringLength(40)]
        public string EmailAddress { get; set; }

        [StringLength(10)]
        public string GroupCode { get; set; }

        [StringLength(10)]
        public string GroupOfDebt { get; set; }

        public short? PersonType { get; set; }

        public short? IsMakeTrans { get; set; }

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

        [StringLength(255)]
        public string UserGroup { get; set; }

        [Column(TypeName = "money")]
        public decimal? EarnestAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultWTaxCash { get; set; }

        public short? TaxType { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(20)]
        public string departcode { get; set; }

        [StringLength(255)]
        public string departname { get; set; }

        [StringLength(20)]
        public string arcode { get; set; }

        [StringLength(255)]
        public string arname { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }
    }
}
