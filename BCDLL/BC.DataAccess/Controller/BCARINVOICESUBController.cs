using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using System.Diagnostics;
using System.Data.Entity.Core.Objects;

namespace BC.DataAccess
{
    public class BCARINVOICESUBController : IBCARINVOICESUBController
    {
        private BCContext db;// = new BCContext(Cls_SetDB.Conns);
        public BCARINVOICESUBController(string ConnectionString)
        {
            db = new BCContext(ConnectionString);
        }

        public BCARINVOICESUB GetFind2(string DocNo)
        {
            return db.BCARINVOICESUB.Where(c => c.DocNo == DocNo).FirstOrDefault();
        }

        public void Insert(BCARINVOICESUB Items)
        {
            db.BCARINVOICESUB.Add(Items);
        }

        public void Update(BCARINVOICESUB Items)
        {
            var DEntity = this.GetFind(Items.DocNo);

            DEntity.DocNo = Items.DocNo;

            DEntity.ItemCode = Items.ItemCode;
            DEntity.DocDate = Items.DocDate;
            DEntity.ArCode = Items.ArCode;
            DEntity.CNQty = Items.CNQty;
            DEntity.Qty = Items.Qty;
            DEntity.Price = Items.Price;
            DEntity.Amount = Items.Amount;
            DEntity.NetAmount = Items.NetAmount;
            DEntity.HomeAmount = Items.HomeAmount;
            DEntity.BalanceAmount = Items.BalanceAmount;
            DEntity.UnitCode = Items.UnitCode;
            DEntity.SORefNo = Items.SORefNo;
            DEntity.LineNumber = Items.LineNumber;
            DEntity.ProjectCode = Items.ProjectCode;
            DEntity.TaxType = 0;
            DEntity.MyType = 4;
            DEntity.StockType = 1;
            DEntity.TransState = 0;
            DEntity.IsCancel = 0;
            DEntity.RefType = 1;
            DEntity.IsProcess = 1;
            DEntity.IsLockCost = 0;
            DEntity.POSSTATUS = 0;
        }

        public void Delete(BCARINVOICESUB Items)
        {
            db.BCARINVOICESUB.Remove(Items);
        }

        public BCARINVOICESUB GetFind(params object[] Keys)
        {
            return db.BCARINVOICESUB.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<BCARINVOICESUB> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///DocNo
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            var query = db.BCARINVOICESUB.Where(c => c.DocNo.Contains(Spara1));
            return query.ToList();
        }

        public void LogDB(string LogDb)
        {
            Debug.Print("BCSaleOrder : {0}", LogDb);
        }

        public void Dispose()
        {
            db.Dispose();
        }


        public string Name(string CodeID)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<BCARINVOICESUB> LoadAllForTranfer(params string[] Condition)
        {
            //string WHCode = (string)Condition[0];
            string[] WhList = (string[])Condition;
            //List<string> WhList = new List<string>();
            //WhList.Add("02");

            if (Condition.Count() > 0)
            {
                var query = from c in db.BCARINVOICE
                            join s in db.BCARINVOICESUB on c.DocNo equals s.DocNo
                            where WhList.Contains(s.WHCode) && c.IsCancel == 0
                            select s;
                return query.ToList();
            }
            else
            {
                var query = from c in db.BCARINVOICE
                            join s in db.BCARINVOICESUB on c.DocNo equals s.DocNo
                            where c.IsCancel == 0
                            select s;
                return query.ToList();
            }
        }


        public System.Collections.IEnumerable LoadAllForTranferShow(params object[] Condition)
        {
            string WHCode = (string)Condition[0];

            var query = from c in db.BCARINVOICESUB
                        join wh in db.BCWarehouse on c.WHCode equals wh.Code
                        where c.WHCode.Equals(WHCode)
                        select new
                        {
                            c.DocNo,
                            c.DocDate,
                            c.ItemCode,
                            c.ItemName,
                            c.ArCode,
                            c.SaleCode,
                            c.MyDescription,
                            c.WHCode,
                            WHNamce = wh.Name,
                            c.ShelfCode,
                            c.Qty,
                            QtyActual = c.Qty,
                            c.Price,
                            c.Amount,
                            c.UnitCode,
                            c.LineNumber
                        };

            return query.ToList();
        }

        public IEnumerable<BCARINVOICESUB> LoadAllForTranferByDate(DateTime DtpStart, DateTime DtpEnd, bool UseDate, params string[] Condition)
        {
            DateTime PDtpStart = DtpStart.Date;
            DateTime PDtpEnd = DtpEnd.Date;
            string[] WhList = (string[])Condition;
            if (UseDate == false)
            {
                if (Condition.Count() > 0)
                {
                    var query = from c in db.BCARINVOICE
                                join s in db.BCARINVOICESUB on c.DocNo equals s.DocNo
                                where WhList.Contains(s.WHCode) && c.IsCancel == 0
                                select s;
                    return query.ToList();
                }
                else
                {
                    var query = from c in db.BCARINVOICE
                                join s in db.BCARINVOICESUB on c.DocNo equals s.DocNo
                                where c.IsCancel == 0
                                select s;
                    return query.ToList();
                }
            }
            else
            {
                if (Condition.Count() > 0)
                {
                    var query = from c in db.BCARINVOICE
                                join s in db.BCARINVOICESUB on c.DocNo equals s.DocNo
                                where WhList.Contains(s.WHCode) && c.IsCancel == 0 && (EntityFunctions.TruncateTime(c.DocDate) >= PDtpStart.Date &&
                        EntityFunctions.TruncateTime(c.DocDate) <= PDtpEnd.Date)
                                select s;
                    return query.ToList();
                }
                else
                {
                    var query = from c in db.BCARINVOICE
                                join s in db.BCARINVOICESUB on c.DocNo equals s.DocNo
                                where c.IsCancel == 0 && (EntityFunctions.TruncateTime(c.DocDate) >= PDtpStart.Date &&
                        EntityFunctions.TruncateTime(c.DocDate) <= PDtpEnd.Date)
                                select s;
                    return query.ToList();
                }
            }
        }
    }
}
