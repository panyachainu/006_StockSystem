using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BC.DataAccess;

namespace BC.Services
{
    public class CheckConnectionService
    {
        //CheckConnection Db = new CheckConnection(;
        public bool CheckOpen(string ConnectionString)
        {
            CheckConnection Db = new CheckConnection(ConnectionString);
            return Db.DbCheckConn();
        }
    }
}
