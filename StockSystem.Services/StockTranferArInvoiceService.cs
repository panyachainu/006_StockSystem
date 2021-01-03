using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.Models;
using StockSystem.DataAccess;
using System.Transactions;

namespace StockSystem.Services
{
    public class StockTranferArInvoiceService : IDisposable
    {
        I_StockTranferArInvoice Db;
        IDocumentRunningController Db_Run;
        public string ErrorMessage { get; set; }

        public StockTranferArInvoiceService(I_StockTranferArInvoice Db, IDocumentRunningController Db_Run)
        {
            this.Db = Db;
            this.Db_Run = Db_Run;
        }

        public StockTranferArInvoiceService(string Connstring)
            : this(new C_StockTranferArInvoice(Connstring), new DocumentRunningController(Connstring))//ConnectionString string ConnectionString
        {
        }

        public Stock_TranferArInvoice GetFind(int Rownum)
        {
            return Db.GetFind(Rownum);
        }

        public bool CheckUseDocNo(string DocNo)
        {
            return Db.CheckUseDocNo(DocNo);
        }

        public bool Insert(IEnumerable<Stock_TranferArInvoice> Items, Stock_DocumentRunning ItemRun)
        {
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                //option.Timeout = TimeSpan.FromSeconds(5);
                using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    ItemRun.IncreaseNextNumber();

                    foreach (Stock_TranferArInvoice Item in Items)
                    {
                        Db.Insert(Item);
                        Db.SaveChanges();
                    }
                    Db_Run.Update(ItemRun);
                    Db_Run.SaveChanges();
                    tx.Complete();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool Update(IEnumerable<Stock_TranferArInvoice> Items)
        {
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                //option.Timeout = TimeSpan.FromSeconds(5);
                using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    foreach (Stock_TranferArInvoice Item in Items)
                    {
                        Db.Update(Item);
                        Db.SaveChanges();
                    }
                    tx.Complete();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public IEnumerable<Stock_TranferArInvoice> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public IEnumerable<Stock_TranferArInvoice> LoadAllRemain(DateTime DtpStart, DateTime DtpEnd, bool UseDate)
        {
            return Db.LoadAllRemain(DtpStart, DtpEnd, UseDate);
        }

        public IEnumerable<Stock_TranferArInvoice> LoadAll(DateTime DtpStart, DateTime DtpEnd, bool UseDate, List<int> Status)
        {
            return Db.LoadAll(DtpStart, DtpEnd, UseDate, Status);
        }

        public IEnumerable<Stock_TranferArInvoice> LoadByTranDoc(string Tran_DocNo)
        {
            return Db.LoadByTranDoc(Tran_DocNo);
        }

        public void Dispose()
        {
            Db.Dispose();
            Db_Run.Dispose();
        }

        //public IEnumerable<Stock_TranferArInvoice> Fn_LoadInMultiWhere(this IEnumerable<Stock_TranferArInvoice> source, Func<Stock_TranferArInvoice, bool> predicate)
        //{
        //    return source.Where(predicate)
        //        .ToList();
        //} 
    }
}
