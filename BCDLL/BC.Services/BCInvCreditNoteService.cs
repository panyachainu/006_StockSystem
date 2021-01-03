using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCInvCreditNoteService : IDisposable
    {
        IBCInvCreditNoteController Db;
        public BCInvCreditNoteService(IBCInvCreditNoteController Db)
        {
            this.Db = Db;
        }
        public BCInvCreditNoteService(string Connstring)
            : this(new BCInvCreditNoteController(Connstring))
        {
        }

        public BCInvCreditNote Insert(BCInvCreditNote Item)
        {
            Db.Insert(Item);
            return Item;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
