using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCSaleOrderService : IDisposable
    {
        IBCSaleOrderController Db;
        public BCSaleOrderService(IBCSaleOrderController Db)
        {
            this.Db = Db;
        }
        public BCSaleOrderService(string Connstring)
            : this(new BCSaleOrderController(Connstring))
        {
        }

        public BCSaleOrder GetFind(string DocNo)
        {
            return Db.GetFind(DocNo);
        }
        public BCSaleOrder Insert(BCSaleOrder Item)
        {
            Db.Insert(Item);
            return Item;
        }
        public BCSaleOrder Update(BCSaleOrder Item)
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
