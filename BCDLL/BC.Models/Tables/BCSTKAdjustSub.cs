namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCSTKAdjustSub")]
    public partial class BCSTKAdjustSub
    {
        [Key]
        public int ROWORDER { get; set; }

        public short? BehindIndex { get; set; }

        public short? MyType { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

        public DateTime? DocDate { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(20)]
        public string InspectNo { get; set; }

        public int? InspectRow { get; set; }

        [StringLength(25)]
        public string ItemCode { get; set; }

        [StringLength(10)]
        public string UnitCode { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(10)]
        public string WHCode { get; set; }

        [StringLength(15)]
        public string ShelfCode { get; set; }

        public short? TransState { get; set; }

        public short? IsCancel { get; set; }

        public short? AdjMark { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfCost { get; set; }

        public short? ExceptTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public short? LineNumber { get; set; }

        public short? PackingStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetAmount { get; set; }

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

        [Column(TypeName = "smallmoney")]
        public decimal? IsProcess { get; set; }

        public short? IsLockCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFCOST2 { get; set; }

        [StringLength(20)]
        public string BARCODE { get; set; }

        public short? ISPOS { get; set; }
    }
}
