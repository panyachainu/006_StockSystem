namespace StockSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock_DocumentRunning")]
    public partial class Stock_DocumentRunning
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Format_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Menu_ID { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        public int? DocYear { get; set; }

        public int? DocMonth { get; set; }

        public int? DocDay { get; set; }

        public int? LastRunningID { get; set; }

        [Required]
        [StringLength(50)]
        public string FormatString { get; set; }

        [StringLength(50)]
        public string FormatDisplay { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? Active { get; set; }

        public virtual Stock_DocumentFormat Stock_DocumentFormat { get; set; }

        public void IncreaseNextNumber()
        {
            LastRunningID++;
        }

        public string GetNextNumber()
        {
            return string.Format(FormatString, Prefix,
                DocYear == 0 ? null : DocYear,
                DocMonth == 0 ? null : DocMonth,
                DocDay == 0 ? null : DocDay,
                LastRunningID);
        }
    }
}
