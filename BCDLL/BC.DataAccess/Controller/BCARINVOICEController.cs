using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;
namespace BC.DataAccess
{
    public class BCARINVOICEController : IBCARINVOICEController
    {
        private BCContext db;//= new BCContext(Cls_SetDB.Conns);
        public BCARINVOICEController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }


        public void Insert(BCARINVOICE Items)
        {
            db.BCARINVOICE.Add(Items);
        }

        public void Update(BCARINVOICE Items)
        {
            var DEntity = this.GetFind(Items.DocNo);
            DEntity.DocNo = Items.DocNo;
            DEntity.ArCode = Items.ArCode;
            DEntity.SumOfItemAmount = Items.SumOfItemAmount;
            DEntity.DiscountWord = Items.DiscountWord;
            DEntity.AfterDiscount = Items.AfterDiscount;
            DEntity.BeforeTaxAmount = Items.BeforeTaxAmount;
            DEntity.TotalAmount = Items.TotalAmount;
            DEntity.NetDebtAmount = Items.NetDebtAmount;
            DEntity.HomeAmount = Items.HomeAmount;
            DEntity.BillBalance = Items.BillBalance;
            DEntity.ProjectCode = Items.ProjectCode;
            DEntity.BillTemporary = Items.BillTemporary;
            DEntity.PayBillAmount = Items.PayBillAmount;
            DEntity.TaxType = 0;
            DEntity.IsConfirm = 0;
            DEntity.BillType = 3;
            DEntity.DepositIncTax = 1;
            DEntity.GLStartPosting = 1;
            DEntity.GLFormat = "B04";
            DEntity.IsCancel = Items.IsCancel;
            DEntity.IsCreditNote = 0;
            DEntity.IsDebitNote = 0;
            DEntity.IsProcessOK = 0;
            DEntity.IsCompleteSave = 1;
            DEntity.IsPostGL = 0;
            DEntity.GLTransData = 0;
            DEntity.PayBillStatus = 0;
            DEntity.IsReceiveMoney = 0;
            DEntity.IsConditionSend = 0;
            DEntity.HoldingStatus = 0;
            DEntity.RefType = 0;
            DEntity.POSSTATUS = 0;
            DEntity.MyDescription = Items.MyDescription;
        }

        public void Delete(BCARINVOICE Items)
        {
            db.BCARINVOICE.Remove(Items);
        }

        public BCARINVOICE GetFind(params object[] Keys)
        {
            return db.BCARINVOICE.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCARINVOICE> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCARINVOICE.Where(c => c.DocNo.Contains(Spara1));
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

        public BCARINVOICE GetFind2(string DocNo)
        {
            return db.BCARINVOICE.Where(c => c.DocNo == DocNo).FirstOrDefault();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
