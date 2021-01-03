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

namespace StockSystem
{
    public partial class Frm_RegisterSystem : Form
    {
        public Frm_RegisterSystem()
        {
            InitializeComponent();
        }
        private static bool _Success = true;

        public static bool SuccessFrmLogin
        {
            get { return _Success; }

        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            _Success = false;
            this.Close();
            //Application.Exit();
        }

        private void Frm_RegisterSystem_Load(object sender, EventArgs e)
        {
            txt_SerialN.Text = UtilitySecurity.SerailMachineAndVersion();
            Click_SetLookAndFeel();
            //Click_LoadSkin();
        }

        private void Click_SetLookAndFeel()
        {
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Activate.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_SerialN.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Close.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Save.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Title.LookAndFeel.UseDefaultLookAndFeel = true;
        }

        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            panelControl1.LookAndFeel.SkinName = SkinName;
            txt_Activate.LookAndFeel.SkinName = SkinName;
            txt_SerialN.LookAndFeel.SkinName = SkinName;
            btn_Close.LookAndFeel.SkinName = SkinName;
            btn_Save.LookAndFeel.SkinName = SkinName;
            btn_Title.LookAndFeel.SkinName = SkinName;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SerialN.Text != "" && txt_Activate.Text != "")
            {
                if (SetRegister())
                {
                    /// Success
                    MessageBox.Show("Register 'Success' ... ยินดีตอนรับเข้าสู่โปรแกรมครับ", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Success = true;
                    this.Close();
                }
                else
                {
                    /// Faile
                    MessageBox.Show("Register 'Fail' ... คุณทำการลงทะเบียนไม่สำเร็จ กรุณาลองอีกครั้งครับ", "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _Success = false;
                }
            }
            else
                MessageBox.Show("กรุณากรอกรหัส Activate ก่อนครับ", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        bool SetRegister()
        {
            string SerialN = txt_SerialN.Text.Trim();
            string ActivateCode = txt_Activate.Text.Trim();
            if (UtilitySecurity.VerifyRegister(ActivateCode, SerialN))
            {
                RegistryKey r = Registry.CurrentUser.CreateSubKey(Utility.Server_PathRegister);//สร้าง registry ที่ชื่อ MyRegistry1
                r.SetValue(UtilitySecurity._NameSerialNumber, SerialN);
                r.SetValue(UtilitySecurity._NameActivateCode, ActivateCode);
                r.Close();
                return true;
            }
            return false;
        }
    }
}
