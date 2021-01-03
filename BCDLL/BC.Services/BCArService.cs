using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BC.Models;
using BC.DataAccess;

namespace BC.Services
{
    public class BCArService:IDisposable
    {
        IBCarController Db;
        public BCArService(IBCarController Db)
        {
            this.Db = Db;
        }

        public BCArService(string Connstring)
            : this(new BCarController(Connstring))//ConnectionString string ConnectionString
        {
        }
        public BCAR GetFind(string Code)
        {
            return Db.GetFind(Code);
        }
        public IEnumerable<BCAR> LoadAll(string CodeandName)
        {
            return Db.LoadAll(CodeandName, null, null, null, null);
        }

        public string Name(string CodeID)
        {
            return Db.Name(CodeID);
        }

        public BCAR Insert(BCAR Item)
        {
            Db.Insert(Item);
            return Item;
        }
        public BCAR Update(BCAR Item)
        {
            Db.Update(Item);
            return Item;
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
