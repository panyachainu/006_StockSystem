using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
namespace BC.DataAccess
{
    public interface IBCInvCreditNoteController : IController<BCInvCreditNote>
    {
        BCInvCreditNote GetFind2(string DocNo);
    }
}
