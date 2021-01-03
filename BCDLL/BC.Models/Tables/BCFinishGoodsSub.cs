namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCFinishGoodsSub")]
    public partial class BCFinishGoodsSub
    {
        [Key]
        public int ROWORDER { get; set; }

        public short? BehindIndex { get; set; }

        public short? MyType { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

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

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(10)]
        public string Personcode { get; set; }

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
        public decimal? Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string UnitCode { get; set; }

        [StringLength(10)]
        public string OppositeUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? OppositeQty { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

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

        public short? TransState { get; set; }

        public short? IsCancel { get; set; }

        public short? LineNumber { get; set; }

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

        [StringLength(20)]
        public string JobNo { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? TaxRate { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate1 { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? PackingRate2 { get; set; }

        public short? IsProcess { get; set; }

        public short? IsLockCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFCOST2 { get; set; }

        public short? ISPOS { get; set; }

        [StringLength(20)]
        public string GRDOCNO { get; set; }

        public short? GRREFLINENUM { get; set; }

        [Column(TypeName = "money")]
        public decimal? ISSUEREMAINQTY { get; set; }
    }
}
