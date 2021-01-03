using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCSaleService : IDisposable
    {
        IBCSaleController Db;
        public BCSaleService(IBCSaleController Db)
        {
            this.Db = Db;
        }
        public BCSaleService(string Connstring)
            : this(new BCSaleController(Connstring))
        {
        }

        public IEnumerable<BCSale> LoadAll()
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
