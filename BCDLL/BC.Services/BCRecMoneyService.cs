using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCRecMoneyService : IDisposable
    {
        IBCRecmoneyController Db;

        public BCRecMoneyService(IBCRecmoneyController Db)
        {
            this.Db = Db;
        }
        public BCRecMoneyService(string Connstring)
            : this(new BCRecmoneyController(Connstring))
        {
        }
        public BCRecMoney GetFind(int ROWORDER)
        {
            return Db.GetFind(ROWORDER);
        }
        public IEnumerable<BCRecMoney> LoadAll(string DocCode)
        {
            return Db.LoadAll(DocCode, null, null, null, null);
        }
        public BCRecMoney Insert(BCRecMoney Item)
        {
            Db.Insert(Item);
            return Item;
        }
        public BCRecMoney Update(BCRecMoney Item)
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
