using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BcArInvoiceSubService : IDisposable
    {
        IBCARINVOICESUBController Db;
        public BcArInvoiceSubService(IBCARINVOICESUBController Db)
        {
            this.Db = Db;
        }
        public BcArInvoiceSubService(string Connstring)
            : this(new BCARINVOICESUBController(Connstring))
        {
        }

        public IEnumerable<BCARINVOICESUB> LoadAllForTranfer(string[] whcode)
        {
            return Db.LoadAllForTranfer(whcode);
        }

        public IEnumerable<BCARINVOICESUB> LoadAllForTranferByDate(DateTime DtpStart, DateTime DtpEnd, bool UseDate, string[] whCode)
        {
            return Db.LoadAllForTranferByDate(DtpStart, DtpEnd, UseDate, whCode);
        }

        public System.Collections.IEnumerable LoadAllForTranferShow(string whcode)
        {
            return Db.LoadAllForTranferShow(whcode);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
