using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockSystem.Models;
using StockSystem.DataAccess;

namespace StockSystem.Services
{
    public class VStockItemTranferSumService:IDisposable
    {
        I_VStock_ItemTranferSum Db;
        public VStockItemTranferSumService(I_VStock_ItemTranferSum Db)
        {
            this.Db = Db;
        }

        public VStockItemTranferSumService(string Connstring)
            : this(new C_VStock_ItemTranferSum(Connstring))//ConnectionString string ConnectionString
        {
        }

        public VStock_ItemTranferSum GetFind(string Itemcode)
        {
            return Db.GetFind(Itemcode);
        }

        public IEnumerable<VStock_ItemTranferSum> LoadAll()
        {
            return Db.LoadAll(null, null, null, null, null);
        }

        public IEnumerable<VStock_ItemTranferSum> LoadAllInList(List<string> ItemCode)
        {
            return Db.LoadAllInList(ItemCode);
        }
                
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
