using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.DataAccess;
using BC.Models;
namespace BC.Services
{
    public class BCCreditNoteService : IDisposable
    {
        IBCCreditNoteController Db;

        public BCCreditNoteService(IBCCreditNoteController Db)
        {
            this.Db = Db;
        }
        public BCCreditNoteService(string Connstring)
            : this(new BCCreditNoteController(Connstring))
        {
        }

        public BCCreditNote Insert(BCCreditNote Item)
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
