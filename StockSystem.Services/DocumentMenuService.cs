using StockSystem.DataAccess;
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace StockSystem.Services
{
    public class DocumentMenuService : IDisposable
    {
        IDocumentMenuController Db;
        public DocumentMenuService(IDocumentMenuController Db)
        {
            this.Db = Db;
        }
        public DocumentMenuService(string ConnString)
            : this(new DocumentMenuController(ConnString))//ConnectionString string ConnectionString
        {
        }

        public IEnumerable<Stock_DocumentMenu> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public Stock_DocumentMenu Insert(Stock_DocumentMenu Item)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = IsolationLevel.ReadCommitted;
            //option.Timeout = TimeSpan.FromSeconds(5);
            using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
            {
                Db.Insert(Item);
                Db.SaveChanges();
                tx.Complete();
                return Item;
                
            }
        }
        public Stock_DocumentMenu Update(Stock_DocumentMenu Item)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = IsolationLevel.ReadCommitted;
            //option.Timeout = TimeSpan.FromSeconds(5);
            using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
            {
                Db.Update(Item);
                Db.SaveChanges();
                tx.Complete();
                return Item;
            }
        }
        public Stock_DocumentMenu Delete(Stock_DocumentMenu Item)
        {
            var option = new TransactionOptions();
            option.IsolationLevel = IsolationLevel.ReadCommitted;
            //option.Timeout = TimeSpan.FromSeconds(5);
            using (var tx = new TransactionScope(TransactionScopeOption.Required, option))
            {
                Db.Delete(Item);
                Db.SaveChanges();
                tx.Complete();
                return Item;
            }
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
