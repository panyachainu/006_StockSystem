

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
using DevExpress.Utils;

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

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            Click_SetLookAndFeel();

            string ReportName = "";
            switch (Report_Select)
            {
                case 1: ///----Rpt_Tranfer

                    Rpt_Tranfer rpt1 = new Rpt_Tranfer();
                    ReportName = "Rpt_Tranfer";
                    this.Text = "รายงานการเบิกสินค้า - [" + ReportName + "]";
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
