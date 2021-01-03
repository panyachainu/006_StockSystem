namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BCARDeposit")]
    public partial class BCARDeposit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ROWORDER { get; set; }

        [Key]
        [StringLength(20)]
        public string DocNo { get; set; }

        public DateTime? DocDate { get; set; }

        public DateTime? TaxDate { get; set; }

        public short? TaxType { get; set; }

        [StringLength(20)]
        public string TaxNo { get; set; }

        [StringLength(20)]
        public string ArCode { get; set; }

        [StringLength(10)]
        public string DepartCode { get; set; }

        public short? CreditDay { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(10)]
        public string SaleCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        public short? IsConfirm { get; set; }

        [StringLength(255)]
        public string MyDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? BeforeTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumOfWTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? BillBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherIncome { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherExpense { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExcessAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChargeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChangeAmount { get; set; }

        [StringLength(20)]
        public string RefNo { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumCashAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumChqAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumCreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumBankAmount { get; set; }

        [StringLength(5)]
        public string GLFormat { get; set; }

        public short? GLStartPosting { get; set; }

        public short? IsPostGL { get; set; }

        public short? IsCancel { get; set; }

        public short? IsReturnMoney { get; set; }

        public short? GLTransData { get; set; }

        [StringLength(10)]
        public string AllocateCode { get; set; }

        [StringLength(10)]
        public string ProjectCode { get; set; }

        [StringLength(20)]
        public string BillGroup { get; set; }

        [StringLength(40)]
        public string RecurName { get; set; }

        [StringLength(10)]
        public string ConfirmCode { get; set; }

        public DateTime? ConfirmDateTime { get; set; }

        [StringLength(10)]
        public string CancelCode { get; set; }

        public DateTime? CancelDateTime { get; set; }

        public short? PrintCount { get; set; }

        [StringLength(20)]
        public string JobNo { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }
    }
}
