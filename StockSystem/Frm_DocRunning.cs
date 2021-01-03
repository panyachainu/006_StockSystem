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
    public partial class Frm_DocRunning : Form
    {
        public Frm_DocRunning()
        {
            InitializeComponent();
        }
        DocumentFormatService db_Format = new DocumentFormatService(Utility.ConnSDB);
        DocumentMenuService db_Menu = new DocumentMenuService(Utility.ConnSDB);
        DocumentRunningService db_Run = new DocumentRunningService(Utility.ConnSDB);
        int Row_Menu = 0;
        int Row_Run = 0;
        string MenuID = "";
        //public int Row_Format { get; set; }
        private void Frm_DocRunning_Load(object sender, EventArgs e)
        {
            Click_SetLookAndFeel();
            //Click_LoadSkin();
            Click_LoadMenu();
        }

        private void Click_SetLookAndFeel()
        {
            groupControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            groupControl2.LookAndFeel.UseDefaultLookAndFeel = true;
            grd_Menu.LookAndFeel.UseDefaultLookAndFeel = true;
            grd_Running.LookAndFeel.UseDefaultLookAndFeel = true;
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Close.LookAndFeel.UseDefaultLookAndFeel = true;
        }

        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            groupControl1.LookAndFeel.SkinName = SkinName;
            groupControl2.LookAndFeel.SkinName = SkinName;
            grd_Menu.LookAndFeel.SkinName = SkinName;
            grd_Running.LookAndFeel.SkinName = SkinName;
            panelControl1.LookAndFeel.SkinName = SkinName;
            btn_Close.LookAndFeel.SkinName = SkinName;
        }
        private void Click_LoadMenu()
        {
            grd_Menu.DataSource = db_Menu.LoadAll();
        }
        private void Click_LoadRunning(string Menu_ID)
        {
            grd_Running.DataSource = db_Run.LoadAll(Menu_ID, "");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Row_Menu = e.RowHandle;
            if (e.RowHandle >= 0)
            {

                Stock_DocumentMenu GData = (Stock_DocumentMenu)gridView1.GetRow(e.RowHandle);
                if (GData != null)
                {
                    groupControl2.Text = "Document Running ของเมนู - [ " + GData.Description + " ]";
                    MenuID = GData.Menu_ID;
                    Click_LoadRunning(GData.Menu_ID);
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuClick_Update_Click(object sender, EventArgs e)
        {
            if (Row_Run < 0) return;
            if (grd_FormatS.RowCount <= 0) return;
            Stock_DocumentRunning GData = (Stock_DocumentRunning)grd_FormatS.GetRow(Row_Run);

            if (GData == null)
            {
                MessageBox.Show("ไม่พบข้อมูลของรูปแบบเอกสาร...กรุณาลองใหม่อีกครั้งครับ","ไม่พบข้อมูล",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Frm_ChangeRunning frm_Run = new Frm_ChangeRunning();
            frm_Run._DataRunning = GData;
            frm_Run.ShowDialog();

            Click_LoadRunning(MenuID);
        }

        private void grd_FormatS_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Row_Run = e.FocusedRowHandle;
        }

    

        
    }
}
