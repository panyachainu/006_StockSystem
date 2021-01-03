namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BCFinishGoods
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
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

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(10)]
        public string PersonCode { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfAmount { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(5)]
        public string GLFormat { get; set; }

        public short? GLStartPosting { get; set; }

        public short? IsCancel { get; set; }

        public short? IsPostGL { get; set; }

        public short? GLTransData { get; set; }

        public short? IsProcessOK { get; set; }

        public short? IsCompleteSave { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfCost { get; set; }

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

        public short? IsImport { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFCOST2 { get; set; }

        public short? ISPOS { get; set; }
    }
}
