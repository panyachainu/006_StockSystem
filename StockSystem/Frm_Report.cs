

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraReports.UI;

using System.Reflection;
using System.Data.OleDb;
using System.Configuration;
using DevExpress.XtraPrinting.Preview;
using Microsoft.Win32;
using System.Data.SqlClient;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;
using StockSystem.Report;
using DevExpress.XtraSplashScreen;

//Use System.Reflection
namespace StockSystem
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }
        public string DocCode { get; set; }
        public int Report_Select { get; set; }


        //private void GetReportSetting()
        //{
        //    //กำหนด path ที่ต้องการ ซึ่ง path นี้จะอยู่ใน HKEY_CURRENT_USER
        //    RegistryKey r = Registry.CurrentUser.OpenSubKey(Utility.Server_PathReport); //เรียกใช้งาน OpenSubKey เพื่อทำให้สามารถเข้าถึง regiskey นี้ได้
        //    if (r == null)
        //    {
        //        Utility.Rpt_Booking = "";
        //        Utility.Rpt_Contract = "";
        //        Utility.Rpt_ReceiptContract = "";
        //        Utility.Rpt_ContractProxy = "";
        //        Utility.Rpt_HouseAndCondo = "";
        //        Utility.Rpt_BookingStatus = "";
        //        Utility.Rpt_ContractStatus = "";
        //        Utility.Rpt_ContractBonus = "";
        //        Utility.Rpt_ContractHistory = "";
        //        Utility.Rpt_SumProxy = "";
        //        return;
        //    }
        //    //ส่วนการจอง
        //    if (r.GetValue("Rpt_Booking").ToString() != "")
        //        Utility.Rpt_Booking = r.GetValue("Rpt_Booking").ToString();
        //    else
        //        Utility.Rpt_Booking = "";

        //    //ส่วนการทำสัญญา
        //    if (r.GetValue("Rpt_Contract").ToString() != "")
        //        Utility.Rpt_Contract = r.GetValue("Rpt_Contract").ToString();
        //    else
        //        Utility.Rpt_Contract = "";


        //    if (r.GetValue("Rpt_ReceiptContract").ToString() != "")
        //        Utility.Rpt_ReceiptContract = r.GetValue("Rpt_ReceiptContract").ToString();
        //    else
        //        Utility.Rpt_ReceiptContract = "";

        //    //โอน 
        //    if (r.GetValue("Rpt_ContractProxy").ToString() != "")
        //        Utility.Rpt_ContractProxy = r.GetValue("Rpt_ContractProxy").ToString();
        //    else
        //        Utility.Rpt_ContractProxy = "";

        //    //รายงาน
        //    if (r.GetValue("Rpt_HouseAndCondo").ToString() != "")
        //        Utility.Rpt_HouseAndCondo = r.GetValue("Rpt_HouseAndCondo").ToString();
        //    else
        //        Utility.Rpt_HouseAndCondo = "";

        //    if (r.GetValue("Rpt_BookingStatus").ToString() != "")
        //        Utility.Rpt_BookingStatus = r.GetValue("Rpt_BookingStatus").ToString();
        //    else
        //        Utility.Rpt_BookingStatus = "";

        //    if (r.GetValue("Rpt_ContractStatus").ToString() != "")
        //        Utility.Rpt_ContractStatus = r.GetValue("Rpt_ContractStatus").ToString();
        //    else
        //        Utility.Rpt_ContractStatus = "";

        //    if (r.GetValue("Rpt_ContractBonus").ToString() != "")
        //        Utility.Rpt_ContractBonus = r.GetValue("Rpt_ContractBonus").ToString();
        //    else
        //        Utility.Rpt_ContractBonus = "";

        //    if (r.GetValue("Rpt_ContractHistory").ToString() != "")
        //        Utility.Rpt_ContractHistory = r.GetValue("Rpt_ContractHistory").ToString();

        //    else
        //        Utility.Rpt_ContractHistory = "";

        //    if (r.GetValue("Rpt_SumProxy").ToString() != "")
        //        Utility.Rpt_SumProxy = r.GetValue("Rpt_SumProxy").ToString();

        //    else
        //        Utility.Rpt_SumProxy = "";
        //}

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            //this.BeginInvoke(new Action(() => { SplashScreenManager.ShowForm(this, typeof(Frm_WaitProcess), true, true, false); }));

            Application.DoEvents();
            Click_SetLookAndFeel();
            //GetReportSetting();//ดึงค่า Setting Reports

        

            string ReportName = "";
            switch (Report_Select)
            {

                case 1: ///----Rpt_Tranfer

                    Rpt_Tranfer rpt1 = new Rpt_Tranfer();
                    ReportName = "Rpt_Tranfer";
                    //XtraReport rpt1 = new XtraReport();
                    //if (Utility.Rpt_Booking != "")
                    //{
                    //    ReportName = Utility.Rpt_Booking;
                    //    rpt1 = XtraReport.FromFile(Utility.Rpt_Booking, true);
                    //    rpt1.PrintingSystem.AddService(typeof(IConnectionProviderService), new CustomConnectionProviderService());
                    //}
                    //else
                    //{
                    //    ReportName = "Rpt_BookingLanna";
                    //    rpt1 = new Rpt_BookingLanna();//Rpt_BookingLanna();
                    //}
                    this.Text = "รายงานการเบิกสินค้า - [" + ReportName + "]";
                    
                    //rpt1.Parameters[0].Value = DocCode;
                    
                    documentViewer1.DocumentSource = rpt1;
                    rpt1.CreateDocument();
                    documentViewer1.DockManager[1].Width = 300;
                    documentViewer1.Refresh();

                    break;
                case 2: ///----Rpt_TranferBalance

                    Rpt_TranferBalance rpt2 = new Rpt_TranferBalance();
                    ReportName = "Rpt_TranferBalance";
                    this.Text = "รายงานยอดคงเหลือสินค้า - [" + ReportName + "]";
                    documentViewer1.DocumentSource = rpt2;
                    rpt2.CreateDocument();
                    documentViewer1.DockManager[1].Width = 300;
                    documentViewer1.Refresh();

                    break;
                case 3: ///----Rpt_StockAll
                    Rpt_StockAll rpt3 = new Rpt_StockAll();
                    ReportName = "Rpt_StockAll";
                    this.Text = "รายงานเคลื่อนไหวสินค้า - [" + ReportName + "]";
                    documentViewer1.DocumentSource = rpt3;
                    rpt3.CreateDocument();
                    documentViewer1.DockManager[1].Width = 300;
                    documentViewer1.Refresh();

                    break;
                case 4: ///----Rpt_StockAll
                    Rpt_TranferRemain rpt4 = new Rpt_TranferRemain();
                    ReportName = "Rpt_TranferRemain";
                    this.Text = "รายงานประวัติการโอนคงค้าง - [" + ReportName + "]";
                    documentViewer1.DocumentSource = rpt4;
                    rpt4.CreateDocument();
                    documentViewer1.DockManager[1].Width = 300;
                    documentViewer1.Refresh();

                    break;
               
            }
            //this.BeginInvoke(new Action(() => { SplashScreenManager.CloseForm(false); }));
        }

        private void Click_SetLookAndFeel()
        {
            documentViewer1.LookAndFeel.UseDefaultLookAndFeel = true;
        }
        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            documentViewer1.LookAndFeel.SkinName = SkinName;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }


    }
}
