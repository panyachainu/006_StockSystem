using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
namespace BC.DataAccess
{
    public class BCConfigurationsController : IBCConfigurationsController
    {
        private BCContext db ;//= new BCContext(Cls_SetDB.Conns);
        public BCConfigurationsController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCConfigurations Items)
        {
            throw new NotImplementedException();
        }

        public void Update(BCConfigurations Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BCConfigurations Items)
        {
            throw new NotImplementedException();
        }

        public BCConfigurations GetFind(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BCConfigurations> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            //var query = db.BCConfigurations.Where(c => c.Code.Contains(Spara1));

            //return query.ToList();
            throw new NotImplementedException();
        }

        public void LogDB(string LogDb)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public BCConfigurations GetBCConfig()
        {
            return db.BCConfigurations.FirstOrDefault();
        }


        public string Name(string CodeID)
        {
            var Item = db.BCConfigurations.FirstOrDefault();
            if (Item != null)
                return Item.CompanyName;
            else
                return "";
        }
    }
}
