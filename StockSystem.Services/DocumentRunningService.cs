using StockSystem.DataAccess;
using StockSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Services
{
    public class DocumentRunningService : IDisposable
    {
        IDocumentRunningController Db;
        public DocumentRunningService(IDocumentRunningController Db)
        {
            this.Db = Db;
        }

        public DocumentRunningService(string ConnString)
            : this(new DocumentRunningController(ConnString)) //ConnectionString string ConnectionString
        {
        }
        public IEnumerable<Stock_DocumentRunning> LoadAllWhereMenu(string Menu_ID)
        {
            return Db.LoadAllWhereMenu(Menu_ID);
        }
        public IEnumerable<Stock_DocumentRunning> LoadAll(string Menu_ID, string Format_ID)
        {
            return Db.LoadAll(Menu_ID, Format_ID, null, null, null);
        }
        public Stock_DocumentRunning Update(Stock_DocumentRunning Item)
        {
            Db.Update(Item);
            Db.SaveChanges();
            return Item;
        }

        public Stock_DocumentRunning Insert(Stock_DocumentRunning Item)
        {
            Db.Insert(Item);
            Db.SaveChanges();
            return Item;
        }

        public Stock_DocumentRunning GetFind(int Format_Id, string Menu_ID)
        {
            return Db.GetFind(Format_Id, Menu_ID);
        }

        public Stock_DocumentRunning CheckYearMonthRunning(int Format_Id, string Menu_ID)
        {
            DateTime DateCurrent = Db.GetDate();// GetDate on Server

            string SYear = DateCurrent.Year > 2400 ? DateCurrent.ToString() : (DateCurrent.Year + 543).ToString();

            int YearCheck = Convert.ToInt32(SYear);
            int YearCheck2 = Convert.ToInt32(SYear.Substring(2, 2));
            int MonthCheck = DateCurrent.Month;
            int DayCheck = DateCurrent.Day;

            Stock_DocumentRunning Item = new Stock_DocumentRunning();
            Item = Db.GetFind(Format_Id, Menu_ID);
            if (Item.DocYear != null)
            {
                if (Item.DocYear.Value.ToString().Length == 2)
                {
                    if (YearCheck2 > Item.DocYear)
                        Item.DocYear = YearCheck2;
                }
                else if (Item.DocYear.Value.ToString().Length == 4)
                {
                    if (YearCheck > Item.DocYear)
                        Item.DocYear = YearCheck;
                }
            }
            if (Item.DocMonth != null)
            {
                if (MonthCheck > Item.DocMonth)
                    Item.DocMonth = MonthCheck;
            }
            if (Item.DocDay != null)
            {
                if (DayCheck > Item.DocDay)
                    Item.DocDay = DayCheck;
            }

            return Item;
        }

        public bool ResetRunning(int Format_Id, string Menu_ID)
        {
            bool ReRunning = false;
            DateTime DateCurrent = Db.GetDate();// GetDate on Server
            string SYear = DateCurrent.Year > 2400 ? DateCurrent.ToString() : (DateCurrent.Year + 543).ToString();

            int YearCheck = Convert.ToInt32(SYear);
            int YearCheck2 = Convert.ToInt32(SYear.Substring(2, 2));
            int MonthCheck = DateCurrent.Month;
            int DayCheck = DateCurrent.Day;

            Stock_DocumentRunning Item = new Stock_DocumentRunning();
            Item = Db.GetFind(Format_Id, Menu_ID);
            if (Item != null)
            {
                if (Item.DocYear != null)
                {
                    if (Item.DocYear.Value.ToString().Length == 2)
                    {
                        if (YearCheck2 > Item.DocYear)
                        {
                            Item.DocYear = YearCheck2;
                            ReRunning = true;
                        }
                    }
                    else if (Item.DocYear.Value.ToString().Length == 4)
                    {
                        if (YearCheck > Item.DocYear)
                        {
                            Item.DocYear = YearCheck;
                            ReRunning = true;
                        }
                    }
                }
                if (Item.DocMonth != null)
                {
                    if (MonthCheck > Item.DocMonth)
                    {
                        Item.DocMonth = MonthCheck;
                        ReRunning = true;
                    }
                }
                if (Item.DocDay != null)
                {
                    if (DayCheck > Item.DocDay)
                    {
                        Item.DocDay = DayCheck;
                        ReRunning = true;
                    }
                }

                if (ReRunning)// True : Running เปลื่ยน
                {
                    Item.LastRunningID = 0;
                    this.Update(Item);
                }
            }

            return ReRunning;
        }

        public Stock_DocumentRunning GetRunning(int Format_Id, string Menu_ID)
        {
            Stock_DocumentRunning Item = this.CheckYearMonthRunning(Format_Id, Menu_ID);
            return Item;
        }
        public Stock_DocumentRunning SetNextRunning(Stock_DocumentRunning Item)
        {
            Item.IncreaseNextNumber();
            Db.Update(Item);
            Db.SaveChanges();
            return Item;
        }

        public string GetRunningDisplay(Stock_DocumentRunning Item)
        {
            int? LastR = Item.LastRunningID;
            ++LastR;
            return string.Format(Item.FormatString, Item.Prefix,
                Item.DocYear == 0 ? null : Item.DocYear,
                Item.DocMonth == 0 ? null : Item.DocMonth,
                Item.DocDay == 0 ? null : Item.DocDay,
                LastR);
        }

        public DateTime GetDate()
        {
            return Db.GetDate();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
