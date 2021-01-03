using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;

namespace BC.DataAccess
{
    public class BCARDepositController : IBCARDepositController
    {
        private BCContext db;//= new BCContext(Cls_SetDB.Conns);

        public BCARDepositController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }


        public void Insert(BCARDeposit Items)
        {
            db.BCARDeposit.Add(Items);
        }

        public void Update(BCARDeposit Items)
        {
            var DEntity = this.GetFind2(Items.DocNo);
            DEntity.DocDate = Items.DocDate;
            DEntity.ArCode = Items.ArCode;
            DEntity.MyDescription = Items.MyDescription;
            DEntity.BeforeTaxAmount = Items.BeforeTaxAmount;
            DEntity.TaxAmount = Items.TaxAmount;
            DEntity.TotalAmount = Items.TotalAmount;
            DEntity.SumOfWTax = Items.SumOfWTax;
            DEntity.NetAmount = Items.NetAmount;
            DEntity.BillBalance = Items.BillBalance;
            DEntity.ChargeAmount = Items.ChargeAmount;
            DEntity.RefNo = Items.RefNo;
            DEntity.SumCashAmount = Items.SumCashAmount;
            DEntity.SumChqAmount = Items.SumChqAmount;
            DEntity.SumCreditAmount = Items.SumCreditAmount;
            DEntity.SumBankAmount = Items.SumBankAmount;
            DEntity.GLFormat = Items.GLFormat;
            DEntity.ProjectCode = Items.ProjectCode;

            DEntity.GLStartPosting = Items.GLStartPosting;
            DEntity.IsPostGL = Items.IsPostGL;
            DEntity.IsCancel = Items.IsCancel;
            DEntity.IsReturnMoney = Items.IsReturnMoney;
            DEntity.TaxType = 0;
        }

        public void Delete(BCARDeposit Items)
        {
            db.BCARDeposit.Remove(Items);
        }

        public BCARDeposit GetFind(params object[] Keys)
        {
            return db.BCARDeposit.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCARDeposit> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCARDeposit.Where(c => c.DocNo.Contains(Spara1));
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCARDeposit : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCARDeposit GetFind2(string DocNo)
        {
            return db.BCARDeposit.Where(c => c.DocNo == DocNo).FirstOrDefault();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
