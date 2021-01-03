
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StockSystem
{
    class Utility
    {
        public static string lps_id = "006";
        public static string lps_ver = "version 1.0.0";//"V.1@01/04/2558#00.00";//MAJOR.MINOR.PATCH  --- เมื่อใช้จิงแล้้วอัพเดท.เปลี่ยน Function/Add.แก้บัก
        public static string lps_verDate = "09/03/2559#00.00";
        public static string Server_Path { get { return "SetDB_Lay\\StockSystem"; } }
        public static string Server_PathRegister { get { return "Software\\SetDB_Lay\\StockSystem"; } }
        public static string _Server_db { get; set; }
        public static string _Name_db { get; set; }
        public static string _UserDB { get; set; }
        public static string _PassDB { get; set; }
        public static string _NameBC { get; set; }

        public static string _SettingWarehousePath { get { return "_ListWarehouse"; } }
        public static string _SettingWarehouseValue { get; set; }


        private static string _Conns;
        public static string ConnSDB
        {
            get { return _Conns; }
        }


        public static void SetDB(string Server, string Database, string UserID, string PassWd)
        {
            _Conns = "Data Source=" + Server + "; Initial Catalog=" + Database + ";Persist Security Info=True;User ID=" + UserID + ";Password=" + PassWd + ";MultipleActiveResultSets=True;app=Contract_System";
        }
        public static string GetConnDBXtraReport()
        {
            return "XpoProvider=MSSqlServer;data source=" + _Server_db + ";user id=" + _UserDB + ";password=" + _PassDB + ";initial catalog=" + _Name_db + ";Persist Security Info=true";
        }
        private static void SetNewConnectionString(string connstringname, string datasource, string initialcatalog, string user, string pwd, string appname)
        {
            // open config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // create new connectionString 
            SqlConnectionStringBuilder connbuilder = new SqlConnectionStringBuilder();
            connbuilder.DataSource = datasource;
            connbuilder.InitialCatalog = initialcatalog;
            connbuilder.UserID = user;
            connbuilder.Password = pwd;
            connbuilder.ApplicationName = appname;

            // set new connectionstring in config
            config.ConnectionStrings.ConnectionStrings[connstringname].ConnectionString = connbuilder.ConnectionString;

            // save and refresh the config file
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static bool ChangeConnectionString(string Name, string value, string providerName, string AppName)
        {
            bool retVal = false;
            try
            {

                string FILE_NAME = string.Concat(Application.StartupPath, "\\", AppName.Trim(), ".exe.Config"); //the application configuration file name
                XmlTextReader reader = new XmlTextReader(FILE_NAME);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                reader.Close();
                string nodeRoute = string.Concat("connectionStrings/add");

                XmlNode cnnStr = null;
                XmlElement root = doc.DocumentElement;
                XmlNodeList Settings = root.SelectNodes(nodeRoute);

                for (int i = 0; i < Settings.Count; i++)
                {
                    cnnStr = Settings[i];
                    if (cnnStr.Attributes["name"].Value.Equals(Name))
                        break;
                    cnnStr = null;
                }

                cnnStr.Attributes["connectionString"].Value = value;
                //cnnStr.Attributes["providerName"].Value = providerName;
                doc.Save(FILE_NAME);
                retVal = true;
            }
            catch (Exception ex)
            {
                retVal = false;
                //Handle the Exception as you like
            }
            return retVal;
        }

        public static void SetComfigForXtraReport()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["ContractConnection"].ConnectionString;
            //string SetCon = "XpoProvider=MSSqlServer;data source=" + _Server_db + ";user id=" + _UserDB + ";password=" + _PassDB + ";initial catalog=" + _Name_db + ";Persist Security Info=true";
            SetNewConnectionString("ContractConnection", _Server_db, _Name_db, _UserDB, _PassDB, "Conctract System");
            //ConnectionStringSettings Conn = new ConnectionStringSettings();
            //Conn.ConnectionString = SetCon;
            //ConfigurationManager.ConnectionStrings.Add(Conn);
            //ConfigurationManager.RefreshSection("connectionStrings");
            //var connectionString2 = ConfigurationManager.ConnectionStrings["ContractConnection"].ConnectionString;
        }

        public static void Form_Show(Form MyForm, Form frmMDI)
        {
            try
            {
                Form[] frmList = frmMDI.MdiChildren;
                for (int i = 0; i < frmList.Length; i++)
                {
                    if (frmList[i].Name == MyForm.Name.ToString())
                    {
                        frmList[i].Activate();
                        return;
                    }
                }
            }
            catch { }
            MyForm.MdiParent = frmMDI;
            MyForm.Show();
            MyForm.WindowState = FormWindowState.Maximized;
        }
        public static void closeAll()
        {
            FormCollection fc = Application.OpenForms;
            if (fc.Count > 1)
            {
                for (int i = (fc.Count); i > 1; i--)
                {
                    Form selectedForm = Application.OpenForms[i - 1];
                    selectedForm.Close();
                }
            }
        }
        public static void SetSkin(string SkinName)
        {
            RegistryKey r = Registry.CurrentUser.CreateSubKey(Utility.Server_Path);//สร้าง registry ที่ชื่อ MyRegistry1
            r.SetValue("_Skin", SkinName);
            r.Close();
        }

        public static string ThaiBaht(string txt)
        {
            string bahtTxt, n, bahtTH = "";
            double amount;
            try { amount = Convert.ToDouble(txt); }
            catch { amount = 0; }
            bahtTxt = amount.ToString("####.00");
            string[] num = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
            string[] rank = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            string[] temp = bahtTxt.Split('.');
            string intVal = temp[0];
            string decVal = temp[1];
            if (Convert.ToDouble(bahtTxt) == 0)
                bahtTH = "ศูนย์บาทถ้วน";
            else
            {
                for (int i = 0; i < intVal.Length; i++)
                {
                    n = intVal.Substring(i, 1);
                    if (n != "0")
                    {
                        if ((i == (intVal.Length - 1)) && (n == "1"))
                            bahtTH += "เอ็ด";
                        else if ((i == (intVal.Length - 2)) && (n == "2"))
                            bahtTH += "ยี่";
                        else if ((i == (intVal.Length - 2)) && (n == "1"))
                            bahtTH += "";
                        else
                            bahtTH += num[Convert.ToInt32(n)];
                        bahtTH += rank[(intVal.Length - i) - 1];
                    }
                }
                bahtTH += "บาท";
                if (decVal == "00")
                    bahtTH += "ถ้วน";
                else
                {
                    for (int i = 0; i < decVal.Length; i++)
                    {
                        n = decVal.Substring(i, 1);
                        if (n != "0")
                        {
                            if ((i == decVal.Length - 1) && (n == "1"))
                                bahtTH += "เอ็ด";
                            else if ((i == (decVal.Length - 2)) && (n == "2"))
                                bahtTH += "ยี่";
                            else if ((i == (decVal.Length - 2)) && (n == "1"))
                                bahtTH += "";
                            else
                                bahtTH += num[Convert.ToInt32(n)];
                            bahtTH += rank[(decVal.Length - i) - 1];
                        }
                    }
                    bahtTH += "สตางค์";
                }
            }
            return bahtTH;
        }

        public static string GetSkin()
        {
            try
            {
                RegistryKey r = Registry.CurrentUser.OpenSubKey(Utility.Server_Path); //เรียกใช้งาน OpenSubKey เพื่อทำให้สามารถเข้าถึง regiskey นี้ได้
                if (r == null) return "Xmas 2008 Blue";
                return r.GetValue("_Skin").ToString();
            }
            catch
            {
                return "";
            }

        }

        public static void MessageInformation(string text)
        {
            MessageBox.Show(text, "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageError(string text)
        {
            MessageBox.Show(text, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MessageQuestion(string text)
        {
            return MessageBox.Show(text, "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        //ReportDocument view = new ReportDocument();
        //        CrystalDecisions.CrystalReports.Engine.ReportDocument view = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt"); //Application.StartupPath.ToString() - bin\Debug
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //        csrReport.RefreshReport();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, DateTime Parameter1)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();

        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parameter1);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1)
        //{

        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.PrintOptions.PaperSize = PaperType;

        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, PaperOrientation PaperOrientation, string Parametor1)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.PrintOptions.PaperSize = PaperType;
        //        view.PrintOptions.PaperOrientation = PaperOrientation;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        //string SSS = Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt";
        //        //MessageBox.Show(SSS);
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.SetParameterValue(2, Parametor3);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3, string Parametor4)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.SetParameterValue(2, Parametor3);
        //        view.SetParameterValue(3, Parametor4);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report_Storeprocedure(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3, string Parametor4)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }

        //        view.Refresh();
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;



        //        view.SetParameterValue("@strWhere", Parametor1); //
        //        view.SetParameterValue("@strOrder", Parametor2); //

        //        view.SetParameterValue(2, Parametor3);
        //        view.SetParameterValue(3, Parametor4);
        //        //Class_L.Test = Parametor1 + " --- " + Parametor2;
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();

        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3, string Parametor4, string Parametor5)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.SetParameterValue(2, Parametor3);
        //        view.SetParameterValue(3, Parametor4);
        //        view.SetParameterValue(4, Parametor5);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3, string Parametor4, string Parametor5, string Parametor6)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.SetParameterValue(2, Parametor3);
        //        view.SetParameterValue(3, Parametor4);
        //        view.SetParameterValue(4, Parametor5);
        //        view.SetParameterValue(5, Parametor6);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3, string Parametor4, string Parametor5, string Parametor6, string Parametor7)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.SetParameterValue(2, Parametor3);
        //        view.SetParameterValue(3, Parametor4);
        //        view.SetParameterValue(4, Parametor5);
        //        view.SetParameterValue(5, Parametor6);
        //        view.SetParameterValue(6, Parametor7);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}
        //public static void Report(CrystalReportViewer csrReport, string strFormula, string strPath, PaperSize PaperType, string Parametor1, string Parametor2, string Parametor3, string Parametor4, string Parametor5, string Parametor6, string Parametor7, string Parametor8)
        //{
        //    try
        //    {
        //        csrReport.ReportSource = null;
        //        ReportDocument view = new ReportDocument();
        //        view.Load(Application.StartupPath.ToString() + "\\report\\" + strPath + ".rpt");
        //        TableLogOnInfo loginfo = new TableLogOnInfo();
        //        ConnectionInfo cinfo = new ConnectionInfo();
        //        cinfo.ServerName = Utility._Server_db;
        //        cinfo.DatabaseName = Utility._Name_db;
        //        cinfo.UserID = Utility._UserDB;
        //        cinfo.Password = Utility._PassDB;

        //        foreach (Table reportTable in view.Database.Tables)
        //        {
        //            loginfo = reportTable.LogOnInfo;
        //            loginfo.ConnectionInfo = cinfo;
        //            reportTable.ApplyLogOnInfo(loginfo);
        //        }
        //        csrReport.Zoom(50);
        //        if (strFormula.Length != 0)
        //            csrReport.SelectionFormula = strFormula;
        //        view.SetParameterValue(0, Parametor1);
        //        view.SetParameterValue(1, Parametor2);
        //        view.SetParameterValue(2, Parametor3);
        //        view.SetParameterValue(3, Parametor4);
        //        view.SetParameterValue(4, Parametor5);
        //        view.SetParameterValue(5, Parametor6);
        //        view.SetParameterValue(6, Parametor7);
        //        view.SetParameterValue(7, Parametor8);
        //        view.PrintOptions.PaperSize = PaperType;
        //        csrReport.ReportSource = view;
        //        csrReport.Refresh();
        //    }
        //    catch (Exception eee)
        //    {
        //        MessageBox.Show(eee.ToString());
        //    }
        //}

    }
}
