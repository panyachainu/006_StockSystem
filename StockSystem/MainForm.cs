using DevExpress.XtraBars;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Localization;
using BC.Services;
using DevExpress.XtraBars.Alerter;
using System.Deployment.Application;

namespace StockSystem
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool GetRegister()
        {
            RegistryKey r = Registry.CurrentUser.OpenSubKey(Utility.Server_PathRegister);
            if (r == null) return false;
            string SerailNumber = r.GetValue(UtilitySecurity._NameSerialNumber).ToString().Trim();
            string ActivateCode = r.GetValue(UtilitySecurity._NameActivateCode).ToString().Trim();

            string SerailCurrent = UtilitySecurity.SerailMachineAndVersion();
            if (SerailCurrent != SerailNumber) return false;
            return UtilitySecurity.VerifyRegister(ActivateCode, SerailNumber);
        }

        //// Custom localizer that changes skin captions 
        private void MainForm_Load(object sender, EventArgs e)
        {
            BarLocalizer.Active = new BarLocalizer();
            SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);

            ToolStatus_User.Text = "";
            ToolStatus_ConnectDB.Text = "";

            Click_LoadSkin();
            bool CheckRegis = GetRegister();
            if (CheckRegis == false)
            {
                Frm_RegisterSystem FRegis = new Frm_RegisterSystem();
                FRegis.ShowDialog();
                if (Frm_RegisterSystem.SuccessFrmLogin)
                {
                    Frm_Login F_Login = new Frm_Login();
                    F_Login.ShowDialog();
                    if (Frm_Login.SuccessFrmLogin == false) Application.Exit();
                    else
                        backgroundWorker1.RunWorkerAsync();
                }
                else
                    Application.Exit();
            }
            else
            {
                Frm_Login F_Login = new Frm_Login();
                F_Login.ShowDialog();
                if (Frm_Login.SuccessFrmLogin == false) Application.Exit();
                else
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }

            ToolStatus_User.Text = "ผู้ใช้งาน : " + Utility._NameBC;
            ToolStatus_ConnectDB.Text = "ฐานข้อมูล : " + Utility._Name_db + " , เชิฟเวอร์ : " + Utility._Server_db;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                lbl_Version.Text = string.Format("| [Online] Contract System - V{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
        }

        private void Click_LoadSkin()
        {
        }

        private void Menu_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Btn_SkinSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            string SkinNameSelect = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
            if (MessageBox.Show("คุณต้องการที่จะบันทึก Skin : " + SkinNameSelect + " นี้หรือไม่ครับ?", "บันทึก Skin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utility.SetSkin(SkinNameSelect);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ToolStatus_Time.Text = DateTime.Now.ToString("วัน dddd ที่ d เดือน MMMM พ.ศ.yyyy  เวลา HH:mm:ss น.");
        }



        private void alertControl1_BeforeFormShow(object sender, AlertFormEventArgs e)
        {

            e.AlertForm.OpacityLevel = 0.7;
            e.AlertForm.Size = new Size(300, 110);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var srv = new BCSaleService(Utility.ConnSDB))
                Utility._NameBC = srv.Name(Utility._NameBC);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Show a sample alert window.
            Image img = imageCollection1.Images[0];
            AlertInfo info = new AlertInfo("Login Success!!", "ยินดีต้อนรับ [ คุณ " + Utility._NameBC + " ] เข้าสู่...โปรแกรมครับ", "Login!", img);
            alertControl1.Show(this, info);
        }

        private void Menu_BIlling_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_TranferARInvoice frm = new Frm_TranferARInvoice();
            Utility.Form_Show(frm, this);
        }

        private void Menu_DocFormat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SetFormat FrmChild = new Frm_SetFormat();
            Utility.Form_Show(FrmChild, this);
        }

        private void Menu_DocRunning_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DocRunning F_Run = new Frm_DocRunning();
            F_Run.ShowDialog();
        }

        private void Menu_Payment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_TransListRemain frm = new Frm_TransListRemain();
            Utility.Form_Show(frm, this);
        }

        private void Menu_Report1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Report frm = new Frm_Report();
            frm.Report_Select = 1;
            frm.Show();
        }

        private void Menu_Report2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Report frm = new Frm_Report();
            frm.Report_Select = 2;
            frm.Show();
        }

        private void barStaticItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_SettingWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SettingWarehouse frm = new Frm_SettingWarehouse();
            frm.ShowDialog();
        }

        private void Menu_Report3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Report frm = new Frm_Report();
            frm.Report_Select = 3;
            frm.Show();
        }

        private void Menu_TranferAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ListTranSuccess frm = new Frm_ListTranSuccess();
            Utility.Form_Show(frm, this);
        }

        private void Menu_Report4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Report frm = new Frm_Report();
            frm.Report_Select = 4;
            frm.Show();
        }
       
    }
}
