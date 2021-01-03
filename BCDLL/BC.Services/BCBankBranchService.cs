using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCBankBranchService : IDisposable
    {
        IBCBankBranchController Db;
        public BCBankBranchService(IBCBankBranchController Db)
        {
            this.Db = Db;
        }
        public BCBankBranchService(string Connstring)
            : this(new BCBankBranchController(Connstring))
        {
        }

        public IEnumerable<BCBankBranch> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
