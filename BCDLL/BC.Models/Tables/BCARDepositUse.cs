namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCARDepositUse")]
    public partial class BCARDepositUse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string DocNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string DepositNo { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        public DateTime? DocDate { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public short? DeposTaxType { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetAmount { get; set; }

        public short? LineNumber { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? DPExchangeRate { get; set; }

        public decimal? NewExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? HomeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeProfit { get; set; }
    }
}
