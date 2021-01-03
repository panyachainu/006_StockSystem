using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSystem.Models;
using System.Data.Entity.Core.Objects;

namespace StockSystem.DataAccess
{
    public class C_StockTranferArInvoice : I_StockTranferArInvoice
    {
        private StockContext db;//= new BCContext(Cls_SetDB.Conns);
        public C_StockTranferArInvoice(string ConnectionString)
        {
            db = new StockContext(ConnectionString);
        }

        public void Insert(Stock_TranferArInvoice Items)
        {
            db.Stock_TranferArInvoice.Add(Items);
        }

        public void Update(Stock_TranferArInvoice Items)
        {
            var ItemEdit = this.GetFind(Items.ROWORDER);
            if (ItemEdit != null)
            {
                ItemEdit.Tran_DocNo = Items.Tran_DocNo;
                ItemEdit.DocDate = Items.DocDate;
                ItemEdit.DocNo = Items.DocNo;
                ItemEdit.ItemCode = Items.ItemCode;
                ItemEdit.DocDate = Items.DocDate;
                ItemEdit.ArCode = Items.ArCode;
                ItemEdit.SaleCode = Items.SaleCode;
                ItemEdit.MyDescription = Items.MyDescription;
                ItemEdit.ItemName = Items.ItemName;
                ItemEdit.WHCode = Items.WHCode;
                ItemEdit.ShelfCode = Items.ShelfCode;
                ItemEdit.Qty = Items.Qty;
                ItemEdit.QtyActual = Items.QtyActual;
                ItemEdit.QtyRemain = Items.QtyRemain;
                ItemEdit.Price = Items.Price;
                ItemEdit.Amount = Items.Amount;
                ItemEdit.UnitCode = Items.UnitCode;
                ItemEdit.LineNumber = Items.LineNumber;
                ItemEdit.Tran_StatusClear = Items.Tran_StatusClear;
                ItemEdit.Tran_Attribute01 = Items.Tran_Attribute01;
                ItemEdit.Tran_Attribute02 = Items.Tran_Attribute02;
                ItemEdit.Tran_Attribute03 = Items.Tran_Attribute03;
                ItemEdit.Tran_Attribute04 = Items.Tran_Attribute04;
                ItemEdit.Tran_Attribute05 = Items.Tran_Attribute05;
                ItemEdit.Status = Items.Status;
                ItemEdit.Tran_CreateBy = Items.Tran_CreateBy;
                ItemEdit.Tran_CreateDate = Items.Tran_CreateDate;
                ItemEdit.Tran_UpdateBy = Items.Tran_UpdateBy;
                ItemEdit.Tran_UpdateDate = Items.Tran_UpdateDate;
            }
        }

        public void Delete(Stock_TranferArInvoice Items)
        {
            db.Stock_TranferArInvoice.Remove(Items);
        }

        public Stock_TranferArInvoice GetFind(params object[] Keys)
        {
            return db.Stock_TranferArInvoice.Find(Keys);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Stock_TranferArInvoice> LoadAll(object para1, object para2, object para3, object para4, object para5)
        {
            String Spara1 = Convert.ToString(para1 == null ? "" : para1);///Code
            String Spara2 = Convert.ToString(para2 == null ? "" : para2);///
            String Spara3 = Convert.ToString(para3 == null ? "" : para3);
            String Spara4 = Convert.ToString(para4 == null ? "" : para4);
            String Spara5 = Convert.ToString(para5 == null ? "" : para5);

            return db.Stock_TranferArInvoice.ToList();
        }

        public IEnumerable<Stock_TranferArInvoice> LoadAllRemain(DateTime DtpStart, DateTime DtpEnd, bool UseDate)
        {
            //0 : โอนสำเร็จ  1 : ค้างโอน  2 : ยกเลิก
            DateTime PDtpStart = DtpStart.Date;
            DateTime PDtpEnd = DtpEnd.Date;
            if (UseDate)
            {
                return db.Stock_TranferArInvoice.Where(c => c.Status == 1 &&
                    (EntityFunctions.TruncateTime(c.Tran_DocDate) >= PDtpStart.Date &&
                               EntityFunctions.TruncateTime(c.Tran_DocDate) <= PDtpEnd.Date)).ToList();
            }
            else
            {
                return db.Stock_TranferArInvoice.Where(c => c.QtyRemain > 0 && c.Tran_StatusClear == 0).ToList();
            }
        }

        public IEnumerable<Stock_TranferArInvoice> LoadAll(DateTime DtpStart, DateTime DtpEnd, bool UseDate, List<int> Status)
        {
            DateTime PDtpStart = DtpStart.Date;
            DateTime PDtpEnd = DtpEnd.Date;
            if (UseDate)
            {
                return db.Stock_TranferArInvoice.Where(c =>Status.Contains(c.Status ?? 0) && (EntityFunctions.TruncateTime(c.Tran_DocDate) >= PDtpStart.Date &&
                               EntityFunctions.TruncateTime(c.Tran_DocDate) <= PDtpEnd.Date)).ToList();
            }
            else
            {
                return db.Stock_TranferArInvoice.Where(c => Status.Contains(c.Status ?? 0)).ToList();
            }
        }

        public IEnumerable<Stock_TranferArInvoice> LoadByTranDoc(string Tran_DocNo)
        {
            return db.Stock_TranferArInvoice.Where(c => c.Tran_DocNo.Equals(Tran_DocNo)).ToList();
        }

        public bool CheckUseDocNo(string DocNo)
        {
            var Result = db.Stock_TranferArInvoice.Where(c => c.Tran_DocNo.Equals(DocNo)).FirstOrDefault();
            if (Result != null)
                return false;
            else
                return true;
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
