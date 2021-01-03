using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;

namespace BC.DataAccess
{
    public class BCInvCreditNoteController : IBCInvCreditNoteController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCInvCreditNoteController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCInvCreditNote Items)
        {
            db.BCInvCreditNote.Add(Items);
        }

        public void Update(BCInvCreditNote Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BCInvCreditNote Items)
        {
            db.BCInvCreditNote.Remove(Items);
        }

        public BCInvCreditNote GetFind(params object[] Keys)
        {
            return db.BCInvCreditNote.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCInvCreditNote> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCInvCreditNote;
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCInvCreditNote : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCInvCreditNote GetFind2(string DocNo)
        {
            throw new NotImplementedException();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }
    }
}
