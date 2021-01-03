using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Collections;

namespace BC.DataAccess
{
    public interface IBCARINVOICESUBController : IController<BCARINVOICESUB>
    {
        BCARINVOICESUB GetFind2(string DocNo);
        IEnumerable<BCARINVOICESUB> LoadAllForTranfer(params string[] Condition);
        IEnumerable LoadAllForTranferShow(params object[] Condition);
        IEnumerable<BCARINVOICESUB> LoadAllForTranferByDate(DateTime DtpStart, DateTime DtpEnd, bool UseDate, params string[] Condition);
    }
}
