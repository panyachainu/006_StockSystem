using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BC.Services;
using System.Collections;
using BC.Models;
using StockSystem.Models;
using StockSystem.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using Microsoft.Win32;
//using DevExpress.XtraEditors.Repository;


namespace StockSystem
{
    public partial class Frm_TranferPayBill : Form
    {
        public Frm_TranferPayBill()
        {
            InitializeComponent();
        }
        IEnumerable<BCARINVOICESUB> Item_Result = null;
        IEnumerable<Stock_TranferArInvoice> Item_TranComplete = null;
        public IEnumerable<BCARINVOICESUB> Item_Return { get; set; }

        private void Frm_TranferPayBill_Load(object sender, EventArgs e)
        {
            dtp_Tranfer.EditValue = DateTime.Now.Date;
            GetSettingWarehouse();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new Action(() => { SplashScreenManager.ShowForm(this, typeof(Frm_WaitProcess), true, true, false); }));
            this.BeginInvoke(new Action(() => { btn_Close.Enabled = false; btn_Tranfer.Enabled = false; btn_Search.Enabled = false; }));
            Fn_LoadDataTran();
        }

        private void GetSettingWarehouse()
        {
            //กำหนด path ที่ต้องการ ซึ่ง path นี้จะอยู่ใน HKEY_CURRENT_USER
            RegistryKey r = Registry.CurrentUser.OpenSubKey(Utility.Server_Path); //เรียกใช้งาน OpenSubKey เพื่อทำให้สามารถเข้าถึง regiskey นี้ได้

            if (r != null)
            {
                if (r.GetValue(Utility._SettingWarehousePath).ToString() != "")
                    Utility._SettingWarehouseValue = r.GetValue(Utility._SettingWarehousePath).ToString();
                else
                    Utility._SettingWarehouseValue = "";
            }
            else
                return;
        }

        private void Fn_LoadDataTran()
        {
            lbl_status.BeginInvoke(new MethodInvoker(delegate { lbl_status.Text = "Status : กำลังโหลดข้อมูลกรุณารอสักครู่......."; ; }));

            using (var srv = new BcArInvoiceSubService(Utility.ConnSDB))
            {
                string[] WhCode = Utility._SettingWarehouseValue.Split(';'); // new string[] { "02", "03" };
                DateTime DtpStart = dtp_Tranfer.DateTime.Date;
                DateTime DtpEnd = dtp_Tranfer.DateTime.Date;
                bool UseDate=chk_DateCurrent.Checked;
                Item_Result = srv.LoadAllForTranferByDate(DtpStart, DtpEnd, UseDate, WhCode); //srv.LoadAllForTranfer(WhCode); //srv.LoadAllForTranferShow("02");
            }
            using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
            {
                Item_TranComplete = srv.LoadAll();
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Fn_LoadDataTranComplete();
            lbl_status.BeginInvoke(new MethodInvoker(delegate { lbl_status.Text = "Status : โหลดข้อมูลเสร็จสิ้น"; }));
            this.BeginInvoke(new Action(() => { btn_Close.Enabled = true;  btn_Search.Enabled = true; }));
            this.BeginInvoke(new Action(() => { SplashScreenManager.CloseForm(false); }));
        }

        private void Fn_LoadDataTranComplete()
        {
            //:::::::::::::::; กรองไม่เอาที่โอนไปแล้ว
            gridControl1.DataSource = Item_Result.Where(c => !Item_TranComplete.Select(t => new { t.ItemCode, t.DocNo, t.LineNumber })
                .Contains(new { c.ItemCode, c.DocNo, c.LineNumber }));// ItemV_bill;
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Tranfer_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int[] rows = gridView1.GetSelectedRows();
                List<BCARINVOICESUB> ItemAdd = new List<BCARINVOICESUB>();
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    var IReture = gridView1.GetRow(rows[i]);
                    ItemAdd.Add((BCARINVOICESUB)IReture);
                }
                Item_Return = ItemAdd;

                DialogResult = DialogResult.OK;
                this.Close();
            }
            //if (list_Rowselect.Items.Count > 0)
            //{
            //    List<string> ItemDocnos = new List<string>();
            //    IEnumerable<BCARINVOICESUB> ItemPays;
            //    int ItemCount = list_Rowselect.Items.Count;
            //    ItemDocnos = list_Rowselect.Items.Cast<string>().ToList();
            //Item_Return=Item_Result.Where(c=)
            //    if (MessageBox.Show("คุณต้องการที่จะโอนข้อมูลวางบิล [จำนวน : " + ItemCount + " ] จาก BC มาหรือไม่", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        using (var srv = new BCPaybillService(Utility.ConnSDB))
            //        {
            //            ItemPays = srv.LoadAll_Selectin(ItemDocnos);
            //        }

            //        List<Finance_Billing> ItemFinanceBill = new List<Finance_Billing>();
            //        foreach (BCPaybill ItemPay in ItemPays)
            //        {
            //            Finance_Billing item = new Finance_Billing();
            //            item.Docdate = ItemPay.DocDate;
            //            item.Docno = ItemPay.DocNo;
            //            item.ArCode = ItemPay.ArCode;
            //            item.Amount = ItemPay.TotalAmount;
            //            item.Status = 0;
            //            item.Create_Date = DateTime.Now;
            //            item.Update_Date = DateTime.Now;
            //            item.Create_User = Utility._UserDB;
            //            item.Update_User = Utility._UserDB;
            //            item.MyDescription = "โอนข้อมูลวางบิลมาจาก BC";
            //            ItemFinanceBill.Add(item);
            //        }
            //        if (ItemFinanceBill.Count > 0)
            //        {
            //            IEnumerable<Finance_Billing> ItemInsert = ItemFinanceBill;
            //            using (var srv = new FinanceBillingService(Utility.ConnSDB))
            //            {
            //                var itemResult = srv.Insert(ItemInsert);
            //                if (itemResult != null)
            //                {
            //                    this.Close();
            //                    //GetDataCustomer();
            //                    //backgroundWorker1.RunWorkerAsync();
            //                    //MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้วครับ", "บันทึกเรียบร้อย", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //                else
            //                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ เนื่องจาก : " + srv.ErrorMessage, "บันทึกข้อมูลไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }

            //    }
            //}
        }


        void Fn_ShowDataSelected()
        {
            txt_RowSelect.Text = string.Format("จำนวนที่เลือก : {0:#,##}", gridView1.SelectedRowsCount);
            if (gridView1.SelectedRowsCount > 0)
                btn_Tranfer.Enabled = true;
            else
                btn_Tranfer.Enabled = false;
            //list_Rowselect.Items.Clear();

            //for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            //{
            //    Application.DoEvents();
            //    if (gridView1.SelectedRowsCount == 0) return;
            //    if (gridView1.GetSelectedRows()[i] >= 0)
            //    {
            //        int Rowselect = gridView1.GetSelectedRows()[i];
            //        string Docno = gridView1.GetRowCellValue(Rowselect, "DocNo").ToString();
            //        string ItemCode = gridView1.GetRowCellValue(Rowselect, "ItemCode").ToString();
            //        string Line = gridView1.GetRowCellValue(Rowselect, "LineNumber").ToString();
            //        list_Rowselect.Items.Add(Docno + ";" + ItemCode + ";" + Line);
            //    }
            //}
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Fn_ShowDataSelected();
        }

        private void chk_DateCurrent_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Tranfer.Enabled = chk_DateCurrent.Checked;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }


    }
}

