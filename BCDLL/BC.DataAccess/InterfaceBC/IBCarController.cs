using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BC.Models;

namespace BC.DataAccess
{
    public interface IBCarController : IController<BCAR>
    {
        IEnumerable<BCAR> LoadBCToContract(object para1, object para2, object para3, object para4, object para5);
    }
}
