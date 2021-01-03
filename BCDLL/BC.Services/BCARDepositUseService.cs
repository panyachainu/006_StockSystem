using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCARDepositUseService : IDisposable
    {
        IBCARDepositUseController Db;
        public BCARDepositUseService(IBCARDepositUseController Db)
        {
            this.Db = Db;
        }
        public BCARDepositUseService(string Connstring)
            : this(new BCARDepositUseController(Connstring))
        {
        }
        public BCARDepositUse GetFind(string DocNo, string DepositNo)
        {
            return Db.GetFind(DocNo, DepositNo);
        }
        public BCARDepositUse Insert(BCARDepositUse Item)
        {
            Db.Insert(Item);
            return Item;
        }
        public BCARDepositUse Update(BCARDepositUse Item)
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
