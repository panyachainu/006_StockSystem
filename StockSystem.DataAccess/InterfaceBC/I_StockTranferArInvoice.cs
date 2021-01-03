using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public interface I_StockTranferArInvoice : IController<Stock_TranferArInvoice>
    {
        bool CheckUseDocNo(string DocNo);
        IEnumerable<Stock_TranferArInvoice> LoadAllRemain(DateTime DtpStart,DateTime DtpEnd,bool UseDate);
        IEnumerable<Stock_TranferArInvoice> LoadAll(DateTime DtpStart, DateTime DtpEnd, bool UseDate,List<int> Status);
        IEnumerable<Stock_TranferArInvoice> LoadByTranDoc(string Tran_DocNo);
    }
}
