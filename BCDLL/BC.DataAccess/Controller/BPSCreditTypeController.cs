using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;

namespace BC.DataAccess
{
    public class BPSCreditTypeController : IBPSCreditTypeController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BPSCreditTypeController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BPSCreditType Items)
        {
            throw new NotImplementedException();
        }

        public void Update(BPSCreditType Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BPSCreditType Items)
        {
            throw new NotImplementedException();
        }

        public BPSCreditType GetFind(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BPSCreditType> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            return db.BPSCreditType.OrderBy(c => c.Code).ToList();
        }

        public void LogDB(string LogDb)
        {
            throw new NotImplementedException();
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
