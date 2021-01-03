namespace BC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BCConfigurations
    {
        [Key]
        [StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string CompanyNameEng { get; set; }

        [StringLength(255)]
        public string ManagerName { get; set; }

        public short? IsExport { get; set; }

        [StringLength(10)]
        public string CreatorCode { get; set; }

        public DateTime? CreateDateTime { get; set; }

        [StringLength(10)]
        public string LastEditorCode { get; set; }

        public DateTime? LastEditDateT { get; set; }

        [StringLength(255)]
        public string ManagerNameEng { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string AddressEng { get; set; }

        [StringLength(255)]
        public string Telephone { get; set; }

        [StringLength(255)]
        public string Fax { get; set; }

        public short? DeficitStatus { get; set; }

        public short? YearType { get; set; }

        [StringLength(30)]
        public string TaxNumber { get; set; }

        public short? DefaultTaxType { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultTaxRate { get; set; }

        public short? DebtOverWarning { get; set; }

        public short? SODebtWarning { get; set; }

        public short? BillDebtWarning { get; set; }

        public short? StockStatus { get; set; }

        public short? PriceWarning { get; set; }

        [StringLength(30)]
        public string PriceCostRatio { get; set; }

        public short? ItemSetStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? BeginQty { get; set; }

        public short? QtyPoint { get; set; }

        public short? CostPoint { get; set; }

        public short? PricePoint { get; set; }

        public short? AmountPoint { get; set; }

        public short? StockRemain { get; set; }

        public short? DetailDiscount { get; set; }

        public short? BillDiscount { get; set; }

        public short? MultiCurrency { get; set; }

        public short? DiscPromotion { get; set; }

        public short? PricePromotion { get; set; }

        public short? PostGLStatus { get; set; }

        public short? GLBalanceCheck { get; set; }

        public short? BillConfirm { get; set; }

        public short? DefaultItemName { get; set; }

        public short? DefaultArName { get; set; }

        public short? DefaultApName { get; set; }

        public short? DefaultAccName { get; set; }

        public short? ExceptTax { get; set; }

        public short? ZeroTaxRate { get; set; }

        public short? UseLotStatus { get; set; }

        public short? LotStatus { get; set; }

        public short? ServiceItem { get; set; }

        public short? SpecialItem { get; set; }

        public short? SerialItem { get; set; }

        public short? UseExpCost { get; set; }

        public short? DiscountMethod { get; set; }

        public short? BillDetailDesc { get; set; }

        public short? BuyItemSupplier { get; set; }

        public short? OppositeUnit { get; set; }

        [StringLength(50)]
        public string ChqCondition { get; set; }

        [StringLength(50)]
        public string PaybillRemark { get; set; }

        public short? InvoiceOnStart { get; set; }

        public short? ChqOnStart { get; set; }

        public short? StockLowOnStart { get; set; }

        public short? StkDeficitWarn { get; set; }

        public short? StkRemainOut { get; set; }

        public short? StkRemainIn { get; set; }

        public short? LogBookUse { get; set; }

        public short? Consignment { get; set; }

        public short? PrintSlip { get; set; }

        public short? PrintBill { get; set; }

        public short? AutoBillDocGroup { get; set; }

        public short? DefItemBillType { get; set; }

        public short? DefBuyBillType { get; set; }

        public short? DisplayPicture { get; set; }

        public short? CurrencySymbol { get; set; }

        [StringLength(2)]
        public string HCurrencySymbol { get; set; }

        [StringLength(10)]
        public string HCurrencyCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? CashBalance { get; set; }

        public short? PayBillDuplicate { get; set; }

        public short? DepartSeparate { get; set; }

        public short? ProjectSeparate { get; set; }

        public short? AllocateSeparate { get; set; }

        public short? JobSeparate { get; set; }

        public short? PartSeparate { get; set; }

        public short? SideSeparate { get; set; }

        public short? IsExDescription { get; set; }

        public short? BranchSeparate { get; set; }

        public short? InventoryMethod { get; set; }

        public short? ExcessStatus { get; set; }

        public short? OtherIncome { get; set; }

        public short? SONoAddnew { get; set; }

        public short? SONoEditQty { get; set; }

        public short? SONoEditPrice { get; set; }

        public short? SONoEditDiscount { get; set; }

        public short? BILLNoAddnew { get; set; }

        public short? BILLNoEditQty { get; set; }

        public short? BILLNoEditPrice { get; set; }

        public short? BILLNoEditDiscount { get; set; }

        public short? BUYNoAddnew { get; set; }

        public short? BUYNoEditQty { get; set; }

        public short? BUYNoEditPrice { get; set; }

        public short? BUYNoEditDiscount { get; set; }

        public short? GRNoAddnew { get; set; }

        public short? GRNoEditQty { get; set; }

        public short? GRNoEditPrice { get; set; }

        public short? AutoPostGL { get; set; }

        public short? AutoServerProc { get; set; }

        public short? PosRepSeparate { get; set; }

        public short? IsBoxDuplicate { get; set; }

        public short? IsJob { get; set; }

        public short? CreditLimitFlag { get; set; }

        public short? SerialItemPerLine { get; set; }

        public short? PrintSerialInvoice { get; set; }

        public short? IsEditItemName { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSCurSum1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSCurSum2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSCurSum3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSCurSum4 { get; set; }

        public short? DayCallCust { get; set; }

        public short? IsPrintSumPage { get; set; }

        public short? IsPrintCancel { get; set; }

        public short? IsUseWarehouse { get; set; }

        [StringLength(255)]
        public string MailSMTP { get; set; }

        [StringLength(255)]
        public string MailPOP3 { get; set; }

        [StringLength(255)]
        public string MailFrom { get; set; }

        public short? IsReceiveMoney { get; set; }

        public short? IsSetWorkDate { get; set; }

        public short? IsUserGroup { get; set; }

        public short? IsCustGroup { get; set; }

        public short? SaleBaseOnSO { get; set; }

        public short? FormDateStyle { get; set; }

        public short? FormNumericStyle { get; set; }

        public short? IsItemRemainQty { get; set; }

        public short? IsShowSetDetail { get; set; }

        public short? IsShowSetPrice { get; set; }

        public short? BuyPriceWarning { get; set; }

        public short? SalePriceLevel { get; set; }

        public short? IsLastBuyPrice { get; set; }

        public short? IsProcessThread { get; set; }

        public short? IsReportThread { get; set; }

        public short? CostType { get; set; }

        public short? ShowItemSetPrice { get; set; }

        public short? IsSkipAddItemSuplier { get; set; }

        public DateTime? LastProcess { get; set; }

        public short? IsCheckService { get; set; }

        public short? IsBehindIndex { get; set; }

        public short? IsMethodCutPO { get; set; }

        public short? IsTaxType { get; set; }

        public short? IsNoStockReword { get; set; }

        public short? IsCreateGLTrans { get; set; }

        public short? DefaultCostType { get; set; }

        public short? IsGetLastDiscount { get; set; }

        public short? IsDepositCash { get; set; }

        public short? IsWarnDeposit { get; set; }

        public short? IsHello { get; set; }

        public short? IsHardLock { get; set; }

        public short? IsVersion { get; set; }

        public short? IsLotDuplicate { get; set; }

        [StringLength(10)]
        public string IsCode { get; set; }

        public short? IsSumPo { get; set; }

        public short? IsNotEditdoc { get; set; }

        public short? IsChkSOQtyWH { get; set; }

        public short? IsSmallChange { get; set; }

        public short? PromotionMode { get; set; }

        public short? IsStockAmountType { get; set; }

        public short? IsReturnType { get; set; }

        public short? ItemAmountPoint { get; set; }

        public short? SOItemSetDetail { get; set; }

        public short? SRItemSetDetail { get; set; }

        public short? BillItemSetDetail { get; set; }

        public short? TRReqItemSetDetail { get; set; }

        public short? TRItemSetDetail { get; set; }

        public short? IsShowPriceStkTR { get; set; }

        public short? IsShowPricePR { get; set; }

        public short? SelectPrintSerial { get; set; }

        public short? SumBillByItem { get; set; }

        public short? CheckGLRefNo { get; set; }

        public short? IsShowItemNew { get; set; }

        public short? IsArDefaultWH { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgTaxRate { get; set; }

        public short? UseAvgTax { get; set; }

        [StringLength(50)]
        public string RegisterNo { get; set; }

        public short? IsUseCreditSO { get; set; }

        public short? IsConfirmPO { get; set; }

        public short? IsDueDateSO { get; set; }

        public short? USECHANGELOGBOOK { get; set; }

        [Column(TypeName = "money")]
        public decimal? DIFFAMOUNT { get; set; }

        public DateTime? SERVICEEXPIRE { get; set; }

        public short? SOSRDEFTYPE { get; set; }

        public short? ISSHOWPRICSET2 { get; set; }

        public short? ISCHECKSTOCKMIN { get; set; }

        public short? ISWOARNTAXNO { get; set; }

        public short? WARNINGLOWERSTDPRICE { get; set; }

        public short? WARNTAXNOEMPTY { get; set; }

        public short? BUYPRICEPOINT { get; set; }
    }
}
