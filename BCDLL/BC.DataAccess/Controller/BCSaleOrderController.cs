using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;

namespace BC.DataAccess
{
    public class BCSaleOrderController : IBCSaleOrderController
    {
        private BCContext db;// = new BCContext(Cls_SetDB.Conns);
        public BCSaleOrderController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCSaleOrder Items)
        {
            db.BCSaleOrder.Add(Items);
        }

        public void Update(BCSaleOrder Items)
        {
            var DEntity = this.GetFind2(Items.DocNo);
            DEntity.DocDate = Items.DocDate;
            DEntity.BillType = Items.BillType;
            DEntity.ArCode = Items.ArCode;
            DEntity.IsConfirm = Items.IsConfirm;
            DEntity.BillStatus = Items.BillStatus;
            DEntity.SOStatus = Items.SOStatus;
            DEntity.SumOfItemAmount = Items.SumOfItemAmount;
            DEntity.DiscountWord = Items.DiscountWord;
            DEntity.DiscountAmount = Items.DiscountAmount;
            DEntity.AfterDiscount = Items.AfterDiscount;
            DEntity.BeforeTaxAmount = Items.BeforeTaxAmount;
            DEntity.TaxAmount = Items.TaxAmount;
            DEntity.TotalAmount = Items.TotalAmount;
            DEntity.NetAmount = Items.NetAmount;
            DEntity.IsCancel = Items.IsCancel;
            DEntity.IsProcessOK = Items.IsProcessOK;
            DEntity.IsCompleteSave = Items.IsCompleteSave;
            DEntity.ProjectCode = Items.ProjectCode;
            DEntity.TaxType = 0;
        }

        public void Delete(BCSaleOrder Items)
        {
            db.BCSaleOrder.Remove(Items);
        }

        public BCSaleOrder GetFind(params object[] Keys)
        {
            return db.BCSaleOrder.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCSaleOrder> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCSaleOrder.Where(c => c.DocNo.Contains(Spara1));
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCSaleOrder : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCSaleOrder GetFind2(string DocNo)
        {
            return db.BCSaleOrder.Where(c => c.DocNo == DocNo).FirstOrDefault();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
