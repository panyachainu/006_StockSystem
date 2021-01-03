using BC.DataAccess;
using BC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.Services
{
    public class BCPaybillService : IDisposable
    {
        IBCPaybillController Db;
        public BCPaybillService(string ConnectionString)
        {
            Db = new BCPaybillController(ConnectionString);
        }

        public BCPaybill GetFind(string Code)
        {
            return Db.GetFind(Code);
        }

        public IEnumerable LoadAll_ARName(List<string> Docnos, string SearchData)
        {
            return Db.LoadAll_ARName(Docnos,SearchData);
        }

        public IEnumerable<BCPaybill> LoadAll_Selectin(List<string> Docnos)
        {
            return Db.LoadAll_Selectin(Docnos);
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
