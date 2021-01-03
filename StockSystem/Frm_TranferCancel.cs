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
    public partial class Frm_TranferCancel : Form
    {
        public Frm_TranferCancel()
        {
            InitializeComponent();
        }
        public int _Code { get; set; }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Utility.MessageQuestion("คุณต้องการ [ยกเลิกข้อมูลการโอน] หรือไม่...กด Yes เพื่อทำการยกเลิก") == DialogResult.No)
                return;

            using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
            {
                List<Stock_TranferArInvoice> ItemAdd = new List<Stock_TranferArInvoice>();
                List<Stock_TranferAccrual> ItemLog = new List<Stock_TranferAccrual>();

                Stock_TranferArInvoice Iupdate = srv.GetFind(this._Code);
                if (Iupdate != null)
                {
                    string Remark = txt_Tran_Attribute01.Text.Trim();
                    Iupdate.Tran_Attribute01 = Remark;
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


                using (var srv2 = new StockTranferAccrualService(Utility.ConnSDB))
                {
                    if (srv.Update(ItemAdd) && srv2.Insert(ItemLog))
                    {
                        Utility.MessageInformation("บันทึกข้อมูลสำเร็จ...");
                        DialogResult = DialogResult.Yes;
                        this.Close();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void Frm_TranferCancel_Load(object sender, EventArgs e)
        {
            using (var srv = new StockTranferArInvoiceService(Utility.ConnSDB))
            {
                var Result = srv.GetFind(this._Code);
                if (Result != null)
                {
                    txt_TranDocDate.Text = Result.Tran_DocDate.ToLongDateString();
                    txt_DocNo.Text = Result.DocNo;
                    txt_DocDate.Text = Result.DocDate.Value.ToLongDateString();
                    txt_Line.Text = Result.LineNumber.ToString();
                    txt_ItemCode.Text = Result.ItemCode;
                    txt_ItemName.Text = Result.ItemName;
                    txt_Qty.Text = Result.Qty.Value.ToString("N2");
                    txt_QtyActual.Text = Result.QtyActual.Value.ToString("N2");
                    txt_QtyRemain.Text = Result.QtyRemain.Value.ToString("N2");
                    txt_Tran_Attribute01.Text = Result.Tran_Attribute01;
                }
            }
        }
    }
}
