namespace StockSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VStock_ItemTranferSum
    {
        public long? RowID { get; set; }

        [Key]
        [StringLength(25)]
        public string ItemCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyActual { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyRemain { get; set; }
    }
}
