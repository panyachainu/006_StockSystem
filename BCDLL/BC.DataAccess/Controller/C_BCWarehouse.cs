using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;

namespace BC.DataAccess
{
    public class C_BCWarehouse : I_BCWarehouse
    {
        private BCContext db;//= new BCContext(Cls_SetDB.Conns);
        public C_BCWarehouse(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCWarehouse Items)
        {
            db.BCWarehouse.Add(Items);
        }

        public void Update(BCWarehouse Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BCWarehouse Items)
        {
            db.BCWarehouse.Remove(Items);
        }

        public BCWarehouse GetFind(params object[] Keys)
        {
            return db.BCWarehouse.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCWarehouse> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            return db.BCWarehouse.OrderBy(c => c.Code).ToList();
        }

        public void LogDB(string LogDb)
        {
            throw new NotImplementedException();
        }

        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
