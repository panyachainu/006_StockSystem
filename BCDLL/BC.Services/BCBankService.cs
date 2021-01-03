using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCBankService : IDisposable
    {
        IBCBankController Db;
        public BCBankService(IBCBankController Db)
        {
            this.Db = Db;
        }

        public BCBankService(string Connstring)
            : this(new BCBankController(Connstring))
        {
        }

        public IEnumerable<BCBank> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
