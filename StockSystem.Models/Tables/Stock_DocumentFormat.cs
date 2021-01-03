namespace StockSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock_DocumentFormat")]
    public partial class Stock_DocumentFormat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Format_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Menu_ID { get; set; }

        public int? Running_Len { get; set; }

        public bool? Prefix_Enable { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        public bool? Year_Enable { get; set; }

        public int? Year_Len { get; set; }

        public bool? Month_Enable { get; set; }

        public bool? Day_Enable { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public virtual Stock_DocumentMenu Stock_DocumentMenu { get; set; }

        public virtual Stock_DocumentRunning Stock_DocumentRunning { get; set; }
    }
}
