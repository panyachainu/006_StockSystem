using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCStkWarehouseService:IDisposable
    {
        I_BCStkWarehouse Db;
        public BCStkWarehouseService(I_BCStkWarehouse Db)
        {
            this.Db = Db;
        }

        public BCStkWarehouseService(string Connstring)
            : this(new C_BCStkWarehouse(Connstring))//ConnectionString string ConnectionString
        {
        }

        public IEnumerable<BCStkWarehouse> LoadAllInList(List<string> ItemCode)
        {
            return Db.LoadAllInList(ItemCode);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
