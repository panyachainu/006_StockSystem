using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BPSCreditTypeService : IDisposable
    {
        IBPSCreditTypeController Db;
        public BPSCreditTypeService(IBPSCreditTypeController Db)
        {
            this.Db = Db;
        }
        public BPSCreditTypeService(string Connstring)
            : this(new BPSCreditTypeController(Connstring))
        {
        }
        
        public IEnumerable<BPSCreditType> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
