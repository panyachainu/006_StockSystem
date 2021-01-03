using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using StockSystem.Models;
using StockSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class Frm_TransListRemain : Form
    {
        public Frm_TransListRemain()
        {
            InitializeComponent();
        }
        IEnumerable<Stock_TranferArInvoice> Item_TranRemain = null;

        private void Frm_TransListRemain_Load(object sender, EventArgs e)
        {
            dtp_Tranfer.EditValue = DateTime.Now.Date;
            dtp_TranferEnd.EditValue = DateTime.Now.Date;
            //backgroundWorker_Remain.RunWorkerAsync();
        }

        private void backgroundWorker_Remain_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                lbl_Status.Text = "Status : กำลังโหลดข้อมูลกรุณารอสักครู่....";
                btn_Search.Enabled = false;
                btn_Close.Enabled = false;
            }));
            this.BeginInvoke(new Action(() => { SplashScreenManager.ShowForm(this, typeof(Frm_WaitProcess), true, true, false); }));
            using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
            {
                DateTime DtpStart = dtp_Tranfer.DateTime.Date;
                DateTime DtpEnd = dtp_TranferEnd.DateTime.Date;
                bool UserDate = chk_DateCurrent.Checked;
                Item_TranRemain = srv.LoadAllRemain(DtpStart, DtpEnd, UserDate);
            }
        }

        private void backgroundWorker_Remain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Stock_TranferArInvoice ItemSet in Item_TranRemain)
            {
                ItemSet.QtyActual = 0;
            }
            grd_Data.DataSource = Item_TranRemain;
            this.BeginInvoke(new Action(() =>
            {
                lbl_Status.Text = "Status : โหลดข้อมูลสำเร็จ...จำนวนข้อมูลทั้งหมด " + Item_TranRemain.Count() + " แถว";
                btn_Search.Enabled = true;
                btn_Close.Enabled = true;
            }));
            this.BeginInvoke(new Action(() => { SplashScreenManager.CloseForm(false); }));
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            //QtyReam--จำนวนเบิก
            //QtyRemain -- ค้างโอน
            GridColumn QtyActual = view.Columns["QtyActual"];
            GridColumn QtyRemain = view.Columns["QtyRemain"];
            //Get the value of the first column
            decimal intQtyReam = (decimal)gridView1.GetListSourceRowCellValue(e.RowHandle, QtyActual);
            //Get the value of the second column
            decimal intQtyRemain = (decimal)view.GetRowCellValue(e.RowHandle, QtyRemain);

            // [QtyRemain] - [QtyReam]
            decimal result = (intQtyRemain - intQtyReam);
            //Validity criterion
            if (result < 0)
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                //view.SetColumnError(Qty, "The value must be greater than Units On Order");
                view.SetColumnError(QtyActual, "จำนวนค้างโอน ห้ามเกินจำนวนสินค้า...กรุณาแก้ไขด้วยครับ");
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Fn_ShowDataSelected();
        }

        private void Fn_ShowDataSelected()
        {
            txt_RowSelect.Text = string.Format("จำนวนที่เลือก : {0:#,##}", gridView1.SelectedRowsCount);
            if (gridView1.SelectedRowsCount > 0)
            {
                btn_Save.Enabled = true;
                btn_Cancel.Enabled = true;
            }
            else
            {
                btn_Save.Enabled = false;
                btn_Cancel.Enabled = false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (Utility.MessageQuestion("คุณต้องการ [บันทึกข้อมูลการโอน] ที่เลือกหรือไม่...กด Yes เพื่อทำการโอน") == DialogResult.No)
                    return;

                int[] rows = gridView1.GetSelectedRows();

                using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
                {
                    List<Stock_TranferArInvoice> ItemAdd = new List<Stock_TranferArInvoice>();
                    List<Stock_TranferAccrual> ItemLog = new List<Stock_TranferAccrual>();

                    for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                    {

                        Stock_TranferArInvoice IReture = (Stock_TranferArInvoice)gridView1.GetRow(rows[i]);
                        Stock_TranferArInvoice Iupdate = srv.GetFind(IReture.ROWORDER);
                        if (Iupdate != null)
                        {
                            Iupdate.QtyActual = Iupdate.QtyActual + IReture.QtyActual; // บวกการเบิกของใหม่กับเดิมไป
                            Iupdate.QtyRemain = Iupdate.Qty - Iupdate.QtyActual; // คำนวณยอดคงเหลือ
                            Iupdate.Status = Iupdate.QtyRemain == 0 ? 0 : 1;//0 : โอนสำเร็จ  1 : ค้างโอน  2 : ยกเลิก
                            Iupdate.Tran_UpdateDate = DateTime.Now;
                            Iupdate.Tran_UpdateBy = Utility._UserDB;
                            ItemAdd.Add(Iupdate);

                            Stock_TranferAccrual ILog = new Stock_TranferAccrual();
                            ILog.TranferAccrual_Date = DateTime.Now;
                            ILog.TranferAccual_QtyReam = IReture.QtyActual;
                            ILog.Tran_DocNo = Iupdate.Tran_DocNo;
                            ILog.Tran_DocDate = Iupdate.Tran_DocDate;
                            ILog.DocNo = Iupdate.DocNo;
                            ILog.ItemCode = Iupdate.ItemCode;
                            ILog.DocDate = Iupdate.DocDate;
                            ILog.ArCode = Iupdate.ArCode;
                            ILog.SaleCode = Iupdate.SaleCode;
                            ILog.MyDescription = Iupdate.MyDescription;
                            ILog.ItemName = Iupdate.ItemName;
                            ILog.WHCode = Iupdate.WHCode;
                            ILog.ShelfCode = Iupdate.ShelfCode;
                            ILog.Qty = Iupdate.Qty;
                            ILog.QtyActual = Iupdate.QtyActual;
                            ILog.QtyRemain = Iupdate.QtyRemain;
                            ILog.Price = Iupdate.Price;
                            ILog.Amount = Iupdate.Amount;
                            ILog.UnitCode = Iupdate.UnitCode;
                            ILog.LineNumber = Iupdate.LineNumber;
                            ILog.Tran_StatusClear = Iupdate.Tran_StatusClear;
                            ILog.Tran_Attribute01 = Iupdate.Tran_Attribute01;
                            ILog.Tran_Attribute02 = Iupdate.Tran_Attribute02;
                            ILog.Tran_Attribute03 = Iupdate.Tran_Attribute03;
                            ILog.Tran_Attribute04 = Iupdate.Tran_Attribute04;
                            ILog.Tran_Attribute05 = Iupdate.Tran_Attribute05;
                            ILog.Status = Iupdate.Status;
                            ILog.Tran_CreateBy = Iupdate.Tran_CreateBy;
                            ILog.Tran_CreateDate = Iupdate.Tran_CreateDate;
                            ILog.Tran_UpdateBy = Iupdate.Tran_UpdateBy;
                            ILog.Tran_UpdateDate = Iupdate.Tran_UpdateDate;
                            ItemLog.Add(ILog);
                        }
                    }


                    //foreach (Stock_TranferArInvoice Iset in ItemAdd)
                    //{
                    //    Stock_TranferAccrual ILog = new Stock_TranferAccrual();
                    //    ILog.TranferAccrual_Date = DateTime.Now;
                    //    ILog.Tran_DocNo = Iset.Tran_DocNo;
                    //    ILog.Tran_DocDate = Iset.Tran_DocDate;
                    //    ILog.DocNo = Iset.DocNo;
                    //    ILog.ItemCode = Iset.ItemCode;
                    //    ILog.DocDate = Iset.DocDate;
                    //    ILog.ArCode = Iset.ArCode;
                    //    ILog.SaleCode = Iset.SaleCode;
                    //    ILog.MyDescription = Iset.MyDescription;
                    //    ILog.ItemName = Iset.ItemName;
                    //    ILog.WHCode = Iset.WHCode;
                    //    ILog.ShelfCode = Iset.ShelfCode;
                    //    ILog.Qty = Iset.Qty;
                    //    ILog.QtyActual = Iset.QtyActual;
                    //    ILog.QtyRemain = Iset.QtyRemain;
                    //    ILog.Price = Iset.Price;
                    //    ILog.Amount = Iset.Amount;
                    //    ILog.UnitCode = Iset.UnitCode;
                    //    ILog.LineNumber = Iset.LineNumber;
                    //    ILog.Tran_StatusClear = Iset.Tran_StatusClear;
                    //    ILog.Tran_Attribute01 = Iset.Tran_Attribute01;
                    //    ILog.Tran_Attribute02 = Iset.Tran_Attribute02;
                    //    ILog.Tran_Attribute03 = Iset.Tran_Attribute03;
                    //    ILog.Tran_Attribute04 = Iset.Tran_Attribute04;
                    //    ILog.Tran_Attribute05 = Iset.Tran_Attribute05;
                    //    ILog.Status = Iset.Status;
                    //    ILog.Tran_CreateBy = Iset.Tran_CreateBy;
                    //    ILog.Tran_CreateDate = Iset.Tran_CreateDate;
                    //    ILog.Tran_UpdateBy = Iset.Tran_UpdateBy;
                    //    ILog.Tran_UpdateDate = Iset.Tran_UpdateDate;
                    //    ItemLog.Add(ILog);
                    //}
                    using (var srv2 = new StockTranferAccrualService(Utility.ConnSDB))
                    {
                        if (srv.Update(ItemAdd) && srv2.Insert(ItemLog))
                        {
                            Utility.MessageInformation("บันทึกข้อมูลสำเร็จ...");
                            backgroundWorker_Remain.RunWorkerAsync();
                        }
                        else
                        {
                            if (srv.ErrorMessage != "")
                                Utility.MessageError("ไม่สามารถบันทึกได้ เนื่องจาก : " + srv.ErrorMessage);
                            if (srv2.ErrorMessage != "")
                                Utility.MessageError("ไม่สามารถบันทึกได้ เนื่องจาก : " + srv2.ErrorMessage);
                        }
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (Utility.MessageQuestion("คุณต้องการ [ยกเลิกข้อมูลการโอน] ที่เลือกหรือไม่...กด Yes เพื่อทำการยกเลิก") == DialogResult.No)
                    return;

                int[] rows = gridView1.GetSelectedRows();
                using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
                {
                    List<Stock_TranferArInvoice> ItemAdd = new List<Stock_TranferArInvoice>();
                    List<Stock_TranferAccrual> ItemLog = new List<Stock_TranferAccrual>();
                    for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                    {

                        Stock_TranferArInvoice IReture = (Stock_TranferArInvoice)gridView1.GetRow(rows[i]);
                        Stock_TranferArInvoice Iupdate = srv.GetFind(IReture.ROWORDER);
                        if (Iupdate != null)
                        {
                            //---เดิม
                            //Iupdate.QtyActual = Iupdate.QtyActual + IReture.QtyActual; // บวกการเบิกของใหม่กับเดิมไป
                            
                            //---ใหม่ แก้ตรงข้ามกับอันเดิม 27-12-2559
                            Iupdate.QtyActual = Iupdate.QtyActual - IReture.QtyActual; // บวกการเบิกของใหม่กับเดิมไป
                            Iupdate.QtyRemain = Iupdate.Qty - Iupdate.QtyActual; // คำนวณยอดคงเหลือ
                            Iupdate.Tran_StatusClear = 1;//0 : รายการปกติ ยอดคงค้างใช้คำนวณ   1 : รายการที่ถูกยกเลิก ยอดคงค้างจะไม่คำนวณ
                            Iupdate.Status = 2;//0 : โอนสำเร็จ  1 : ค้างโอน  2 : ยกเลิก
                            Iupdate.Tran_UpdateDate = DateTime.Now;
                            Iupdate.Tran_UpdateBy = Utility._UserDB;
                            ItemAdd.Add(Iupdate);

                            Stock_TranferAccrual ILog = new Stock_TranferAccrual();
                            ILog.TranferAccrual_Date = DateTime.Now;
                            ILog.Tran_DocNo = Iupdate.Tran_DocNo;
                            ILog.Tran_DocDate = Iupdate.Tran_DocDate;
                            ILog.DocNo = Iupdate.DocNo;
                            ILog.ItemCode = Iupdate.ItemCode;
                            ILog.DocDate = Iupdate.DocDate;
                            ILog.ArCode = Iupdate.ArCode;
                            ILog.SaleCode = Iupdate.SaleCode;
                            ILog.MyDescription = Iupdate.MyDescription;
                            ILog.ItemName = Iupdate.ItemName;
                            ILog.WHCode = Iupdate.WHCode;
                            ILog.ShelfCode = Iupdate.ShelfCode;
                            ILog.Qty = Iupdate.Qty;
                            ILog.QtyActual = Iupdate.QtyActual;
                            ILog.QtyRemain = Iupdate.QtyRemain;
                            ILog.Price = Iupdate.Price;
                            ILog.Amount = Iupdate.Amount;
                            ILog.UnitCode = Iupdate.UnitCode;
                            ILog.LineNumber = Iupdate.LineNumber;
                            ILog.Tran_StatusClear = Iupdate.Tran_StatusClear;
                            ILog.Tran_Attribute01 = Iupdate.Tran_Attribute01;
                            ILog.Tran_Attribute02 = Iupdate.Tran_Attribute02;
                            ILog.Tran_Attribute03 = Iupdate.Tran_Attribute03;
                            ILog.Tran_Attribute04 = Iupdate.Tran_Attribute04;
                            ILog.Tran_Attribute05 = Iupdate.Tran_Attribute05;
                            ILog.Status = Iupdate.Status;
                            ILog.Tran_CreateBy = Iupdate.Tran_CreateBy;
                            ILog.Tran_CreateDate = Iupdate.Tran_CreateDate;
                            ILog.Tran_UpdateBy = Iupdate.Tran_UpdateBy;
                            ILog.Tran_UpdateDate = Iupdate.Tran_UpdateDate;
                            ItemLog.Add(ILog);
                        }
                    }


                    //foreach (Stock_TranferArInvoice Iset in ItemAdd)
                    //{
                    //    Stock_TranferAccrual ILog = new Stock_TranferAccrual();
                    //    ILog.TranferAccrual_Date = DateTime.Now;
                    //    ILog.Tran_DocNo = Iset.Tran_DocNo;
                    //    ILog.Tran_DocDate = Iset.Tran_DocDate;
                    //    ILog.DocNo = Iset.DocNo;
                    //    ILog.ItemCode = Iset.ItemCode;
                    //    ILog.DocDate = Iset.DocDate;
                    //    ILog.ArCode = Iset.ArCode;
                    //    ILog.SaleCode = Iset.SaleCode;
                    //    ILog.MyDescription = Iset.MyDescription;
                    //    ILog.ItemName = Iset.ItemName;
                    //    ILog.WHCode = Iset.WHCode;
                    //    ILog.ShelfCode = Iset.ShelfCode;
                    //    ILog.Qty = Iset.Qty;
                    //    ILog.QtyActual = Iset.QtyActual;
                    //    ILog.QtyRemain = Iset.QtyRemain;
                    //    ILog.Price = Iset.Price;
                    //    ILog.Amount = Iset.Amount;
                    //    ILog.UnitCode = Iset.UnitCode;
                    //    ILog.LineNumber = Iset.LineNumber;
                    //    ILog.Tran_StatusClear = Iset.Tran_StatusClear;
                    //    ILog.Tran_Attribute01 = Iset.Tran_Attribute01;
                    //    ILog.Tran_Attribute02 = Iset.Tran_Attribute02;
                    //    ILog.Tran_Attribute03 = Iset.Tran_Attribute03;
                    //    ILog.Tran_Attribute04 = Iset.Tran_Attribute04;
                    //    ILog.Tran_Attribute05 = Iset.Tran_Attribute05;
                    //    ILog.Status = Iset.Status;
                    //    ILog.Tran_CreateBy = Iset.Tran_CreateBy;
                    //    ILog.Tran_CreateDate = Iset.Tran_CreateDate;
                    //    ILog.Tran_UpdateBy = Iset.Tran_UpdateBy;
                    //    ILog.Tran_UpdateDate = Iset.Tran_UpdateDate;
                    //    ItemLog.Add(ILog);
                    //}
                    using (var srv2 = new StockTranferAccrualService(Utility.ConnSDB))
                    {
                        if (srv.Update(ItemAdd) && srv2.Insert(ItemLog))
                        {
                            Utility.MessageInformation("บันทึกข้อมูลสำเร็จ...");
                            backgroundWorker_Remain.RunWorkerAsync();
                        }
                        else
                        {
                            if (srv.ErrorMessage != "")
                                Utility.MessageError("ไม่สามารถบันทึกได้ เนื่องจาก : " + srv.ErrorMessage);
                            if (srv2.ErrorMessage != "")
                                Utility.MessageError("ไม่สามารถบันทึกได้ เนื่องจาก : " + srv2.ErrorMessage);
                        }
                    }
                }
                //List<Stock_TranferArInvoice> ItemAdd = new List<Stock_TranferArInvoice>();
                //for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                //{
                //    Stock_TranferArInvoice IReture = (Stock_TranferArInvoice)gridView1.GetRow(rows[i]);
                //    IReture.QtyRemain = IReture.Qty - IReture.QtyActual; // [Qty] - [QtyActual]
                //    IReture.Tran_StatusClear = 1;//0 : รายการปกติ ยอดคงค้างใช้คำนวณ   1 : รายการที่ถูกยกเลิก ยอดคงค้างจะไม่คำนวณ
                //    ItemAdd.Add(IReture);
                //}

                //using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
                //{
                //    if (srv.Update(ItemAdd))
                //    {
                //        Utility.MessageInformation("บันทึกข้อมูลสำเร็จ...");
                //        backgroundWorker_Remain.RunWorkerAsync();
                //    }
                //    else
                //        Utility.MessageError("ไม่สามารถบันทึกได้ เนื่องจาก : " + srv.ErrorMessage);
                //}
            }
        }

        private void grd_Data_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            ////QtyReam--จำนวนเบิก
            ////QtyRemain -- ค้างโอน
            ////QtyRemain_Temp--คงค้าง
            //GridView view = sender as GridView;
            //if (e.Column.FieldName == "QtyRemain_Temp" && e.IsGetData) e.Value =
            //  getTotalValue(view, e.ListSourceRowIndex);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            backgroundWorker_Remain.RunWorkerAsync();
        }

        private void chk_DateCurrent_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Tranfer.Enabled = dtp_TranferEnd.Enabled = chk_DateCurrent.Checked;
        }

        //// Returns the total amount for a specific row.
        //decimal getTotalValue(GridView view, int listSourceRowIndex)
        //{
        //    decimal QtyRemain = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "QtyRemain"));
        //    decimal QtyReam = Convert.ToDecimal(view.GetListSourceRowCellValue(listSourceRowIndex, "QtyReam"));
        //    return QtyRemain - QtyReam;
        //}

    }
}
