using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;

namespace BC.DataAccess
{
    public class BCCreditCardController : IBCCreditCardController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCCreditCardController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }


        public void Insert(BCCreditCard Items)
        {
            db.BCCreditCard.Add(Items);
        }

        public void Update(BCCreditCard Items)
        {
            var DEntity = this.GetFind2(Items.DocNo);
            DEntity.BankCode = Items.BankCode;
            DEntity.CreditCardNo = Items.CreditCardNo;
            DEntity.ArCode = Items.ArCode;
            DEntity.ReceiveDate = Items.ReceiveDate;
            DEntity.DueDate = Items.DueDate;
            DEntity.Status = Items.Status;
            DEntity.SaveFrom = Items.SaveFrom;
            DEntity.BankBranchCode = Items.BankBranchCode;
            DEntity.Amount = Items.Amount;
            DEntity.CreditType = Items.CreditType;
            DEntity.ConfirmNo = Items.ConfirmNo;
            DEntity.ChargeAmount = Items.ChargeAmount;
        }

        public void Delete(BCCreditCard Items)
        {
            db.BCCreditCard.Remove(Items);
        }

        public BCCreditCard GetFind(params object[] Keys)
        {
            return db.BCCreditCard.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCCreditCard> LoadAll(object para1, object para2, object para3, object para4, object para5)
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

        public BCCreditCard GetFind2(string Docno)
        {
            return db.BCCreditCard.Where(c => c.DocNo == Docno).FirstOrDefault();
        }


        public string Name(string CodeID)
        {
            //var Item = db.BCCreditCard.Where(c => c.code == CodeID).FirstOrDefault();
            //if (Item != null)
            //    return Item.Fes_Name;
            //else
                return "";
        }
    }
}
