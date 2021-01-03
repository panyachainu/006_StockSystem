using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DataAccess
{
    public class CheckConnection
    {
        private BCContext db;
        public CheckConnection(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }
        public bool DbCheckConn()
        {
            db.Database.Connection.Open();
            return true;
        }
    }
}
