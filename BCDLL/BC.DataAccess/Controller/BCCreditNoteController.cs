using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;
namespace BC.DataAccess
{
    public class BCCreditNoteController : IBCCreditNoteController
    {
        private BCContext db;//= new BCContext(Cls_SetDB.Conns);
        public BCCreditNoteController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCCreditNote Items)
        {
            db.BCCreditNote.Add(Items);
        }

        public void Update(BCCreditNote Items)
        {
            throw new NotImplementedException();
            //            DocNo
            //DocDate
            //ArCode
            //MyDescription
            //SumOldAmount
            //SumofDiffAmount
            //SumofBeforeTax
            //NetDebtAmount
            //GLStartPosting
            //GLFormat
            //IsProcessOK
            //IsCompleteSave
            //ReturnMoney
            //ProjectCode
            //IsCompleteSave
            //IsCNDeposit

        }

        public void Delete(BCCreditNote Items)
        {
            db.BCCreditNote.Remove(Items);
        }

        public BCCreditNote GetFind(params object[] Keys)
        {
            return db.BCCreditNote.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCCreditNote> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCCreditNote.Where(c => c.DocNo.Contains(Spara1));
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCCreditNote : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCCreditNote GetFind2(string DocNo)
        {
            throw new NotImplementedException();
        }


        public string Name(string CodeID)
        {
            return "";
        }
    }
}
