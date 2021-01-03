﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;

namespace BC.DataAccess
{
    public class C_BCDebitNoteSub2 : I_BCDebitNoteSub2
    {
        private BCContext db;//= new BCContext(Cls_SetDB.Conns);
        public C_BCDebitNoteSub2(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCDebitNoteSub2 Items)
        {
            db.BCDebitNoteSub2.Add(Items);
        }

        public void Update(BCDebitNoteSub2 Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BCDebitNoteSub2 Items)
        {
            db.BCDebitNoteSub2.Remove(Items);
        }

        public BCDebitNoteSub2 GetFind(params object[] Keys)
        {
            return db.BCDebitNoteSub2.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCDebitNoteSub2> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCDebitNoteSub2;
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            throw new NotImplementedException();
        }

        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
