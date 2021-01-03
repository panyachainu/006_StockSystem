using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public interface I_VStock_ItemTranferSum : IController<VStock_ItemTranferSum>
    {
        IEnumerable<VStock_ItemTranferSum> LoadAllInList(List<string> ItemCode);
    }
}
