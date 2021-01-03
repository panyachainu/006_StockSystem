using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;

namespace BC.DataAccess
{
    public class BCRecmoneyController : IBCRecmoneyController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCRecmoneyController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCRecMoney Items)
        {
            db.BCRecMoney.Add(Items);
        }

        public void Update(BCRecMoney Items)
        {
            var DEntity = this.GetFind(Items.ROWORDER);
            DEntity.DocDate = Items.DocDate;
            DEntity.ArCode = Items.ArCode;
            DEntity.PayAmount = Items.PayAmount;
            DEntity.HomeAmount = Items.HomeAmount == null ? 0 : Items.HomeAmount;
            DEntity.ChqTotalAmount = Items.ChqTotalAmount == null ? 0 : Items.ChqTotalAmount;
            DEntity.PaymentType = Items.PaymentType;
            DEntity.SaveFrom = Items.SaveFrom;
            DEntity.RefNo = Items.RefNo;
            DEntity.BankCode = Items.BankCode;
            DEntity.ProjectCode = Items.ProjectCode;
            DEntity.BankBranchCode = Items.BankBranchCode;
            DEntity.MyDescription = Items.MyDescription;
            DEntity.RefDate = Items.RefDate;
            DEntity.CreditType = Items.CreditType;
            DEntity.ChargeAmount = Items.ChargeAmount;
            DEntity.ChargeWord = Items.ChargeWord;
            DEntity.ConfirmNo = Items.ConfirmNo;
            DEntity.LineNumber = Items.LineNumber;

            //DEntity.ChqTotalAmount = Items.ChqTotalAmount;
            //DEntity.RefDate = Items.RefDate;
            //DEntity.RefNo = Items.RefNo;
            //DEntity.BankCode = Items.BankCode;
            //DEntity.BankBranchCode = Items.BankBranchCode;
            DEntity.PayChqState = Items.PayChqState;
            DEntity.TransBankDate = Items.TransBankDate;

        }

        public void Delete(BCRecMoney Items)
        {
            db.BCRecMoney.Remove(Items);
        }

        public BCRecMoney GetFind(params object[] Keys)
        {
            return db.BCRecMoney.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCRecMoney> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCRecMoney.Where(c => c.DocNo.Contains(Spara1));
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCRecMoney : {0}", LogDb);
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
