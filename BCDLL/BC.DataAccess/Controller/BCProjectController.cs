using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BC.Models;
using System.Diagnostics;
namespace BC.DataAccess
{
    public class BCProjectController : IBCProjectController
    {
        private BCContext db;//= new BCContext(Cls_SetDB.Conns);

        public BCProjectController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCProject Items)
        {
            throw new NotImplementedException();
        }

        public void Update(BCProject Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BCProject Items)
        {
            throw new NotImplementedException();
        }

        public BCProject GetFind(params object[] Keys)
        {
            return db.BCProject.Find(Keys);
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BCProject> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            return db.BCProject.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCProject : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }


        public string Name(string CodeID)
        {
            var Item = db.BCProject.Where(c => c.Code == CodeID).FirstOrDefault();
            if (Item != null)
                return Item.Name;
            else
                return "";
        }
    }
}
