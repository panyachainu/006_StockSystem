using BC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DataAccess
{
    public class BCarController : IBCarController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCarController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCAR Items)
        {
            db.BCAR.Add(Items);
        }

        public void Update(BCAR Items)
        {
            var DEntity = this.GetFind(Items.Code);
            DEntity.Name1 = Items.Name1;
            DEntity.BirthDay = Items.BirthDay;
            DEntity.CustAge = Items.CustAge;
            DEntity.IDCardNo = Items.IDCardNo;
            DEntity.BillAddress = Items.BillAddress;
            DEntity.Telephone = Items.Telephone;
            DEntity.Fax = Items.Fax;
            DEntity.EmailAddress = Items.EmailAddress;
            //throw new NotImplementedException();
        }

        public void Delete(BCAR Items)
        {
            db.BCAR.Remove(Items);
        }

        public BCAR GetFind(params object[] Keys)
        {
            return db.BCAR.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCAR> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCAR.Where(c => c.Code.Contains(Spara1)||c.Name1.Contains(Spara1));

            return query.ToList();
        }
        public IEnumerable<BCAR> LoadBCToContract(object para1, object para2, object para3, object para4, object para5)
        {
            //String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            //String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            //String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            //String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            //String Spara5 = Convert.ToString(para5 == null ? "" : para5);
            //var query = from bc in db.BCAR
            //            where (!db.Contract_Customer.Select(c=>c.Code).Contains(bc.Code))
            //            select bc;
            //return query.ToList();
            return null;
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
            var Item = db.BCAR.Where(c => c.Code == CodeID).FirstOrDefault();
            if (Item != null)
                return Item.Name1;
            else
                return "";
        }
    }
}
