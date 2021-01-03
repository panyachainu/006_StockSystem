using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockSystem.Models;
using StockSystem.Services;

namespace StockSystem
{
    public partial class Frm_CreateMenu : Form
    {
        public Frm_CreateMenu()
        {
            InitializeComponent();
        }
        private static bool _Success;
        public static bool SuccessFrmLogin
        {
            get { return _Success; }
        }
        public bool StatusNew { get; set; }
        public Stock_DocumentMenu ItemUpdate { get; set; }

        DocumentMenuService db_Menu = new DocumentMenuService(Utility.ConnSDB);

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะ [แก้ไขข้อมูล] ของเมนูหลักหรือไม่ครับ?", "บัยทึกเมนูหลัก", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (txt_MenuID.Text != "" && txt_Description.Text != "")
            {
                Stock_DocumentMenu Item = new Stock_DocumentMenu();
                Item.Menu_ID = txt_MenuID.Text.Trim();
                Item.Description = txt_Description.Text.Trim();
                db_Menu.Update(Item);
                _Success = true;
                this.Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะ [บันทึกข้อมูล] ของเมนูหลักหรือไม่ครับ?", "บัยทึกเมนูหลัก", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (txt_MenuID.Text != "" && txt_Description.Text != "")
            {
                Stock_DocumentMenu Item = new Stock_DocumentMenu();
                Item.Menu_ID = txt_MenuID.Text.Trim();
                Item.Description = txt_Description.Text.Trim();
                db_Menu.Insert(Item);

                //using (var db_Log = new ContractLogService())
                //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, Item.Menu_ID, "Insert", "", "Success!! - บัยทึกเมนูหลัก", "DocumentMenu");


                _Success = true;
                this.Close();
            }
        }

        private void Frm_CreateMenu_Load(object sender, EventArgs e)
        {
            Click_SetLookAndFeel();
            //Click_LoadSkin();
            if (StatusNew)
            {
                txt_MenuID.Enabled = true;
                btn_Save.Visible = true;
                lbl_New.Visible = true;
                btn_Update.Visible = false;
                lbl_Update.Visible = false;
            }
            else
            {
                btn_Save.Visible = false;
                lbl_New.Visible = false;
                btn_Update.Visible = true;
                lbl_Update.Visible = true;
                if (ItemUpdate != null)
                {
                    txt_MenuID.Text = ItemUpdate.Menu_ID;
                    txt_MenuID.Enabled = false;
                    txt_Description.Text = ItemUpdate.Description;
                }
            }
        }

        private void Click_SetLookAndFeel()
        {
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            groupControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Description.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_MenuID.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Close.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Save.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Update.LookAndFeel.UseDefaultLookAndFeel = true;
        }

        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            panelControl1.LookAndFeel.SkinName = SkinName;
            groupControl1.LookAndFeel.SkinName = SkinName;
            txt_Description.LookAndFeel.SkinName = SkinName;
            txt_MenuID.LookAndFeel.SkinName = SkinName;
            btn_Close.LookAndFeel.SkinName = SkinName;
            btn_Save.LookAndFeel.SkinName = SkinName;
            btn_Update.LookAndFeel.SkinName = SkinName;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _Success = false;
            this.Close();
        }
    }
}
