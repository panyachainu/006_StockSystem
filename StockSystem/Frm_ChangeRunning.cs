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
    public partial class Frm_ChangeRunning : Form
    {
        public Frm_ChangeRunning()
        {
            InitializeComponent();
        }
        public Stock_DocumentRunning _DataRunning { get; set; }

        private void Frm_ChangeRunning_Load(object sender, EventArgs e)
        {
            Click_SetLookAndFeel();
            //Click_LoadSkin();
            Click_LoadData();
        }

        private void Click_SetLookAndFeel()
        {
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            groupControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_description.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_docGroup.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Format.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Month.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Year.LookAndFeel.UseDefaultLookAndFeel = true;
            num_Running.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Update.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Close.LookAndFeel.UseDefaultLookAndFeel = true;
        }

        private void Click_LoadData()
        {
            if (_DataRunning != null)
            {
                using (var db = new DocumentRunningService(Utility.ConnSDB))
                {
                    Stock_DocumentRunning Item = db.GetFind(_DataRunning.Format_Id, _DataRunning.Menu_ID);
                    if (Item != null)
                    {
                        txt_docGroup.Text = Item.Prefix;
                        txt_description.Text = Item.Description;
                        txt_Format.Text = Item.FormatDisplay;
                        txt_Month.Text = string.Format("{0:00}", Item.DocMonth == null ? 0 : Item.DocMonth);
                        txt_Year.Text = Convert.ToString(Item.DocYear == null ? 0 : Item.DocYear);
                        txt_Day.Text = Convert.ToString(Item.DocDay == null ? 0 : Item.DocDay);
                        num_Running.Value = Convert.ToDecimal(Item.LastRunningID);
                    }
                }
            }
        }
        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            panelControl1.LookAndFeel.SkinName = SkinName;
            groupControl1.LookAndFeel.SkinName = SkinName;
            txt_description.LookAndFeel.SkinName = SkinName;
            txt_docGroup.LookAndFeel.SkinName = SkinName;
            txt_Format.LookAndFeel.SkinName = SkinName;
            txt_Month.LookAndFeel.SkinName = SkinName;
            txt_Year.LookAndFeel.SkinName = SkinName;
            num_Running.LookAndFeel.SkinName = SkinName;
            btn_Update.LookAndFeel.SkinName = SkinName;
            btn_Close.LookAndFeel.SkinName = SkinName;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุุณต้องการที่จะทำการ [แก้ไขเลข Running] หรือไม่ครับ", "แก้ไข Running", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _DataRunning.LastRunningID = Convert.ToInt32(num_Running.Value);
                using (var db = new DocumentRunningService(Utility.ConnSDB))
                {
                    var ss = db.Update(_DataRunning);

                    /////---เก็บ Log
                    //using (var db_Log = new ContractLogService())
                    //{
                    //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, _DataRunning.Format_Id.ToString(), "Update", "", "Update Last Running = " + _DataRunning.LastRunningID.Value.ToString() + "", "DocumentRunning");
                    //}
                    this.Close();
                }
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
