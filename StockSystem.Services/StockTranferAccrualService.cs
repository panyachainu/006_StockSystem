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
    public class StockTranferAccrualService : IDisposable
    {
        I_StockTranferAccrual Db;
        public string ErrorMessage { get; set; }

        public StockTranferAccrualService(I_StockTranferAccrual Db)
        {
            this.Db = Db;
        }

        public StockTranferAccrualService(string Connstring)
            : this(new C_StockTranferAccrual(Connstring))//ConnectionString string ConnectionString
        {
        }

        public Stock_TranferAccrual GetFind(int Rownum)
        {
            return Db.GetFind(Rownum);
        }

        public bool Insert(IEnumerable<Stock_TranferAccrual> Items)
        {
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                //option.Timeout = TimeSpan.FromSeconds(5);
                using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    foreach (Stock_TranferAccrual Item in Items)
                    {
                        Db.Insert(Item);
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

        public bool Update(IEnumerable<Stock_TranferAccrual> Items)
        {
            try
            {
                var option = new TransactionOptions();
                option.IsolationLevel = IsolationLevel.ReadCommitted;
                //option.Timeout = TimeSpan.FromSeconds(5);
                using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
                {
                    foreach (Stock_TranferAccrual Item in Items)
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


        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
