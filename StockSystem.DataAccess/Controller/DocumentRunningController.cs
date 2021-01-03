
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public class DocumentRunningController : IDocumentRunningController
    {
        private StockContext db;//= new BCContext(Cls_SetDB.Conns);
        public DocumentRunningController(string ConnectionString)
        {
            db = new StockContext(ConnectionString);
        }

        public void Insert(Stock_DocumentRunning Items)
        {
            db.DocumentRunning.Add(Items);
        }

        public void Update(Stock_DocumentRunning Items)
        {
            var DEntity = this.GetFind(Items.Format_Id, Items.Menu_ID);
            DEntity.Prefix = Items.Prefix;
            DEntity.DocYear = Items.DocYear;
            DEntity.DocMonth = Items.DocMonth;
            DEntity.DocDay = Items.DocDay;
            DEntity.LastRunningID = Items.LastRunningID;
            DEntity.FormatString = Items.FormatString;
            DEntity.FormatDisplay = Items.FormatDisplay;
            DEntity.Description = Items.Description;
            DEntity.Active = Items.Active;
        }

        public void Delete(Stock_DocumentRunning Items)
        {
            db.DocumentRunning.Remove(Items);
        }

        public Stock_DocumentRunning GetFind(params object[] Keys)
        {
            return db.DocumentRunning.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Stock_DocumentRunning> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Menu_ID
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///FOrmat_ID
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            int FormatID = Convert.ToInt32(Spara2 == "" ? "0" : Spara2);
            var query = db.DocumentRunning.Where(c => c.Menu_ID == Spara1 && FormatID == 0 ? true : c.Format_Id == FormatID);
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCAR : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Stock_DocumentRunning> LoadAllWhereMenu(string Menu_ID)
        {
            var query = db.DocumentRunning.Where(c => c.Menu_ID == Menu_ID).ToList();
            return query;
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }


        public DateTime GetDate()
        {
            return db.Database.SqlQuery<DateTime>("SELECT GETDATE()").FirstOrDefault();
        }

        
    }
}
