using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;

namespace BC.DataAccess
{
    public interface IBCARINVOICEController : IController<BCARINVOICE>
    {
        BCARINVOICE GetFind2(string DocNo);
    }
}
