using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Transactions;
using StockSystem.Models;
using StockSystem.DataAccess;
namespace StockSystem.Services
{
    public class DocumentFormatService : IDisposable
    {
        IDocumentFormatController Db;
        IDocumentRunningController Db_Run;
        public DocumentFormatService(IDocumentFormatController Db, IDocumentRunningController Db_Run)
        {
            this.Db_Run = Db_Run;
            this.Db = Db;
        }
        public DocumentFormatService(string ConnString)//string ConnectionString
            : this(new DocumentFormatController(ConnString), new DocumentRunningController(ConnString))//ConnectionString
        {
        }


        public Stock_DocumentFormat GetFind(int Format_ID, string Menu_ID)
        {
            return Db.GetFind(Format_ID, Menu_ID);
        }

        public int Delete(int Format_ID, string Menu_ID)
        {
            var Item = this.GetFind(Format_ID, Menu_ID);
            Db.Delete(Item);
            return Db.SaveChanges();
        }
        public bool ValidateFormat(Stock_DocumentFormat Item)
        {
            return Db.ValidateFormat(Item);
        }
        public Stock_DocumentFormat Insert(Stock_DocumentFormat Item, Stock_DocumentRunning itemR)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = IsolationLevel.ReadCommitted;
            //option.Timeout = TimeSpan.FromSeconds(5);
            using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
            {
                Db.Insert(Item);
                Db.SaveChanges();

                itemR.Format_Id = Item.Format_Id;
                itemR.Menu_ID = Item.Menu_ID;
                Db_Run.Insert(itemR);
                Db_Run.SaveChanges();
                tx.Complete();
                return Item;
            }
            
        }

        public Stock_DocumentFormat Update(Stock_DocumentFormat Item, Stock_DocumentRunning ItemR)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = IsolationLevel.ReadCommitted;
            //option.Timeout = TimeSpan.FromSeconds(5);
            using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
            {
                Db.Update(Item);
                Db.SaveChanges();

                Db_Run.Update(ItemR);
                Db_Run.SaveChanges();

                tx.Complete();
                return Item;
            }
           
        }
        public IEnumerable<Stock_DocumentFormat> LoadAll(string Menu_ID)
        {
            return Db.LoadAll(Menu_ID, null, null, null, null);
        }

        public void Dispose()
        {
            Db.Dispose();
            Db_Run.Dispose();
        }
    }
}
