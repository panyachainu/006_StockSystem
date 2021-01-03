using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCProjectService : IDisposable
    {
        IBCProjectController Db;

        public BCProjectService(IBCProjectController Db)
        {
            this.Db = Db;
        }

        public BCProjectService(string Connstring)
            : this(new BCProjectController(Connstring))
        {
        }

        public IEnumerable<BCProject> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }
        public string Name(string CodeID)
        {
            return Db.Name(CodeID);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
