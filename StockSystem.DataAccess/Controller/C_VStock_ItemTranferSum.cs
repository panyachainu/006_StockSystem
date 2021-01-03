using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.Models;

namespace StockSystem.DataAccess
{
    public class C_VStock_ItemTranferSum : I_VStock_ItemTranferSum
    {
        private StockContext db;//= new BCContext(Cls_SetDB.Conns);
        public C_VStock_ItemTranferSum(string ConnectionString)
        {
            db = new StockContext(ConnectionString);
        }

        public void Insert(VStock_ItemTranferSum Items)
        {
            throw new NotImplementedException();
        }

        public void Update(VStock_ItemTranferSum Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(VStock_ItemTranferSum Items)
        {
            throw new NotImplementedException();
        }

        public VStock_ItemTranferSum GetFind(params object[] Keys)
        {
            string ItemCode = (string)Keys[0];
            return db.VStock_ItemTranferSum.Where(c => c.ItemCode.Equals(ItemCode)).FirstOrDefault();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VStock_ItemTranferSum> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            return db.VStock_ItemTranferSum.ToList();
        }

        public IEnumerable<VStock_ItemTranferSum> LoadAllInList(List<string> ItemCode)
        {
            var qry = from c in db.VStock_ItemTranferSum
                      where ItemCode.Equals(c.ItemCode)
                      select c;

            return qry.ToList();
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
