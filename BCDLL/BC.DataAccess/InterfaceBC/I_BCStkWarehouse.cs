using BC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DataAccess
{
    public interface I_BCStkWarehouse : IController<BCStkWarehouse>
    {
        IEnumerable<BCStkWarehouse> LoadAllInList(List<string> ItemCode);
    }
}
