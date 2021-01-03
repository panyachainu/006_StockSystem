using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockSystem.DataAccess
{
    public interface IDocumentRunningController : IController<Stock_DocumentRunning>
    {
        IEnumerable<Stock_DocumentRunning> LoadAllWhereMenu(string Menu_ID);
        DateTime GetDate();
    }
}
