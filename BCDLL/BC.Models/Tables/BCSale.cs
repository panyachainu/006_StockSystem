namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCSale")]
    public partial class BCSale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(30)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string PictureFileName { get; set; }

        [StringLength(20)]
        public string UserPassword { get; set; }

        [StringLength(40)]
        public string UserID { get; set; }

        [StringLength(255)]
        public string EmailAddress { get; set; }

        public short? POApprove { get; set; }

        public short? QuoApprove { get; set; }

        public short? SOApprove { get; set; }

        public short? InformPrice { get; set; }

        public short? ActiveStatus { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        public short? ApproveCredit { get; set; }

        [StringLength(10)]
        public string UserGroup { get; set; }

        [StringLength(250)]
        public string Salemembers { get; set; }

        [StringLength(255)]
        public string USERGROUPLIST { get; set; }

        [StringLength(250)]
        public string NOTPURCHASEITEM { get; set; }

        [Column(TypeName = "money")]
        public decimal? RATECOM { get; set; }

        [StringLength(50)]
        public string PWORD { get; set; }

        [StringLength(50)]
        public string CPWORD { get; set; }

        public short? CANCELONSALE { get; set; }

        public short? CHANGEPRICE { get; set; }

        public short? NONPWDCHNGPRC { get; set; }
    }
}
