using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
namespace BC.DataAccess
{
    public interface IBCCreditNoteController:IController<BCCreditNote>
    {
        BCCreditNote GetFind2(string DocNo);
    }
}
