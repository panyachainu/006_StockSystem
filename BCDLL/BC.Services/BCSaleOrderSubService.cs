using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCSaleOrderSubService : IDisposable
    {
        IBCSaleOrderSubController Db;
        public BCSaleOrderSubService(IBCSaleOrderSubController Db)
        {
            this.Db = Db;
        }
        public BCSaleOrderSubService(string Connstring)
            : this(new BCSaleOrderSubController(Connstring))
        {
        }
        public BCSaleOrderSub GetFind(int ROWORDER)
        {
            return Db.GetFind(ROWORDER);
        }
        public BCSaleOrderSub Insert(BCSaleOrderSub Item)
        {
            Db.Insert(Item);
            return Item;
        }
        public BCSaleOrderSub Update(BCSaleOrderSub Item)
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
