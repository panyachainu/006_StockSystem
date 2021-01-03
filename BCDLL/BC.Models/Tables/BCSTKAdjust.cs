namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCSTKAdjust")]
    public partial class BCSTKAdjust
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

        [StringLength(20)]
        public string InspectNo { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [StringLength(5)]
        public string GLFormat { get; set; }

        public short? GLStartPosting { get; set; }

        public short? IsPostGL { get; set; }

        public short? GLTransData { get; set; }

        public short? IsConfirm { get; set; }

        public short? IsCancel { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumAmount2 { get; set; }

        public short? IsCompleteSave { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfExceptTax { get; set; }

        public short? OutputTaxStatus { get; set; }

        public short? AdjustType { get; set; }

        public short? PackingStatus { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfCost { get; set; }

        public short? PrintCount { get; set; }

        public short? IsImport { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        [StringLength(30)]
        public string CANCELCODE { get; set; }

        public DateTime? CANCELDATETIME { get; set; }

        [Column(TypeName = "money")]
        public decimal? SUMOFCOST2 { get; set; }

        public short? ISPOS { get; set; }
    }
}
