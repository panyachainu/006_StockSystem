using DevExpress.XtraEditors.DXErrorProvider;
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

using BC.Services;
using BC.DataAccess;
using System.Deployment.Application;
using DevExpress.XtraBars.Alerter;
namespace StockSystem
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private static bool _Success;

        public static bool SuccessFrmLogin
        {
            get { return _Success; }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _Success = false;
            this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

            GetRedit();
            Click_SetLookAndFeel();
            //Click_LoadSkin();
            txt_Server.Text = Utility._Server_db;
            txt_Db.Text = Utility._Name_db;
            txt_User.Text = Utility._UserDB;
            this.Text = "Login  [ Last Date : " + Utility.lps_verDate + " ]";
            label4.Text = string.Format("[Offline] Stock System - V{0}", Utility.lps_ver);

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                label4.Text = string.Format("[Online] Stock System - V{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
            txt_Pass.Focus();
            txt_Pass.SelectAll();
        }

        private void Click_SetLookAndFeel()
        {
            txt_Db.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Pass.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Server.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_User.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Cancel.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Ok.LookAndFeel.UseDefaultLookAndFeel = true;
        }

        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            txt_Db.LookAndFeel.SkinName = SkinName;
            txt_Pass.LookAndFeel.SkinName = SkinName;
            txt_Server.LookAndFeel.SkinName = SkinName;
            txt_User.LookAndFeel.SkinName = SkinName;
            btn_Cancel.LookAndFeel.SkinName = SkinName;
            btn_Ok.LookAndFeel.SkinName = SkinName;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() == false) return;
            RegistryKey r = Registry.CurrentUser.CreateSubKey(Utility.Server_Path);//สร้าง registry ที่ชื่อ MyRegistry1
            string PassWord = password.Encrypt(txt_Pass.Text.Trim());
            r.SetValue("_Server_db", txt_Server.Text.Trim());
            r.SetValue("_Name_db", txt_Db.Text.Trim());
            r.SetValue("_UserDB", txt_User.Text.Trim());
            r.SetValue("_PassDB", PassWord);
            r.Close();
            try
            {
                GetRedit();
                Utility.SetDB(Utility._Server_db, Utility._Name_db, Utility._UserDB, Utility._PassDB);

                //--------- set Connection Report
                if (Utility.ChangeConnectionString("ReportConnection", Utility.GetConnDBXtraReport(), "MSSqlServer", "StockSystem") == false)
                {
                    MessageBox.Show("ไม่สามารถ Setting Config ConnectionString ของ XtraReport ได้", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //-------------------------
                //Utility.SetComfigForXtraReport();
                CheckConnectionService db = new CheckConnectionService();
                Cls_SetDB.Conns = Utility.ConnSDB;
                db.CheckOpen(Utility.ConnSDB);

                

                //using (var srv = new BCSaleService())
                //{
                //    Utility._NameBC = srv.Name(txt_User.Text.Trim());
                //}
                MessageBox.Show("ยินดีต้อนรับ  เข้าสู่...โปรแกรมครับ", "เข้าสู้โปรแกรม", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Success = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อ Server ได้ เนื่องจาก : " + ex.Message, "Login Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Success = false;
            }

        }

        private void GetRedit()
        {
            //กำหนด path ที่ต้องการ ซึ่ง path นี้จะอยู่ใน HKEY_CURRENT_USER
            RegistryKey r = Registry.CurrentUser.OpenSubKey(Utility.Server_Path); //เรียกใช้งาน OpenSubKey เพื่อทำให้สามารถเข้าถึง regiskey นี้ได้
            if (r == null) return;
            Utility._Server_db = r.GetValue("_Server_db").ToString();
            Utility._Name_db = r.GetValue("_Name_db").ToString();
            Utility._UserDB = r.GetValue("_UserDB").ToString();
            Utility._PassDB = password.Decrypt(r.GetValue("_PassDB").ToString());
        }

        private void txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Ok_Click(sender, e);
            }
        }
    }
}
