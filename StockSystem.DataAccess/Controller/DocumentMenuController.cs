
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public class DocumentMenuController : IDocumentMenuController
    {
        private StockContext db;//= new BCContext(Cls_SetDB.Conns);
        public DocumentMenuController(string ConnectionString)
        {
            db = new StockContext(ConnectionString);
        }

        public void Insert(Stock_DocumentMenu Items)
        {
            db.DocumentMenu.Add(Items);
        }

        public void Update(Stock_DocumentMenu Items)
        {
            var DEatity = this.GetFind(Items.Menu_ID);
            DEatity.Description = Items.Description;
        }

        public void Delete(Stock_DocumentMenu Items)
        {
            db.DocumentMenu.Remove(Items);
        }

        public Stock_DocumentMenu GetFind(params object[] Keys)
        {
            return db.DocumentMenu.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Stock_DocumentMenu> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.DocumentMenu.ToList();
            return query;
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCAR : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
