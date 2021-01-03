namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCStkWarehouse")]
    public partial class BCStkWarehouse
    {
        [Key]
        public int ROWORDER { get; set; }

        [StringLength(25)]
        public string ItemCode { get; set; }

        [StringLength(10)]
        public string WHCode { get; set; }

        [StringLength(15)]
        public string ShelfCode { get; set; }

        [StringLength(10)]
        public string UnitCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReserveQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainInQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainOutQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public short? ItemPriority { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReadyQtyAll { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReserveQtyAll { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainQtyAll { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainOutQtyAll { get; set; }

        [Column(TypeName = "money")]
        public decimal? averagecost { get; set; }

        public DateTime? DocDate { get; set; }
    }
}
