using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;
namespace BC.DataAccess
{
    public class BCARDepositUseController : IBCARDepositUseController
    {

        private BCContext db;// = new BCContext(Cls_SetDB.Conns);
        public BCARDepositUseController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCARDepositUse Items)
        {
            db.BCARDepositUse.Add(Items);
        }

        public void Update(BCARDepositUse Items)
        {
            var DEntity = this.GetFind(Items.DocNo, Items.DepositNo);
            DEntity.Amount = Items.Amount;
            DEntity.DeposTaxType = Items.DeposTaxType;
            DEntity.NetAmount = Items.NetAmount;
            DEntity.LineNumber = Items.LineNumber;
            DEntity.HomeAmount1 = Items.HomeAmount1;
            DEntity.HomeAmount2 = Items.HomeAmount2;
        }

        public void Delete(BCARDepositUse Items)
        {
            db.BCARDepositUse.Remove(Items);
        }

        public BCARDepositUse GetFind(params object[] Keys)
        {
            return db.BCARDepositUse.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCARDepositUse> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            throw new NotImplementedException();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCARDeposit : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public string Name(string CodeID)
        {
            return "";
        }
    }
}
