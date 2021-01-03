using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BC.Models;
using System.ComponentModel.DataAnnotations.Schema;
namespace BC.DataAccess
{
    public partial class BCContext : DbContext
    {
        public BCContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<BCAP> BCAP { get; set; }
        public virtual DbSet<BCAR> BCAR { get; set; }
        public virtual DbSet<BCITEM> BCITEM { get; set; }
        public virtual DbSet<BCProject> BCProject { get; set; }
       
        public virtual DbSet<BCBank> BCBank { get; set; }
        public virtual DbSet<BCBankBook> BCBankBook { get; set; }
        public virtual DbSet<BCBankBranch> BCBankBranch { get; set; }
        public virtual DbSet<BPSCreditType> BPSCreditType { get; set; }

        public virtual DbSet<BCARDeposit> BCARDeposit { get; set; }
        public virtual DbSet<BCARINVOICE> BCARINVOICE { get; set; }
        public virtual DbSet<BCARINVOICESUB> BCARINVOICESUB { get; set; }
        public virtual DbSet<BCCreditNote> BCCreditNote { get; set; }
        public virtual DbSet<BCInvCreditNote> BCInvCreditNote { get; set; }
        public virtual DbSet<BCRecMoney> BCRecMoney { get; set; }
        public virtual DbSet<BCSaleOrder> BCSaleOrder { get; set; }
        public virtual DbSet<BCSaleOrderSub> BCSaleOrderSub { get; set; }
       
        public virtual DbSet<BCARDepositUse> BCARDepositUse { get; set; }
        public virtual DbSet<BCConfigurations> BCConfigurations { get; set; }
        public virtual DbSet<BCChqIn> BCChqIn { get; set; }
        public virtual DbSet<BCSale> BCSale { get; set; }
        public virtual DbSet<BCCreditCard> BCCreditCard { get; set; }

        public virtual DbSet<BCPaybill> BCPaybill { get; set; }

        public virtual DbSet<BCAPINVOICE> BCAPINVOICE { get; set; }
        public virtual DbSet<BCAPINVOICESUB> BCAPINVOICESUB { get; set; }
        public virtual DbSet<BCCreditNoteSub> BCCreditNoteSub { get; set; }
        public virtual DbSet<BCDebitNoteSub1> BCDebitNoteSub1 { get; set; }
        public virtual DbSet<BCDebitNoteSub2> BCDebitNoteSub2 { get; set; }
        public virtual DbSet<BCFinishGoods> BCFinishGoods { get; set; }
        public virtual DbSet<BCFinishGoodsSub> BCFinishGoodsSub { get; set; }
        public virtual DbSet<BCSTKAdjust> BCSTKAdjust { get; set; }
        public virtual DbSet<BCSTKAdjustSub> BCSTKAdjustSub { get; set; }
        public virtual DbSet<BCStkBalance> BCStkBalance { get; set; }
        public virtual DbSet<BCStkBalanceSub> BCStkBalanceSub { get; set; }
        public virtual DbSet<BCStkIssRetSub> BCStkIssRetSub { get; set; }
        public virtual DbSet<BCStkRefund> BCStkRefund { get; set; }
        public virtual DbSet<BCStkRefundSub> BCStkRefundSub { get; set; }
        public virtual DbSet<BCStkWarehouse> BCStkWarehouse { get; set; }
        public virtual DbSet<BCWarehouse> BCWarehouse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //--- 21-02-2016
            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.SumOfInvoice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.SumOfDebitNote)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.SumOfCreditNote)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.BeforeTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.BillTemporary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.WithHoldTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCPaybill>()
                .Property(e => e.BillsDiscount)
                .IsUnicode(false);


            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CreditCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.BookNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.StatusDocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.BankBranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CreditType)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.ConfirmNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.ChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CreditVatRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CreditVat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.CreditSumVat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.POSDOCNO)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCBATCHNO)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCCARDHOLDER)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCCARDEXPR)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCTID)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCSYSTEMTRC)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCNII)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditCard>()
                .Property(e => e.EDCNETAMOUNT)
                .HasPrecision(19, 4);

           

            modelBuilder.Entity<BCSale>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.PictureFileName)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.Salemembers)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.USERGROUPLIST)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.NOTPURCHASEITEM)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.RATECOM)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.PWORD)
                .IsUnicode(false);

            modelBuilder.Entity<BCSale>()
                .Property(e => e.CPWORD)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
               .Property(e => e.BankCode)
               .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.ChqNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.ExtendStatus)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.BookNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.StatusDocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.BankBranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCChqIn>()
                .Property(e => e.RECIVECHQBY)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.CompanyNameEng)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.ManagerName)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.ManagerNameEng)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.AddressEng)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.TaxNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.DefaultTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.PriceCostRatio)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.BeginQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.ChqCondition)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.PaybillRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.HCurrencySymbol)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.HCurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.CashBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.FSCurSum1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.FSCurSum2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.FSCurSum3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.FSCurSum4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.MailSMTP)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.MailPOP3)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.MailFrom)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.IsCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.AvgTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.RegisterNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCConfigurations>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.DepositNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.DPExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.NewExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.HomeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.HomeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDepositUse>()
                .Property(e => e.ExchangeProfit)
                .HasPrecision(19, 4);

            
            
            modelBuilder.Entity<BCARDeposit>()
               .Property(e => e.DocNo)
               .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.BeforeTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.SumOfWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.BillBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.OtherIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.OtherExpense)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ExcessAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ExcessAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ChangeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.RefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.SumCashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.SumChqAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.SumCreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.SumBankAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARDeposit>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.PassBillTo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SaleAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.InvoiceMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.RefDocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CrAuthorizeMan)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DeliveryAddr)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ContactCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TransportCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumOfItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.AfterDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BeforeTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ZeroTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ExceptTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumCashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumChqAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumCreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumBankAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumOfDeposit1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumOfDeposit2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumOfWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.NetDebtAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.OtherIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.OtherExpense)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ExcessAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ExcessAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BillBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ExchangeProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CustTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CustGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.Remark1)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.Remark2)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.Remark3)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.Remark4)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.Remark5)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TotalTransport)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.PayBillAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.GrossWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TimeTransport)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BillTemporary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.Netweight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.NumOfPallet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.QtyAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MethodePaybill)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MethodePaybill2)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.promotioncode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumOfWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SumBaseWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.VesselOr)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.FromVia)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ToVia)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MarkAndNos)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DeliverTo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CountryOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.PayDateRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BookNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.OtherPayment)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.FreightAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.InsuranceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.FobAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MyDescPort)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ProformaNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.IssuingBank)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.LCNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.LCDate)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.FormUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.FootNote)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBNO_1)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBNO_2)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBNO_3)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBNO_4)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBNO_5)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBAMOUNT1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBAMOUNT2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBAMOUNT3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBAMOUNT4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.TAXABBAMOUNT5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.APPROVEDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CANCELDESC)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ARNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.ARADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CASHIERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SHIFTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MACHINENO)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.MACHINECODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BILLTIME)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CREDITTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CREDITBRANCH)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CREDITNO)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.COFIRMNO)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CHARGEWORD)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CREDITBASEAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CREDITVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CREDITSUMVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.GRANDTOTAL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.COUPONGAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.COUPONGDESC)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CHANGEAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.OTHERAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.OTHERFEE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SUMMARKVALUE1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.SUMMARKVALUE2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.DIFFAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CUST_REFCOUPON)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CUST_MOBILEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.CUST_MEMBERCARD)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.RECEIVEITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCBATCHNO)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCCARDHOLDER)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCCARDEXPR)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCTID)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCSYSTEMTRC)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCNII)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICE>()
                .Property(e => e.EDCNETAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CNQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BalanceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.OppositePrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.PORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CustTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CustGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SaleAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.MACHINENO)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.MACHINECODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BILLTIME)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.CASHIERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SHIFTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.OLDPRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.USERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.TransportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.itemsetcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.PriceCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.DORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.ItemNameDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.promotioncode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.masteritemcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BTDisc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.WTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BaseWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.Netweight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.GrossWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.Measurement)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.MeasureWide)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.MeasureLong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.MeasureHigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.FactorPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.RECEIVEITEMTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.RETAILPRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCARINVOICESUB>()
                .Property(e => e.RETAILAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.CashierCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOfItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOldAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumTrueAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumofDiffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumofBeforeTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOfTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOfTotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOfZeroTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOfExceptTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumOfWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.NetDebtAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumExchangeProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.BillBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.OtherIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.OtherExpense)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ExcessAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ExcessAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumCashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumChqAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumCreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SumBankAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ChangeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.PosDocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.CauseCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.PayBillAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.CustGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.BillTemporary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.QtyAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.MethodePaybill)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.MethodePaybill2)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SaleAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.PETTYCASHAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.COUPONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.COUPONAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ARNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNote>()
                .Property(e => e.ARADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.CreditNoteNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.InvoiceDisc)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.InvExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.NewExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.OldAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.SumOfItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.DiffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.ZeroTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.ExceptTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.TrueAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.HomeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.HomeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.ExchangeProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.Custgroupcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCInvCreditNote>()
                .Property(e => e.InvoiceMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.PayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ChqTotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.CreditType)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ChargeWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ConfirmNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.RefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.SaleAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.BankBranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCRecMoney>()
                .Property(e => e.ChangeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.DeliveryAddr)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.RefDocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CrAuthorizeMan)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ContactCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.SumOfItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.AfterDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.BeforeTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ExceptTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ZeroTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.OwnReceive)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CarLicense)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ApproveCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.TotalTransport)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.SumOtherValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.TimeTransport)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CarType)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CondPayCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.PORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.MethodePaybill)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.MethodePaybill2)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.promotioncode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.VesselOr)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ETADateRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ETDDateRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.FromVia)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ToVia)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.MarkAndNos)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.DeliverTo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.CountryOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.PayDateRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.BookNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.IssuingBank)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.OtherPayment)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.FreightAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.InsuranceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.FobAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.MyDescPort)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.Incoterms)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ProductCategory)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.AdvisingBank)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.FootNote)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.InfavorOf)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrder>()
                .Property(e => e.ProformaNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.RemainQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.DeliveryQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.OppositePrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.StkReserveNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.TransportAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.OtherValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.REMAINPAYQTY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.itemsetcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.PORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.promotioncode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.masteritemcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.Netweight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.GrossWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.Measurement)
                .IsUnicode(false);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.MeasureWide)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.MeasureLong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.MeasureHigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.FactorPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.POQTY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.RETAILPRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSaleOrderSub>()
                .Property(e => e.RETAILAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCBank>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCBank>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBank>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBank>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCBank>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.BookNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.AccountType)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.CONFIRMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBook>()
                .Property(e => e.CANCELCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBranch>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBranch>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBranch>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBranch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCBankBranch>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BPSCreditType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BPSCreditType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BPSCreditType>()
                .Property(e => e.ChargeWord)
                .IsUnicode(false);

            modelBuilder.Entity<BPSCreditType>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            

            modelBuilder.Entity<BCProject>()
               .Property(e => e.Code)
               .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            //modelBuilder.Entity<BCProject>()
            //    .Property(e => e.arname)
            //    .IsUnicode(false);

           

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Name1)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Name2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DefDeliveryAddr)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DefContactCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.TransportRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DefTransport)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.IDCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.BankAccNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DetailDiscount)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.Discount)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.CashDiscount)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DebtLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DebtAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.ChqOnHand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.ChqReturn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DefaultTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.PaymentRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.StatementRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.PicFileName)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.GroupOfDebt)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.MapCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.EarnestAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.DefaultWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.departcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.departname)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.arcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.arname)
                .IsUnicode(false);

            modelBuilder.Entity<BCAP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.Name1)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.Name2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DefDeliveryAddr)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DefContactCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DefTransport)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.BillAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.WorkAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.AccountCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.IDCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ParentCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DetailDiscount)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.Discount)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CashDiscount)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DebtLimit1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DebtLimit2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DebtLimitBal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DebtAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ChqOnHand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CreditOnHand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ChqReturn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ExcessAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DefaultTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PaymentRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.StatementRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PicFileName)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.SaleAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.HomePage)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.GroupOfDebt)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.AuthorizeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DocPicRefFile1)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DocPicRefFile2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ReceiveByDay)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ReceiveByDate)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PayBillByDay)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PayBillByDate)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep1)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep3)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep4)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep5)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep6)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep7)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep8)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep9)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.RouteStep10)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.MapCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CreditMenCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CreditMenCode2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CreditMenCode3)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PressMenCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PressMenCode2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.PressMenCode3)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.KeepMoneyMenCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.KeepMoneyMenCode2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.KeepMoneyMenCode3)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CondPayCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.GroupCreditCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.HomeCurCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.EarnestAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billcompanyname)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billrestype)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billno)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billmoo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billvillage)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billbuilding)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billfloor)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billroom)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billsoi)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billroad)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billsubdist)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billdistrict)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billprovince)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billcountry)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.billzipcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homecompanyname)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homerestype)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homeno)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homemoo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homevillage)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homebuilding)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homefloor)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homeroom)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homesoi)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homeroad)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homesubdist)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homedistrict)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homeprovince)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homecountry)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.homezipcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DefaultWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DefSaleWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.MEMBERID)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.SUMOFAMOUNT1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.SUMOFAMOUNT2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.REFFILENAME1)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.REFFILENAME2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.CREDITAMOUNTTYPE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAR>()
                .Property(e => e.LINKWORDFILE)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Name1)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Name2)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ColorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.MyGrade)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.MyClass)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.GenericCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefStkUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefSaleUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefBuyUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.OppositeUnit2)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Opposite1Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.OppositeRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.MySize)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Wide)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Long)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.High)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.VenderCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DepositCondit)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DeliveryCharge)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.InstallCharge)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ReturnRemark)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ReturnCharge)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ItemStatus)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.WTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.WaveFile)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.OrderPoint)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.StockMin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.StockMax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.StockQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.AverageCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.CostOfArea)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastBuyPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PicFileName1)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PicFileName2)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PicFileName3)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PicFileName4)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SpecFileName)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.AviFileName)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.AccGroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefBuyWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefBuyShelf)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefSaleWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefSaleShelf)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefBadWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefBadShelf)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefFGWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefFGShelf)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefRepairWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefRepairShelf)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefRawWHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefRawShelf)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Formula1)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Formula2)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Formula3)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Discount)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ReserveQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.RemainOutQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.RemainInQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.BasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceVatOut8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefFixUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DefFixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.FixQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.FixCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePriceNV1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePriceNV2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.SalePriceNV3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.AverageCostReal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.OverReceive)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ContainerCapacity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ContainerWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.CapacityUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastBuyPriceHome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastBuyCurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastAvgCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.stockqty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.stockqty2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.StockQtyWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.CustGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PublisherCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.WriterCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastSalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastSalePriceHome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LastSaleCurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Specification)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ManufactoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.AFT_remark)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.UnitWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.WeightUnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LeadTime)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.OfferedBy)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.HS_SMX_remark)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.ItemBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.PriceCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.Classfication)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.STOCKQTYSTANDARD)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.DOSTOCKQTY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LASTBUYPRICE2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LASTBUYDISCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.FORMATRUNSERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<BCITEM>()
                .Property(e => e.LASTBUYPRICE3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCProject>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            //modelBuilder.Entity<BCProject>()
            //    .Property(e => e.companyname)
            //    .IsUnicode(false);

            //modelBuilder.Entity<BCProject>()
            //    .Property(e => e.Address)
            //    .IsUnicode(false);

            //modelBuilder.Entity<BCProject>()
            //    .Property(e => e.Telephone)
            //    .IsUnicode(false);

            //modelBuilder.Entity<BCProject>()
            //    .Property(e => e.Fax)
            //    .IsUnicode(false);

            //modelBuilder.Entity<BCProject>()
            //    .Property(e => e.taxno)
            //    .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ApCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ContactCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumOfItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.AfterDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.BeforeTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ExceptTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ZeroTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.PettyCashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumCashAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumChqAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumBankAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumOfDeposit1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumOfDeposit2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumOfWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.NetDebtAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.OtherIncome)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.OtherExpense)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ExcessAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ExcessAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.BillBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ExchangeProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.Remark1)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.Remark2)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.Remark3)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.Remark4)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.Remark5)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.OwnerTransport)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.PayBillAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.RefDocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumOfWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumBaseWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.SumComWTaxCash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.APInvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.AvgTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.AvgTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.PrePayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.wtaxrate)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.sumofwtax_forshow)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICE>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.ApCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.CNQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.GRRemainQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.BalanceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.SumOfExpCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.PORefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.IRRefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.WTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.BaseWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.FactorPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCAPINVOICESUB>()
                .Property(e => e.FGREMAINQTY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.CashierCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.DiscQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.TempQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.BillQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ReturnCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Salediscword)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Salediscamount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Oldamount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.Custgroupcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.PriceCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.InvoiceType)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.ItemSetCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.CNCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.RETAILPRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.RETAILAMOUNT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.oldamount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCCreditNoteSub>()
                .Property(e => e.bals)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.DiscQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.TempQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.BillQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.Custgroupcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub1>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.ApCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.DiscQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.TempQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.BillQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCDebitNoteSub2>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.PersonCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.SumOfAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoods>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.Personcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.GRDOCNO)
                .IsUnicode(false);

            modelBuilder.Entity<BCFinishGoodsSub>()
                .Property(e => e.ISSUEREMAINQTY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.InspectNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.SumAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.SumAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.SumOfExceptTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.CANCELCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjust>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.InspectNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.AdjCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.IsProcess)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCSTKAdjustSub>()
                .Property(e => e.BARCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.SumOfAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalance>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkBalanceSub>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.IssueRefNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.Personcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.ReturnCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkIssRetSub>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.ApCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOfItemAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOldAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumTrueAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumofDiffAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumofBeforeTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOfTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOfTotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOfExceptTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOfZeroTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumOfWTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.NetDebtAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.SumExchangeProfit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.BillBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.GLFormat)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.CauseCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.BillGroup)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.RecurName)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.ConfirmCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.CancelCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.PayBillAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.AvgTaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.AvgTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefund>()
                .Property(e => e.PrePayAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.TaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.ApCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.DepartCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.DiscQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.TempQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.BillQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.DiscountWord)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.HomeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.OppositeUnit)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.OppositeQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.InvoiceNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.AllocateCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.ProjectCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.CurrencyCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.CategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.GroupCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.BrandCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 10);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.FixUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.FixUnitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.AVERAGECOST)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.SumOfCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.LotNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.LotMyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.Colorcode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.StyleCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.JobNo)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.TaxRate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.PackingRate1)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.PackingRate2)
                .HasPrecision(10, 4);

            modelBuilder.Entity<BCStkRefundSub>()
                .Property(e => e.SUMOFCOST2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.ReserveQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.RemainInQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.RemainOutQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.ReadyQtyAll)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.ReserveQtyAll)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.RemainQtyAll)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.RemainOutQtyAll)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCStkWarehouse>()
                .Property(e => e.averagecost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BCWarehouse>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<BCWarehouse>()
                .Property(e => e.CreatorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCWarehouse>()
                .Property(e => e.LastEditorCode)
                .IsUnicode(false);

            modelBuilder.Entity<BCWarehouse>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BCWarehouse>()
                .Property(e => e.MapPicFileName)
                .IsUnicode(false);

            modelBuilder.Entity<BCWarehouse>()
                .Property(e => e.UserGroup)
                .IsUnicode(false);
        }
        
    }
}
