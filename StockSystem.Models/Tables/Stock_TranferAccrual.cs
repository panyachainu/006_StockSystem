namespace StockSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stock_TranferAccrual
    {
        [Key]
        public int ROWORDER { get; set; }

        public DateTime? TranferAccrual_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Tran_DocNo { get; set; }

        public DateTime Tran_DocDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TranferAccual_QtyReam { get; set; }

        [StringLength(20)]
        public string DocNo { get; set; }

        [Required]
        [StringLength(25)]
        public string ItemCode { get; set; }

        public DateTime? DocDate { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

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
        public decimal? QtyActual { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyRemain { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string UnitCode { get; set; }

        public short? LineNumber { get; set; }

        public int? Tran_StatusClear { get; set; }

        [StringLength(50)]
        public string Tran_Attribute01 { get; set; }

        [StringLength(50)]
        public string Tran_Attribute02 { get; set; }

        [StringLength(50)]
        public string Tran_Attribute03 { get; set; }

        [StringLength(50)]
        public string Tran_Attribute04 { get; set; }

        [StringLength(50)]
        public string Tran_Attribute05 { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string Tran_CreateBy { get; set; }

        public DateTime? Tran_CreateDate { get; set; }

        [StringLength(50)]
        public string Tran_UpdateBy { get; set; }

        public DateTime? Tran_UpdateDate { get; set; }
    }
}
