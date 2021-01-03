using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockSystem.DataAccess
{
    public interface IDocumentFormatController : IController<Stock_DocumentFormat>
    {
        bool ValidateFormat(Stock_DocumentFormat Item);
    }
}
