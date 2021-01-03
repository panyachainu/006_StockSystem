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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class Frm_ListTranSuccess : Form
    {
        public Frm_ListTranSuccess()
        {
            InitializeComponent();
        }

        IEnumerable<Stock_TranferArInvoice> Item_TranAll = null;
        public int RowSelect { get; set; }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ListTranSuccess_Load(object sender, EventArgs e)
        {
            dtp_Tranfer.EditValue = DateTime.Now.Date;
            dtp_TranferEnd.EditValue = DateTime.Now.Date;
        }

        private void backgroundWorker_ShowData_DoWork(object sender, DoWorkEventArgs e)
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
                List<int> Status = new List<int>();
                if (ck_0.Checked)
                    Status.Add(0);
                if (Ck_1.Checked)
                    Status.Add(1);
                if (ck_2.Checked)
                    Status.Add(2);

                Item_TranAll = srv.LoadAll(DtpStart, DtpEnd, UserDate, Status);
            }
        }

        private void backgroundWorker_ShowData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //var predicate = PredicateBuilder.True<Stock_TranferArInvoice>();
            //if (ck_0.Checked)//โอนเสร็จสิ้น
            //{
            //    predicate = predicate.Or(c => c.QtyRemain == 0 && c.Tran_StatusClear == 0);
            //}
            //if (Ck_1.Checked)//รายการค้างโอน
            //{
            //    predicate = predicate.Or(c => c.QtyRemain > 0 && c.Tran_StatusClear != 0);
            //}
            //if (ck_2.Checked)//ยกเลิกโอน
            //{
            //    predicate = predicate.Or(c => c.Tran_StatusClear == 1);
            //}


            grd_Data.DataSource = Item_TranAll;//Item_TranAll.Where<Stock_TranferArInvoice>(predicate.Compile());
            this.BeginInvoke(new Action(() =>
            {
                lbl_Status.Text = "Status : โหลดข้อมูลสำเร็จ...จำนวนข้อมูลทั้งหมด " + Item_TranAll.Count() + " แถว";
                btn_Search.Enabled = true;
                btn_Close.Enabled = true;
            }));
            this.BeginInvoke(new Action(() => { SplashScreenManager.CloseForm(false); }));
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            backgroundWorker_ShowData.RunWorkerAsync();
        }

        private void chk_DateCurrent_CheckedChanged(object sender, EventArgs e)
        {
            dtp_Tranfer.Enabled = dtp_TranferEnd.Enabled = chk_DateCurrent.Checked;
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Tran_StatusClear = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Tran_StatusClear"]);
                string Status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Status"]);
                decimal QtyRemain = Convert.ToDecimal(View.GetRowCellDisplayText(e.RowHandle, View.Columns["QtyRemain"]));

                //0 : โอนสำเร็จ  1 : ค้างโอน  2 : ยกเลิก
                if (Status == "1")// 1 : ค้างโอน
                {
                    e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
                    e.Appearance.BackColor2 = Color.FromArgb(192, 255, 192);
                }
                else if (Status == "2")// 2 : ยกเลิก
                {
                    e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
                    e.Appearance.BackColor2 = Color.FromArgb(255, 192, 192); //Color.SeaShell;
                }

                //if (QtyRemain > 0)//คงค้าง
                //{
                //    e.Appearance.BackColor = Color.FromArgb(192, 255, 192);
                //    e.Appearance.BackColor2 = Color.FromArgb(192, 255, 192);
                //}
                //if (Tran_StatusClear == "1")//ยกเลิก
                //{
                //    e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
                //    e.Appearance.BackColor2 = Color.FromArgb(255, 192, 192); //Color.SeaShell;
                //}
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            if (txt_TranDocNo.Text == "")
                return;
            Frm_TranferARInvoice frm = new Frm_TranferARInvoice();
            frm._TranDocNo_Display = txt_TranDocNo.Text.Trim();
            frm.ShowDialog();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RowSelect = e.FocusedRowHandle;
            if (RowSelect < 0) return;
            if (gridView1.RowCount <= 0) return;
            if (gridView1.GetRowCellValue(RowSelect, "Tran_DocNo") == null) return;
            string item = gridView1.GetRowCellValue(RowSelect, "Tran_DocNo").ToString();
            string Status = gridView1.GetRowCellValue(RowSelect, "Status").ToString();//0 : โอนสำเร็จ  1 : ค้างโอน  2 : ยกเลิก
            string Rownumber = gridView1.GetRowCellValue(RowSelect, "ROWORDER").ToString();

            if (Status != "")
            {
                if (Status == "0")
                    btn_DeleteTranfer.Enabled = true;
                else
                    btn_DeleteTranfer.Enabled = false;
            }

            if (item == "") return;
            txt_TranDocNo.Text = item;
            txt_RowNumber.Text = Rownumber;
            btn_Display.Enabled = true;
        }

        private void btn_DeleteTranfer_Click(object sender, EventArgs e)
        {
            if (txt_RowNumber.Text == "")
            {
                MessageBox.Show("กรุณาเลือกรายการที่จะทำการยกเลิกก่อนครับ...", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_TranferCancel frm = new Frm_TranferCancel();
            frm._Code = Convert.ToInt32(txt_RowNumber.Text.Trim());
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                backgroundWorker_ShowData.RunWorkerAsync();
            }
        }

    }


}
