using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using System.Text;

namespace StockSystem.Report
{
    public partial class Rpt_TranferBalance : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpt_TranferBalance()
        {
            InitializeComponent();
            this.StockDB.Connection.ConnectionString = Utility.ConnSDB;
        }

        string _PItemName1 = "";
        string _PItemName2 = "";
        string _PItemGroup1 = "";
        string _PItemGroup2 = "";
        string _PItemWH1 = "";
        string _PItemWH2 = "";

        private void Rpt_Tranfer_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //lbl_UserPrint.Text = "ผู้พิมพ์ : " + Utility._UserDB;
            ////[ItemCode] Between(?ItemCode1, ?ItemCode2)
            ////[GroupItemCode] Between(?ItemGroup1, ?ItemGroup2)

            //DateTime PDateTemp1 = DateTime.Parse(Date1.Value.ToString());
            //DateTime PDateTemp2 = DateTime.Parse(Date2.Value.ToString());
            //string PDate1 = PDateTemp1.Date.ToString("yyyy-MM-dd");
            //string PDate2 = PDateTemp2.Date.ToString("yyyy-MM-dd");
            string PItemCode = ItemCode1.Value.ToString();
            string PItemCode2 = ItemCode2.Value.ToString();
            string PItemGroup = ItemGroup1.Value.ToString();
            string PItemGroup2 = ItemGroup2.Value.ToString();
            string PWH1 = ItemWH1.Value.ToString();
            string PWH2 = ItemWH2.Value.ToString();

            //string WDate = string.Format("[Tran_DocDate] Between(?Date1, ?Date2)");
            string WItemCode = string.Format("[ItemCode] Between(?ItemCode1, ?ItemCode2)");
            string WItemGroup = string.Format("[GroupItemCode] Between(?ItemGroup1, ?ItemGroup2)");
            string WWH = string.Format("[WHCode] Between(?ItemWH1, ?ItemWH2)");

            StringBuilder Where = new StringBuilder();
            StringBuilder WhereString = new StringBuilder();

            WhereString.AppendLine("เงื่อนไขการเลือก");

            //if (PDate1 != "" && PDate2 != "")
            //{
            //    Where.Append(string.Format("{0} {1}", WDate, "And"));// Where.Length > 0 ? "And" : ""
            //    //---------------------------------------------------------------------------------
            //    WhereString.AppendLine(string.Format("จากวันที่ : {0}      ถึงวันที่ : {1}", DateTime.Parse(PDate1).Date, DateTime.Parse(PDate2).Date));
            //    lbl_Header.Text = string.Format("{0}   ถึงวันที่ {1}", DateTime.Parse(PDate1).Date.ToLongDateString(), DateTime.Parse(PDate2).Date.ToLongDateString());
            //}
            if (PItemCode != "" && PItemCode2 != "")
            {
                Where.Append(string.Format("{0} {1}", WItemCode, "And"));// Where.Length > 0 ? "And" : ""
                //---------------------------------------------------------------------------------
                WhereString.AppendLine(string.Format("สินค้า : {0}      ถึงสินค้า : {1}", _PItemName1, _PItemName2));
            }
            if (PItemGroup != "" && PItemGroup2 != "")
            {
                Where.Append(string.Format("{0} {1}", WItemGroup, "And"));// Where.Length > 0 ? "And" : ""
                //---------------------------------------------------------------------------------
                WhereString.AppendLine(string.Format("กลุ่มสินค้า : {0}      ถึงกลุ่มสินค้า : {1}", _PItemGroup1, _PItemGroup2));
            }
            if (PWH1 != "" && PWH2 != "")
            {
                Where.Append(string.Format("{0} {1}", WWH, "And"));// Where.Length > 0 ? "And" : ""
                //---------------------------------------------------------------------------------
                WhereString.AppendLine(string.Format("คลังที่ : {0}      ถึงคลังที่ : {1}", _PItemWH1, _PItemWH2));
            }

            lbl_Where.Text = WhereString.ToString();
            lbl_UserPrint.Text = "ผู้พิมพ์ : " + Utility._UserDB;

            string FilterString = "";
            if (Where.ToString().EndsWith("And"))
                FilterString = Where.ToString().Substring(0, Where.Length - 3);
            else
                FilterString = Where.ToString();

            ((XtraReport)sender).FilterString = FilterString;

        }

        private void Rpt_Tranfer_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //Date1.Value = DateTime.Now.Date;
            //Date2.Value = DateTime.Now.Date;

            //foreach (ParameterInfo info in e.ParametersInformation)
            //{
            //    if (info.Parameter.Type == typeof(DateTime))
            //    {
            //        //Show a DateTime edit including the time portion for datetime parameters
            //        DateEdit deParameter = info.Editor as DateEdit;
            //        deParameter.EditValue = DateTime.Now.Date;
            //        deParameter.Properties.Mask.EditMask = "dd/MM/yyyy";
            //        deParameter.Properties.Mask.UseMaskAsDisplayFormat = true;
            //    }
            //}
        }

        private void Rpt_Tranfer_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "ItemCode1")
                {
                    _PItemName1 = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                    //break;
                }
                if (info.Parameter.Name == "ItemCode2")
                {
                    _PItemName2 = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                    //break;
                }
                if (info.Parameter.Name == "ItemGroup1")
                {
                    _PItemGroup1 = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                    //break;
                }
                if (info.Parameter.Name == "ItemGroup2")
                {
                    _PItemGroup2 = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                    //break;
                }
                if (info.Parameter.Name == "ItemWH1")
                {
                    _PItemWH1 = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                    //break;
                }
                if (info.Parameter.Name == "ItemWH2")
                {
                    _PItemWH2 = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                    //break;
                }
            }
        }

    }
}
