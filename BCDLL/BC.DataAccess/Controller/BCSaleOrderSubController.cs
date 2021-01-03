using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;
namespace BC.DataAccess
{
    public class BCSaleOrderSubController : IBCSaleOrderSubController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCSaleOrderSubController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCSaleOrderSub Items)
        {
            db.BCSaleOrderSub.Add(Items);
        }

        public void Update(BCSaleOrderSub Items)
        {
            var DEntity = this.GetFind2(Items.DocNo);
            DEntity.ItemCode = Items.ItemCode;
            DEntity.DocDate = Items.DocDate;
            DEntity.ArCode = Items.ArCode;
            DEntity.Qty = Items.Qty;
            DEntity.RemainQty = Items.RemainQty;
            DEntity.DeliveryQty = Items.DeliveryQty;
            DEntity.Price = Items.Price;
            DEntity.DiscountWord = Items.DiscountWord;
            DEntity.DiscountAmount = Items.DiscountAmount;
            DEntity.Amount = Items.Amount;
            DEntity.NetAmount = Items.NetAmount;
            DEntity.HomeAmount = Items.HomeAmount;
            DEntity.UnitCode = Items.UnitCode;
            DEntity.SOStatus = Items.SOStatus;
            DEntity.RefType = Items.RefType;
            DEntity.ProjectCode = Items.ProjectCode;
            DEntity.ItemType = Items.ItemType;
            DEntity.IsCancel = Items.IsCancel;
            DEntity.LineNumber = Items.LineNumber;
            DEntity.IsProcess = Items.IsProcess;
            DEntity.TaxType = 0;
        }

        public void Delete(BCSaleOrderSub Items)
        {
            db.BCSaleOrderSub.Remove(Items);
        }

        public BCSaleOrderSub GetFind(params object[] Keys)
        {
            return db.BCSaleOrderSub.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCSaleOrderSub> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCSaleOrderSub.Where(c => c.DocNo == Spara1);
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCSaleOrderSub : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCSaleOrderSub GetFind2(string DocNo)
        {
            return db.BCSaleOrderSub.Where(c => c.DocNo == DocNo).FirstOrDefault();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
