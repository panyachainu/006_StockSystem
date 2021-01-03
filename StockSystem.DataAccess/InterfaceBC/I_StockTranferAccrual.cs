using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public interface I_StockTranferAccrual : IController<Stock_TranferAccrual>
    {
        //bool CheckUseDocNo(string DocNo);
        //IEnumerable<Stock_TranferArInvoice> LoadAllRemain(DateTime DtpStart,DateTime DtpEnd);
    }
}
