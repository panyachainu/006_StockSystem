using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;

namespace BC.DataAccess
{
    public interface IBCChqInController : IController<BCChqIn>
    {
        BCChqIn GetFind2(string DocNo);
        int GetMaxRunOrer();
    }
}
