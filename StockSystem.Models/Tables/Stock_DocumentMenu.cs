namespace StockSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock_DocumentMenu")]
    public partial class Stock_DocumentMenu
    {
        public Stock_DocumentMenu()
        {
            Stock_DocumentFormat = new HashSet<Stock_DocumentFormat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(50)]
        public string Menu_ID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public virtual ICollection<Stock_DocumentFormat> Stock_DocumentFormat { get; set; }
    }
}
