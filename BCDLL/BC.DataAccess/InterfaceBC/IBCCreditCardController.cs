using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
namespace BC.DataAccess
{
    public interface IBCCreditCardController : IController<BCCreditCard>
    {
        BCCreditCard GetFind2(string Docno);
    }
}
