using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;
namespace BC.DataAccess
{
    public class BCChqInController : IBCChqInController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCChqInController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCChqIn Items)
        {
            db.BCChqIn.Add(Items);
        }

        public void Update(BCChqIn Items)
        {
            var DEntity = this.GetFind(Items.DocNo);
            DEntity.DocNo = Items.DocNo;
            DEntity.ArCode = Items.ArCode;
            DEntity.ReceiveDate = Items.ReceiveDate;
            DEntity.Amount = Items.Amount;
            DEntity.BankCode = Items.BankCode;
            DEntity.BankBranchCode = Items.BankBranchCode;
            DEntity.ChqNumber = Items.ChqNumber;
            DEntity.DueDate = Items.DueDate;
            DEntity.Status = 0;
            DEntity.SaveFrom = 0;
            DEntity.ChqUseStatus = 0;
            DEntity.ISCANCEL = 0;
            DEntity.ISCONFIRM = 0;
        }

        public void Delete(BCChqIn Items)
        {
            db.BCChqIn.Remove(Items);
        }

        public BCChqIn GetFind(params object[] Keys)
        {
            return db.BCChqIn.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCChqIn> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);
            throw new NotImplementedException();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCChqIn : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCChqIn GetFind2(string DocNo)
        {
            return db.BCChqIn.Where(c => c.DocNo == DocNo).FirstOrDefault();
        }


        public int GetMaxRunOrer()
        {
            if (db.BCChqIn.Count() > 0)
                return db.BCChqIn.Max(c => c.REFCHQROWORDER).Value;
            else
                return 0;
        }


        public string Name(string CodeID)
        {
            //var Item = db.BCChqIn.Where(c => c. == CodeID).FirstOrDefault();
            //if (Item != null)
            //    return Item.Name;
            //else
                return "";
        }
    }
}
