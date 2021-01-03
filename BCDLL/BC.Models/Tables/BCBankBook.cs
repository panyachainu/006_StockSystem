namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCBankBook")]
    public partial class BCBankBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(30)]
        public string BookNo { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(10)]
        public string AccountType { get; set; }

        [StringLength(50)]
        public string BankCode { get; set; }

        [StringLength(10)]
        public string BranchCode { get; set; }

        [StringLength(20)]
        public string AccountCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public short? ISCANCEL { get; set; }

        public short? ISCONFIRM { get; set; }

        [StringLength(30)]
        public string CONFIRMCODE { get; set; }

        public DateTime? CONFIRMDATETIME { get; set; }

        [StringLength(30)]
        public string CANCELCODE { get; set; }

        public DateTime? CANCELDATETIME { get; set; }
    }
}
