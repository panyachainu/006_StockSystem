using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.Models;

using System.ComponentModel.DataAnnotations.Schema;
namespace StockSystem.DataAccess
{
    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class StockContext : DbContext
    {
        public StockContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Stock_TranferArInvoice> Stock_TranferArInvoice { get; set; }
        public virtual DbSet<VStock_ItemTranferSum> VStock_ItemTranferSum { get; set; }
        public virtual DbSet<Stock_DocumentFormat> DocumentFormat { get; set; }
        public virtual DbSet<Stock_DocumentMenu> DocumentMenu { get; set; }
        public virtual DbSet<Stock_DocumentRunning> DocumentRunning { get; set; }
        public virtual DbSet<Stock_TranferAccrual> Stock_TranferAccrual { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.QtyActual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.QtyRemain)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_Attribute01)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_Attribute02)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_Attribute03)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_Attribute04)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_Attribute05)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferArInvoice>()
                .Property(e => e.Tran_UpdateBy)
                .IsUnicode(false);

            modelBuilder.Entity<VStock_ItemTranferSum>()
               .Property(e => e.ItemCode)
               .IsUnicode(false);

            modelBuilder.Entity<VStock_ItemTranferSum>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VStock_ItemTranferSum>()
                .Property(e => e.QtyActual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VStock_ItemTranferSum>()
                .Property(e => e.QtyRemain)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_DocumentFormat>()
                .Property(e => e.Menu_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentFormat>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentFormat>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentFormat>()
                .HasOptional(e => e.Stock_DocumentRunning)
                .WithRequired(e => e.Stock_DocumentFormat)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Stock_DocumentMenu>()
                .Property(e => e.Menu_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentMenu>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentRunning>()
                .Property(e => e.Menu_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentRunning>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentRunning>()
                .Property(e => e.FormatString)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentRunning>()
                .Property(e => e.FormatDisplay)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_DocumentRunning>()
                .Property(e => e.Description)
                .IsUnicode(false);
            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.DocNo)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.ArCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.SaleCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.MyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.ShelfCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.QtyActual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.QtyRemain)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.UnitCode)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_Attribute01)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_Attribute02)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_Attribute03)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_Attribute04)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_Attribute05)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_CreateBy)
                .IsUnicode(false);

            modelBuilder.Entity<Stock_TranferAccrual>()
                .Property(e => e.Tran_UpdateBy)
                .IsUnicode(false);

           
        }
        
    }
}
