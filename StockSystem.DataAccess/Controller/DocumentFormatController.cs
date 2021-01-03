
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public class DocumentFormatController : IDocumentFormatController
    {
        //private BCContext db = new BCContext(Cls_SetDB.Conns);
        private StockContext db;//= new BCContext(Cls_SetDB.Conns);
        public DocumentFormatController(string ConnectionString)
        {
            db = new StockContext(ConnectionString);
        }

        public void Insert(Stock_DocumentFormat Items)
        {
            db.DocumentFormat.Add(Items);
        }

        public void Update(Stock_DocumentFormat Items)
        {
            var DEntity = this.GetFind(Items.Format_Id, Items.Menu_ID);
            DEntity.Running_Len = Items.Running_Len;
            DEntity.Prefix_Enable = Items.Prefix_Enable;
            DEntity.Prefix = Items.Prefix;
            DEntity.Year_Enable = Items.Year_Enable;
            DEntity.Year_Len = Items.Year_Len;
            DEntity.Month_Enable = Items.Month_Enable;
            DEntity.Day_Enable = Items.Day_Enable;
            DEntity.Description = Items.Description;
        }

        public void Delete(Stock_DocumentFormat Items)
        {
            db.DocumentFormat.Remove(Items);
        }

        public Stock_DocumentFormat GetFind(params object[] Keys)
        {
            return db.DocumentFormat.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Stock_DocumentFormat> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);/// Menu_ID
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.DocumentFormat.Where(c => c.Menu_ID == Spara1);
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

        public bool ValidateFormat(Stock_DocumentFormat Item)
        {
            var query = db.DocumentFormat.Where(c => c.Running_Len == Item.Running_Len &&
                c.Prefix_Enable == Item.Prefix_Enable && c.Prefix == Item.Prefix &&
                c.Year_Enable == Item.Year_Enable && c.Year_Len == Item.Year_Len &&
                c.Month_Enable == Item.Month_Enable && c.Day_Enable == Item.Day_Enable && c.Description == Item.Description).ToList();

            if (query.Count > 0)
                return false;
            else
                return true;
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
