using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.DataAccess;
using BC.Models;

namespace BC.Services
{
    public class BCWarehouseService : IDisposable
    {
        I_BCWarehouse Db;
        public BCWarehouseService(I_BCWarehouse Db)
        {
            this.Db = Db;
        }

        public BCWarehouseService(string Connstring)
            : this(new C_BCWarehouse(Connstring))//ConnectionString string ConnectionString
        {
        }

        public IEnumerable<BCWarehouse> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
