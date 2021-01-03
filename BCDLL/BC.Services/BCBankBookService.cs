using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCBankBookService : IDisposable
    {
        IBCBankBookController Db;
        public BCBankBookService(IBCBankBookController Db)
        {
            this.Db = Db;
        }
        public BCBankBookService(string Connstring)
            : this(new BCBankBookController(Connstring))
        {
        }

        public IEnumerable<BCBankBook> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
