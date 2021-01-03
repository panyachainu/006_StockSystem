using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC.Models;
using StockSystem.Models;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using StockSystem.Services;
using DevExpress.XtraEditors;

namespace StockSystem
{
    public partial class Frm_TranferARInvoice : Form
    {
        public Frm_TranferARInvoice()
        {
            InitializeComponent();
        }
        DocumentMenuService Db_Menu = new DocumentMenuService(Utility.ConnSDB);
        DocumentRunningService Db_Run = new DocumentRunningService(Utility.ConnSDB);
        List<Stock_TranferArInvoice> Item_Tran = new List<Stock_TranferArInvoice>();
        string _Menu_ID = "", _RunningID = "";
        Stock_DocumentRunning DEntRun;
        IEnumerable<Stock_DocumentMenu> ItemDoc = null;

        //----------- Display
        IEnumerable<Stock_TranferArInvoice> Item_DisplayTran = null;
        public string _TranDocNo_Display { get; set; }


        private void btn_Select_Click(object sender, EventArgs e)
        {
            Frm_TranferPayBill frm = new Frm_TranferPayBill();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<Stock_TranferArInvoice> Item_temp = Item_Tran;
                Item_Tran = new List<Stock_TranferArInvoice>();
                IEnumerable<BCARINVOICESUB> Ireturn = frm.Item_Return;
                foreach (var itemadd in Ireturn)
                {
                    Stock_TranferArInvoice Item = new Stock_TranferArInvoice();
                    Item.DocNo = itemadd.DocNo;
                    Item.DocDate = itemadd.DocDate;
                    Item.ItemCode = itemadd.ItemCode;
                    Item.ItemName = itemadd.ItemName;
                    Item.ArCode = itemadd.ArCode;
                    Item.SaleCode = itemadd.SaleCode;
                    Item.MyDescription = itemadd.MyDescription;
                    Item.WHCode = itemadd.WHCode;
                    Item.ShelfCode = itemadd.ShelfCode;
                    Item.Qty = itemadd.Qty;
                    Item.QtyActual = itemadd.Qty;
                    Item.Price = itemadd.Price;
                    Item.Amount = itemadd.Amount;
                    Item.UnitCode = itemadd.UnitCode;
                    Item.LineNumber = itemadd.LineNumber;
                    //Item_Tran.Add(Item);
                    Item_temp.Add(Item);
                }
                Item_Tran = Item_temp.GroupBy(c => new { c.DocNo, c.ItemCode, c.LineNumber }).Select(g => g.First()).ToList();

                Fn_LoadToGrid();
            }
        }

        private void Fn_LoadToGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = Item_Tran;
            btn_Save.Enabled = Item_Tran.Count == 0 ? false : true;
            //gridControl1.Refresh();
        }

        private void Frm_TranferARInvoice_Load(object sender, EventArgs e)
        {

            dtp_Tranfer.EditValue = DateTime.Now;
            if (this._TranDocNo_Display != null)
                backgroundWorker_LoadDataDisplay.RunWorkerAsync();
            else
                backgroundWorker_Running.RunWorkerAsync();
            //txt_DocNoTran.Text = string.Format("{0}{1}{2}{3}{4}", "WH", DateTime.Now.Date.ToString("yy"), DateTime.Now.Date.ToString("MM"), DateTime.Now.Date.ToString("dd"), "002");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_DocNoTran.Text == "")
            {
                MessageBox.Show("คุณยังไม่ได้กรอกข้อมูล [เลขที่เอกสารโอน] ...กรุณากรอกข้อมูลก่อนทำการบันทึก", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gridView1.RowCount > 0)
            {
                if (DEntRun == null)
                {
                    Utility.MessageError("ไม่พบข้อมูล [เลข Running] กรุณาทำการเลือกข้อมูล Running ใหม่อีกครั้งครับ");
                    return;
                }

                //------ Check การเปลี่ยน Running
                if (Fn_CheckRunningChange(Convert.ToInt32(_RunningID), _Menu_ID) == false)//True : มีการเปลี่ยน Running พร้อม Reset เป็น 0
                {
                    return;
                }

                if (Utility.MessageQuestion("คุณต้องการที่จะทำการโอนข้อมูลหรือไม่... กด Yes เพื่อยินยันการโอน?") == DialogResult.No)
                    return;

                List<Stock_TranferArInvoice> Item_Source = (List<Stock_TranferArInvoice>)gridView1.DataSource;
                string TranDocNo = txt_DocNoTran.Text.Trim();
                DateTime TranDate = dtp_Tranfer.DateTime;
                string sRunningCurrent = "";

                List<Stock_TranferArInvoice> Item_Result = new List<Stock_TranferArInvoice>();
                foreach (Stock_TranferArInvoice ItemSet in Item_Source)
                {
                    ItemSet.Tran_DocNo = TranDocNo;
                    ItemSet.Tran_DocDate = TranDate;
                    ItemSet.QtyRemain = ItemSet.Qty - ItemSet.QtyActual; // [Qty] - [QtyActual]
                    ItemSet.Tran_StatusClear = 0; //0 : รายการปกติ ยอดคงค้างใช้คำนวณ   1 : รายการที่ถูกยกเลิก ยอดคงค้างจะไม่คำนวณ
                    ItemSet.Status = ItemSet.QtyRemain == 0 ? 0 : 1;//0 : โอนสำเร็จ  1 : ค้างโอน  2 : ยกเลิก
                    //ItemSet.Tran_Attribute01 = ItemSet.Tran_Attribute01;
                    ItemSet.Tran_UpdateBy = Utility._UserDB;
                    ItemSet.Tran_UpdateDate = DateTime.Now;
                    ItemSet.Tran_CreateBy = Utility._UserDB;
                    ItemSet.Tran_CreateDate = DateTime.Now;
                    //ItemSet.Tran_Attribute01 = "Delete Test where Tran_DocNo=('sdsdsd-0102-3')";
                    Item_Result.Add(ItemSet);
                }

                List<Stock_TranferAccrual> ItemLog = new List<Stock_TranferAccrual>();
                foreach (Stock_TranferArInvoice Iset in Item_Result)
                {
                    Stock_TranferAccrual ILog = new Stock_TranferAccrual();
                    ILog.TranferAccrual_Date = Iset.Tran_DocDate;
                    ILog.TranferAccual_QtyReam = Iset.QtyActual;
                    ILog.Tran_DocNo = Iset.Tran_DocNo;
                    ILog.Tran_DocDate = Iset.Tran_DocDate;
                    ILog.DocNo = Iset.DocNo;
                    ILog.ItemCode = Iset.ItemCode;
                    ILog.DocDate = Iset.DocDate;
                    ILog.ArCode = Iset.ArCode;
                    ILog.SaleCode = Iset.SaleCode;
                    ILog.MyDescription = Iset.MyDescription;
                    ILog.ItemName = Iset.ItemName;
                    ILog.WHCode = Iset.WHCode;
                    ILog.ShelfCode = Iset.ShelfCode;
                    ILog.Qty = Iset.Qty;
                    ILog.QtyActual = Iset.QtyActual;
                    ILog.QtyRemain = Iset.QtyRemain;
                    ILog.Price = Iset.Price;
                    ILog.Amount = Iset.Amount;
                    ILog.UnitCode = Iset.UnitCode;
                    ILog.LineNumber = Iset.LineNumber;
                    ILog.Tran_StatusClear = Iset.Tran_StatusClear;
                    ILog.Tran_Attribute01 = Iset.Tran_Attribute01;
                    ILog.Tran_Attribute02 = Iset.Tran_Attribute02;
                    ILog.Tran_Attribute03 = Iset.Tran_Attribute03;
                    ILog.Tran_Attribute04 = Iset.Tran_Attribute04;
                    ILog.Tran_Attribute05 = Iset.Tran_Attribute05;
                    ILog.Status = Iset.Status;
                    ILog.Tran_CreateBy = Iset.Tran_CreateBy;
                    ILog.Tran_CreateDate = Iset.Tran_CreateDate;
                    ILog.Tran_UpdateBy = Iset.Tran_UpdateBy;
                    ILog.Tran_UpdateDate = Iset.Tran_UpdateDate;
                    ItemLog.Add(ILog);
                }

                try
                {


                    using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
                    {
                        using (var srv2 = new StockTranferAccrualService(Utility.ConnSDB))
                        {
                            if (srv.CheckUseDocNo(TranDocNo) == false)
                            {
                                if (Utility.MessageQuestion("ข้อมูลการโอน : " + TranDocNo + " ถูกใช้บันทึกไปแล้ว\nคุณต้องการทำการบันทึกหรือไม่...โดยระบบจะทำการ Running รหัสเอกสารลำดับต่อไป") == DialogResult.Yes)
                                {
                                    //::::::::::: Manage Running Duplicate [Start] :::::::::::::::::::::::
                                    using (var db2 = new DocumentRunningService(Utility.ConnSDB))
                                    {
                                        DEntRun = db2.GetRunning(Convert.ToInt32(_RunningID), _Menu_ID);
                                        do
                                        {
                                            DEntRun = db2.SetNextRunning(DEntRun);//---- IncreaseNextNumber 1
                                            sRunningCurrent = Db_Run.GetRunningDisplay(DEntRun);

                                        } while (!srv.CheckUseDocNo(sRunningCurrent));//วนเช็ค Running และ Update Running ไปเรื่อยๆจนกว่าจะเจอ Running ที่ไม่ได้ใช้

                                        foreach (var item in Item_Result)
                                            item.Tran_DocNo = sRunningCurrent;
                                    }
                                    //::::::::::: Manage Running Duplicate [END] :::::::::::::::::::::::
                                }
                                else
                                    return;
                            }

                            bool result = srv.Insert(Item_Result, DEntRun);
                            bool result_log = srv2.Insert(ItemLog);
                            if (result && result_log)
                            {
                                Utility.MessageInformation("บันทึกข้อมูลเรียบร้อย...");
                                //Fn_ScreenClear();
                                Fn_ClearData();
                            }
                            else
                            {
                                Utility.MessageError("ไม่สามารถบันทึกข้อมูลได้...เนื่องจาก : " + srv.ErrorMessage);
                                Utility.MessageError("ไม่สามารถบันทึกข้อมูลได้...เนื่องจาก : " + srv2.ErrorMessage);
                            }
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    Utility.MessageError("Error : " + ex.Message);
                    if (ex.InnerException != null)
                    {
                        Utility.MessageError("Error Inner : " + ex.InnerException.Message);
                    }
                }
            }
        }

        private bool Fn_CheckRunningChange(int RunID, string _Menu_ID)//True : มีการเปลี่ยน Running พร้อม Reset เป็น 0
        {
            using (var srv = new DocumentRunningService(Utility.ConnSDB))
            {
                if (srv.ResetRunning(RunID, _Menu_ID))
                {
                    Utility.MessageInformation("มีการ Reset เลขที่เอกสารใหม่...กรุณาตรวจสอบเลขที่เอกสารใหม่อีกครั้งครับ");
                    DEntRun = srv.GetFind(Convert.ToInt32(_RunningID), _Menu_ID);//srv.GetRunning(Convert.ToInt32(_RunningID), _Menu_ID);
                    if (DEntRun == null)
                    {
                        Utility.MessageError("ไม่พบข้อมูลการ Running กรุณาลองใหม่อีกครั้งครับ");
                        return false;
                    }
                    txt_DocNoTran.Text = srv.GetRunningDisplay(DEntRun);
                    return false;
                }
                else
                    return true;
            }
        }

        private void Fn_ScreenClear()
        {
            Item_Tran = new List<Stock_TranferArInvoice>();
            gridControl1.DataSource = null;
            txt_DocNoTran.Text = "";
            dtp_Tranfer.DateTime = DateTime.Now;
            btn_Delete.Enabled = false;
            btn_Select.Enabled = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Fn_SetBtnDelete();
        }

        private void Fn_SetBtnDelete()
        {
            if (gridView1.SelectedRowsCount > 0)
                btn_Delete.Enabled = true;
            else
                btn_Delete.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (Utility.MessageQuestion("คุณต้องการที่จะลบรายการหรือไม่?...กด Yes เพื่อยืนยันการลบ") == DialogResult.No)
                    return;
                List<Stock_TranferArInvoice> Item_Remove = new List<Stock_TranferArInvoice>();

                //---Get Data For Remove
                int[] rows = gridView1.GetSelectedRows();
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var Idel = gridView1.GetRow(rows[i]);
                    Item_Remove.Add((Stock_TranferArInvoice)Idel);
                }

                //---Remove Data
                foreach (var Iremove in Item_Remove)
                {
                    Item_Tran.Remove(Iremove);
                }
                Fn_LoadToGrid();
                Fn_SetBtnDelete();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn Qty = view.Columns["Qty"];
            GridColumn QtyActual = view.Columns["QtyActual"];
            //Get the value of the first column
            decimal intQty = (decimal)view.GetRowCellValue(e.RowHandle, Qty);
            //Get the value of the second column
            decimal intQtyActual = (decimal)view.GetRowCellValue(e.RowHandle, QtyActual);

            // [Qty] - [QtyActual]
            decimal result = (intQty - intQtyActual);
            //Validity criterion
            if (result < 0)
            {
                e.Valid = false;
                //Set errors with specific descriptions for the columns
                //view.SetColumnError(Qty, "The value must be greater than Units On Order");
                view.SetColumnError(QtyActual, "จำนวนเบิก ห้ามเกินจำนวนสินค้า...กรุณาแก้ไขด้วยครับ");
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        void Click_LoadMenuRun()
        {
            ItemDoc = Db_Menu.LoadAll();
        }

        private void cmb_Menu_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit G_Menu = sender as GridLookUpEdit;
            if (G_Menu == null) return;
            if (G_Menu.EditValue == null) return;
            _Menu_ID = G_Menu.EditValue.ToString();
            Click_LoadRunning(_Menu_ID);
        }

        void Click_LoadRunning(string MenuID)
        {
            using (var db = new DocumentRunningService(Utility.ConnSDB))
            {
                Cmb_Running.Properties.DataSource = db.LoadAll(MenuID, "");
                Cmb_Running.Properties.DisplayMember = "Description";
                Cmb_Running.Properties.ValueMember = "Format_Id";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Fn_ClearData();

        }

        private void Fn_ClearData()
        {
            cmb_Menu.Properties.DataSource = null;
            cmb_Menu.EditValue = "";
            Cmb_Running.Properties.DataSource = null;
            Cmb_Running.EditValue = "";
            txt_DocNoTran.Text = "";
            dtp_Tranfer.EditValue = DateTime.Now;
            gridControl1.DataSource = null;
            btn_Save.Enabled = false;
            btn_Select.Enabled = false;
            Item_Tran = new List<Stock_TranferArInvoice>();
            backgroundWorker_Running.RunWorkerAsync();
        }

        private void Cmb_Running_EditValueChanged(object sender, EventArgs e)
        {


            GridLookUpEdit G_Run = sender as GridLookUpEdit;
            if (G_Run.EditValue == null) return;
            _RunningID = G_Run.EditValue.ToString();
            using (var db = new DocumentRunningService(Utility.ConnSDB))
            {
                if (_RunningID == "" || _Menu_ID == "")
                    return;
                DEntRun = db.GetFind(Convert.ToInt32(_RunningID), _Menu_ID);//db.GetRunning(Convert.ToInt32(_RunningID), _Menu_ID);
            }
            if (DEntRun == null) return;
            txt_DocNoTran.Text = Db_Run.GetRunningDisplay(DEntRun);

            if (txt_DocNoTran.Text != "")
            {
                btn_Select.Enabled = true;
            }
        }

        private void backgroundWorker_Running_DoWork(object sender, DoWorkEventArgs e)
        {
            Click_LoadMenuRun();
        }

        private void backgroundWorker_Running_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Click_LoadMenuRunCompleted();
        }

        private void Click_LoadMenuRunCompleted()
        {
            cmb_Menu.Properties.DataSource = ItemDoc;
            cmb_Menu.Properties.DisplayMember = "Description";
            cmb_Menu.Properties.ValueMember = "Menu_ID";
        }

        private void backgroundWorker_LoadDataDisplay_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this._TranDocNo_Display != "")
                Fn_LoadDataDisplay(this._TranDocNo_Display);
            else
            {
                Utility.MessageError("ไม่พบข้อมูลเอกสารที่ต้องการดูข้อมูล...กรุณาลองใหม่อีกครั้งครับ");
                this.Close();
            }
        }


        private void Fn_LoadDataDisplay(string _TranDocNo_Display)
        {
            using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
            {
                Item_DisplayTran = srv.LoadByTranDoc(_TranDocNo_Display);
            }
        }

        private void backgroundWorker_LoadDataDisplay_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Fn_LoadDataDisplayCompleted();
        }

        private void Fn_LoadDataDisplayCompleted()
        {
            if (Item_DisplayTran != null)
            {
                cmb_Menu.Enabled = false;
                Cmb_Running.Enabled = false;
                txt_DocNoTran.Enabled = false;
                btn_Select.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Save.Enabled = false;
                btn_Clear.Enabled = false;

                foreach (var Idisplay in Item_DisplayTran)
                {
                    txt_DocNoTran.Text = Idisplay.Tran_DocNo;
                    dtp_Tranfer.EditValue = Idisplay.Tran_DocDate.Date;
                    break;
                }
                gridControl1.DataSource = Item_DisplayTran;
            }
        }



    }
}
