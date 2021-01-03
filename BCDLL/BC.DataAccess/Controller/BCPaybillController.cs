using BC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DataAccess
{
    public class BCPaybillController : IBCPaybillController
    {
        private BCContext db;// = new BCContext(Cls_SetDB.Conns);
       
        public BCPaybillController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public void Insert(BCPaybill Items)
        {
            throw new NotImplementedException();
        }

        public void Update(BCPaybill Items)
        {
            throw new NotImplementedException();
        }

        public void Delete(BCPaybill Items)
        {
            throw new NotImplementedException();
        }

        public BCPaybill GetFind(params object[] Keys)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BCPaybill> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///sale Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            return db.BCPaybill.Where(c=>c.SaleCode.Contains(Spara1)).ToList();
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

        public IEnumerable LoadAll_ARName(List<string> Docnos, string SearchData)
        {
            //String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            //String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            //String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            //String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            //String Spara5 = Convert.ToString(para5 == null ? "" : para5);
            if (Docnos != null || Docnos.Count > 0)
            {
                //---------- มีตัวกรอง
                var query = from c in db.BCPaybill
                            join
                            ar in db.BCAR on c.ArCode equals ar.Code
                            where !Docnos.Contains(c.DocNo)&&(c.SaleCode.Contains(SearchData))
                            orderby c.DocNo
                            select new { c.DocNo, c.DocDate, c.ArCode, ar.Name1, c.SaleCode, c.TotalAmount, c.MyDescription, c.BillStatus, c.DueDate};
                return query.ToList();
            }
            else
            {
                var query = from c in db.BCPaybill
                            join
                            ar in db.BCAR on c.ArCode equals ar.Code
                            where !Docnos.Contains(c.DocNo) && (c.SaleCode.Contains(SearchData))
                            orderby c.DocNo
                            select new { c.DocNo, c.DocDate, c.ArCode, ar.Name1, c.SaleCode, c.TotalAmount, c.MyDescription, c.BillStatus, c.DueDate };
                return query.ToList();
            }

        }


        public IEnumerable<BCPaybill> LoadAll_Selectin(List<string> Docnos)
        {
            if (Docnos.Count > 0)
            {
                return db.BCPaybill.Where(c => Docnos.Contains(c.DocNo)).ToList();
            }
            else
                return null;
               
        }
    }
}
