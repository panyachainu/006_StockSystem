using BC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DataAccess
{
    public interface IBCPaybillController : IController<BCPaybill>
    {
        IEnumerable LoadAll_ARName(List<string> Docnos,string SearchData);
        IEnumerable<BCPaybill> LoadAll_Selectin(List<string> Docnos);
    }
}
