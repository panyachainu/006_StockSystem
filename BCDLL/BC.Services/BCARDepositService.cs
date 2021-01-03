using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCARDepositService : IDisposable
    {
        IBCARDepositController Db;
        public BCARDepositService(IBCARDepositController Db)
        {
            this.Db = Db;
        }
        public BCARDepositService(string Connstring)
            : this(new BCARDepositController(Connstring))
        {
        }
        public BCARDeposit GetFind(string DocNo)
        {
            return Db.GetFind(DocNo);
        }
        public BCARDeposit Insert(BCARDeposit Item)
        {
            Db.Insert(Item);
            return Item;
        }
        public BCARDeposit Update(BCARDeposit Item)
        {
            Db.Update(Item);
            return Item;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
