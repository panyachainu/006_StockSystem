namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCBank")]
    public partial class BCBank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(10)]
        public string Code { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string UserGroup { get; set; }
    }
}
