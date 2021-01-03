using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//<comboBoxEdit1>
using DevExpress.Skins;
//</comboBoxEdit1>
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using Microsoft.Win32;
using StockSystem.Services;
using StockSystem.Models;


namespace StockSystem
{
    public partial class Frm_SetFormat : Form
    {
        public Frm_SetFormat()
        {
            InitializeComponent();
        }
        //string ConnS = "Data Source=it_develop4; Initial Catalog=UMC_2014;Persist Security Info=True;User ID=sa;Password=123456;MultipleActiveResultSets=True;app=Contract_System";

        DocumentFormatService db_Format = new DocumentFormatService(Utility.ConnSDB);
        DocumentMenuService db_Menu = new DocumentMenuService(Utility.ConnSDB);
        DocumentRunningService db_Run = new DocumentRunningService(Utility.ConnSDB);
        int Row_Format = 0;
        int Row_Menu = 0;


        private void Frm_SetFormat_Load(object sender, EventArgs e)
        {

            InitSkinNames(comboBoxEdit1, grd_Menu.LookAndFeel);
            timer1.Enabled = true;
            Click_SetLookAndFeel();
            //Click_LoadSkin();
        }

        private void Click_SetLookAndFeel()
        {
            grd_Menu.LookAndFeel.UseDefaultLookAndFeel = true;
            grd_Format.LookAndFeel.UseDefaultLookAndFeel = true;
            groupControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            groupControl2.LookAndFeel.UseDefaultLookAndFeel = true;
            panelControl1.LookAndFeel.UseDefaultLookAndFeel = true;
            groupControl3.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Save.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Close.LookAndFeel.UseDefaultLookAndFeel = true;
            //swith_DocGroup.LookAndFeel.UseDefaultLookAndFeel = true;
            swith_Month.LookAndFeel.UseDefaultLookAndFeel = true;
            swith_Year.LookAndFeel.UseDefaultLookAndFeel = true;
            rdo_YearLen.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Menu.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_FormatString.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_FormatDisplay.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_DocGroup.LookAndFeel.UseDefaultLookAndFeel = true;
            txt_Description.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Update.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_Clear.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_SaveSkin.LookAndFeel.UseDefaultLookAndFeel = true;
            btn_DocRunning.LookAndFeel.UseDefaultLookAndFeel = true;

        }

        private void Click_LoadSkin()
        {
            string SkinName = Utility.GetSkin();
            grd_Menu.LookAndFeel.SkinName = SkinName;
            grd_Format.LookAndFeel.SkinName = SkinName;
            groupControl1.LookAndFeel.SkinName = SkinName;
            groupControl2.LookAndFeel.SkinName = SkinName;
            panelControl1.LookAndFeel.SkinName = SkinName;
            groupControl3.LookAndFeel.SkinName = SkinName;
            btn_Save.LookAndFeel.SkinName = SkinName;
            btn_Close.LookAndFeel.SkinName = SkinName;
            //swith_DocGroup.LookAndFeel.SkinName = SkinName;
            swith_Month.LookAndFeel.SkinName = SkinName;
            swith_Year.LookAndFeel.SkinName = SkinName;
            rdo_YearLen.LookAndFeel.SkinName = SkinName;
            txt_Menu.LookAndFeel.SkinName = SkinName;
            txt_FormatString.LookAndFeel.SkinName = SkinName;
            txt_FormatDisplay.LookAndFeel.SkinName = SkinName;
            txt_DocGroup.LookAndFeel.SkinName = SkinName;
            txt_Description.LookAndFeel.SkinName = SkinName;
            btn_Update.LookAndFeel.SkinName = SkinName;
            btn_Clear.LookAndFeel.SkinName = SkinName;
            btn_SaveSkin.LookAndFeel.SkinName = SkinName;
            btn_DocRunning.LookAndFeel.SkinName = SkinName;
            comboBoxEdit1.EditValue = SkinName;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Click_ProcessFormat()
        {
            string DocGroup = "", DocYear = "", DocMonth = "", DocDay = "";
            string FormatRunNumber = new string('0', Convert.ToInt32(num_Running.Value));
            string FormatRunDsp = new string('#', Convert.ToInt32(num_Running.Value));

            //if (swith_DocGroup.IsOn)
            DocGroup = txt_DocGroup.Text.Trim();
            //else
            //    DocGroup = "";

            if (swith_Year.IsOn)
                DocYear = new string('Y', Convert.ToInt32(rdo_YearLen.EditValue));
            else
                DocYear = "";

            if (swith_Month.IsOn)
                DocMonth = "MM";
            else
                DocMonth = "";

            if (swith_Day.IsOn)
                DocDay = "DD";
            else
                DocDay = "";

            string FormatDisplay = string.Format("{0}{1}{2}{3}{4}", DocGroup, DocYear, DocMonth, DocDay, FormatRunDsp);
            string FormatString = "{0}{1}{2:00}{3:00}{4:" + FormatRunNumber + "}";
            txt_FormatString.Text = FormatString;
            txt_FormatDisplay.Text = FormatDisplay;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;

            grd_Menu.LookAndFeel.SkinName = cb.EditValue.ToString();
            grd_Format.LookAndFeel.SkinName = cb.EditValue.ToString();
            groupControl1.LookAndFeel.SkinName = cb.EditValue.ToString();
            groupControl2.LookAndFeel.SkinName = cb.EditValue.ToString();
            panelControl1.LookAndFeel.SkinName = cb.EditValue.ToString();
            groupControl3.LookAndFeel.SkinName = cb.EditValue.ToString();
            btn_Save.LookAndFeel.SkinName = cb.EditValue.ToString();
            btn_Close.LookAndFeel.SkinName = cb.EditValue.ToString();
            //swith_DocGroup.LookAndFeel.SkinName = cb.EditValue.ToString();
            swith_Month.LookAndFeel.SkinName = cb.EditValue.ToString();
            swith_Year.LookAndFeel.SkinName = cb.EditValue.ToString();
            rdo_YearLen.LookAndFeel.SkinName = cb.EditValue.ToString();
            txt_Menu.LookAndFeel.SkinName = cb.EditValue.ToString();
            txt_FormatString.LookAndFeel.SkinName = cb.EditValue.ToString();
            txt_FormatDisplay.LookAndFeel.SkinName = cb.EditValue.ToString();
            txt_DocGroup.LookAndFeel.SkinName = cb.EditValue.ToString();
            txt_Description.LookAndFeel.SkinName = cb.EditValue.ToString();
            btn_Update.LookAndFeel.SkinName = cb.EditValue.ToString();
            btn_Clear.LookAndFeel.SkinName = cb.EditValue.ToString();
            btn_SaveSkin.LookAndFeel.SkinName = cb.EditValue.ToString();
            btn_DocRunning.LookAndFeel.SkinName = cb.EditValue.ToString();
        }

        void InitSkinNames(ComboBoxEdit comboBox, UserLookAndFeel lookAndFeel)
        {
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
                comboBox.Properties.Items.Add(cnt.SkinName);
            comboBox.EditValue = lookAndFeel.SkinName;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Row_Menu = e.RowHandle;
            if (e.RowHandle >= 0)
            {

                Stock_DocumentMenu GData = (Stock_DocumentMenu)gridView1.GetRow(e.RowHandle);
                if (GData != null)
                {
                    txt_Menu.Text = string.Format("{0} - {1}", GData.Menu_ID, GData.Description);
                    //txt_MenuID.Text = GData.Menu_ID;
                    groupControl2.Text = "ตั้งค่า Document Format ของเมนู - [ " + GData.Description + " ]";
                    groupControl3.Enabled = true;
                    Click_loadFormat(GData.Menu_ID);
                }
            }
        }

        private void Click_loadFormat(string Menu_ID)
        {
            //var db = new DocumentFormatService();
            grd_Format.DataSource = db_Format.LoadAll(Menu_ID);
            //using (var db = new DocumentFormatService())
            //{
            //    grd_Format.DataSource = db.LoadAll(Menu_ID);
            //}
        }

        private void Click_Clear()
        {

            //swith_DocGroup.IsOn = false;
            txt_DocGroup.Text = "";
            swith_Year.IsOn = false;
            rdo_YearLen.EditValue = 2;
            num_Running.Value = 2;
            swith_Month.IsOn = false;
            swith_Day.IsOn = false;
            txt_Description.Text = "";
            txt_FormatDisplay.Text = "";
            txt_FormatString.Text = "";
            txt_FormatID.Text = "";

            btn_Save.Visible = true;
            lbl_New.Visible = true;
            btn_Update.Visible = false;
            lbl_Update.Visible = false;

            Click_ProcessFormat();
            //Click_LoadMenu();
        }

        private void Click_LoadMenu()
        {
            grd_Menu.DataSource = db_Menu.LoadAll();
            //using (var db = new DocumentMenuService())
            //{
            //    grd_Menu.DataSource = db.LoadAll();
            //}
        }

        private void grd_FormatS_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //Row_Format = e.RowHandle;

            //if (e.RowHandle >= 0)
            //{
            //    DocumentFormat GData = (DocumentFormat)grd_FormatS.GetRow(e.RowHandle);
            //    if (GData != null)
            //    {
            //        //txt_Menu.Text = string.Format("{0} - {1}", GData.Menu_ID, GData.Description);
            //        //groupControl3.Text = "Running - [ " + GData.Description + " ]";
            //        //Click_loadRunning(GData);
            //    }
            //}
        }

        private void Frm_SetFormat_FormClosing(object sender, FormClosingEventArgs e)
        {
            db_Format.Dispose();
            db_Run.Dispose();
            db_Menu.Dispose();
        }

        private void swith_DocGroup_Toggled(object sender, EventArgs e)
        {
            //if (swith_DocGroup.IsOn)
            //{
            //    txt_DocGroup.Text = "";
            //    txt_DocGroup.Enabled = true;
            //    txt_DocGroup.Focus();
            //}
            //else
            //{
            //    txt_DocGroup.Enabled = false;
            //    txt_DocGroup.Text = "";
            //}
            //Click_ProcessFormat();
        }

        private void swith_Year_Toggled(object sender, EventArgs e)
        {
            if (swith_Year.IsOn)
            {
                rdo_YearLen.Enabled = true;
            }
            else
            {
                rdo_YearLen.Enabled = false;
            }
            Click_ProcessFormat();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num_Running_EditValueChanged(object sender, EventArgs e)
        {
            Click_ProcessFormat();
        }

        private void rdo_YearLen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Click_ProcessFormat();
        }

        private void swith_Month_Toggled(object sender, EventArgs e)
        {
            Click_ProcessFormat();
        }


        private void txt_DocGroup_TextChanged(object sender, EventArgs e)
        {
            Click_ProcessFormat();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() == false) return;

            DateTime DateCurrent = db_Run.GetDate();
            if (MessageBox.Show("คุณยืนยันที่จะทำการ [บันทึก] รูปแบบเอกสารนี้หรือไม่ครับ?", "ยืนยันการบันทึก", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Stock_DocumentMenu GData = (Stock_DocumentMenu)gridView1.GetRow(Row_Menu);

                Stock_DocumentFormat item = new Stock_DocumentFormat();
                item.Menu_ID = GData.Menu_ID;
                item.Running_Len = Convert.ToInt32(num_Running.Value);
                item.Prefix_Enable = true;//swith_DocGroup.IsOn;
                item.Prefix = txt_DocGroup.Text.Trim();
                item.Year_Enable = swith_Year.IsOn;
                if (swith_Year.IsOn)
                {
                    item.Year_Len = Convert.ToInt32(rdo_YearLen.EditValue);
                }
                item.Month_Enable = swith_Month.IsOn;
                item.Day_Enable = swith_Day.IsOn;
                item.Description = txt_Description.Text.Trim();

                Stock_DocumentRunning itemR = new Stock_DocumentRunning();
                itemR.Prefix = txt_DocGroup.Text.Trim();
                if (swith_Year.IsOn)
                {
                    int YearR = Convert.ToInt32(rdo_YearLen.EditValue);
                    string SYear = DateCurrent.Year > 2400 ? DateCurrent.Year.ToString() : (DateCurrent.Year + 543).ToString();
                    if (YearR == 4)
                        itemR.DocYear = Convert.ToInt32(SYear.Substring(0, YearR));
                    else
                        itemR.DocYear = Convert.ToInt32(SYear.Substring(2, YearR));
                }
                if (swith_Month.IsOn)
                {
                    itemR.DocMonth = DateCurrent.Month;
                }
                if (swith_Day.IsOn)
                    itemR.DocDay = DateCurrent.Day;

                itemR.LastRunningID = 0;
                itemR.FormatString = txt_FormatString.Text.Trim();
                itemR.FormatDisplay = txt_FormatDisplay.Text.Trim();
                itemR.Description = txt_Description.Text.Trim();
                itemR.Active = 1;

                if (db_Format.ValidateFormat(item))
                {
                    db_Format.Insert(item, itemR);
                    //using (var db_Log = new ContractLogService())
                    //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, item.Format_Id.ToString(), "Insert", "", "Success!!-ข้อมูล Format Running", "DocumentFormat,DocumentRunning");

                }
                else
                {
                    //using (var db_Log = new ContractLogService())
                    //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, item.Format_Id.ToString(), "Insert", "เนื่องจากข้อมูลชุดนี้มีการบันทึกในฐานข้อมูลอยู่แล้ว", "Error!!-ข้อมูล Format Running", "DocumentFormat,DocumentRunning");

                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้...เนื่องจากข้อมูลชุดนี้มีการบันทึกในฐานข้อมูลอยู่แล้ว\nกรุณาเปลี่ยนแปลงรูปแบบ Format ด้วยครับ", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Click_loadFormat(GData.Menu_ID);
                Click_Clear();
            }
        }

        private void MenuClick_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuClick_Delete_Click(object sender, EventArgs e)
        {
            Stock_DocumentFormat GData = (Stock_DocumentFormat)grd_FormatS.GetRow(Row_Format);
            if (GData == null) return;
            using (var Db = new DocumentRunningService(Utility.ConnSDB))
            {
                Stock_DocumentRunning ICheck = Db.GetFind(GData.Format_Id, GData.Menu_ID);
                if (ICheck != null)
                {
                    if (ICheck.LastRunningID > 0)
                    {
                        MessageBox.Show("Running ถูกใช้งานแล้ว [ทั้งหมด : " + ICheck.LastRunningID + "] แล้ว...ไม่สามารถลบได้ครับ", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (MessageBox.Show("คุณต้องการที่จะลบข้อมูลของ  [ " + GData.Prefix + "-" + GData.Description + " ]  หรือไม่ครับ?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    db_Format.Delete(GData.Format_Id, GData.Menu_ID);
                    //using (var db_Log = new ContractLogService())
                    //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, GData.Format_Id.ToString(), "Delete", "", "Success!!-ข้อมูล Format", "DocumentFormat");

                    Click_loadFormat(GData.Menu_ID);
                }
                catch (Exception ex)
                {
                    //using (var db_Log = new ContractLogService())
                    //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, GData.Format_Id.ToString(), "Delete", "", "Error!!-ข้อมูล Format", "DocumentFormat");

                    MessageBox.Show("Error : " + ex.Message, "Error...!!");
                }
            }
        }

        private void MenuClick_New_Click(object sender, EventArgs e)
        {
            Click_Clear();
        }

        private void MenuClick_Update_Click(object sender, EventArgs e)
        {
            if (Row_Format < 0) return;
            if (grd_FormatS.RowCount <= 0) return;
            Stock_DocumentFormat GData = (Stock_DocumentFormat)grd_FormatS.GetRow(Row_Format);
            db_Format = new DocumentFormatService(Utility.ConnSDB);
            var item = db_Format.GetFind(GData.Format_Id, GData.Menu_ID);
            //swith_DocGroup.IsOn = Convert.ToBoolean(item.Prefix_Enable);
            txt_DocGroup.Text = item.Prefix;
            swith_Year.IsOn = Convert.ToBoolean(item.Year_Enable);
            rdo_YearLen.EditValue = item.Year_Len == null ? 2 : item.Year_Len;
            swith_Month.IsOn = Convert.ToBoolean(item.Month_Enable);
            swith_Day.IsOn = Convert.ToBoolean(item.Day_Enable);
            num_Running.Value = Convert.ToDecimal(item.Running_Len);
            txt_Description.Text = item.Description;
            txt_FormatDisplay.Text = item.Stock_DocumentRunning == null ? "" : item.Stock_DocumentRunning.FormatDisplay;
            txt_FormatString.Text = item.Stock_DocumentRunning == null ? "" : item.Stock_DocumentRunning.FormatString;
            txt_FormatID.Text = item.Format_Id.ToString();

            btn_Update.Visible = true;
            lbl_Update.Visible = true;
            btn_Save.Visible = false;
            lbl_New.Visible = false;

        }

        private void grd_FormatS_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            // Row_Format = e.RowHandle;
        }

        private void grd_FormatS_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Row_Format = e.FocusedRowHandle;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() == false) return;
            DateTime DateCurrent = db_Run.GetDate();

            Stock_DocumentMenu GData = (Stock_DocumentMenu)gridView1.GetRow(Row_Menu);
            Stock_DocumentFormat GDataFM = (Stock_DocumentFormat)grd_FormatS.GetRow(Row_Format);
            if (MessageBox.Show("คุณยืนยันที่จะทำการ [แก้ไข] รูปแบบเอกสาร [" + string.Format("{0}-{1}", GDataFM.Menu_ID, GDataFM.Description) + "] นี้หรือไม่ครับ?", "ยืนยันการแก้ไข", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Stock_DocumentFormat item = new Stock_DocumentFormat();
                item.Format_Id = GDataFM.Format_Id;
                item.Menu_ID = GDataFM.Menu_ID;
                item.Running_Len = Convert.ToInt32(num_Running.Value);
                item.Prefix_Enable = true;//swith_DocGroup.IsOn;
                item.Prefix = txt_DocGroup.Text.Trim();
                item.Year_Enable = swith_Year.IsOn;
                item.Day_Enable = swith_Day.IsOn;

                if (swith_Year.IsOn)
                {
                    item.Year_Len = Convert.ToInt32(rdo_YearLen.EditValue);
                }
                item.Month_Enable = swith_Month.IsOn;
                item.Description = txt_Description.Text.Trim();

                Stock_DocumentRunning itemR = db_Run.GetFind(item.Format_Id, item.Menu_ID);// new DocumentRunning();
                bool _ResetRunning = false;

                itemR.Prefix = txt_DocGroup.Text.Trim();
                if (swith_Year.IsOn)
                {
                    int YearR = Convert.ToInt32(rdo_YearLen.EditValue);
                    string SYear = DateCurrent.Year > 2400 ? DateCurrent.Year.ToString() : (DateCurrent.Year + 543).ToString();
                    if (YearR == 4)
                    {
                        if (itemR.DocYear != null)
                        {
                            if (itemR.DocYear.Value.ToString().Length == 4)
                            {
                                if (Convert.ToInt32(SYear.Substring(0, YearR)) > itemR.DocYear)//เทียบปีปัจจุบันว่าเปลี่ยนไปหรือป่าว
                                {
                                    itemR.DocYear = Convert.ToInt32(SYear.Substring(0, YearR));
                                    _ResetRunning = true;
                                }
                            }
                            else//ไม่เคยมี Setting นี้
                            {
                                if (itemR.DocYear.Value.ToString().Length == 2)//เช็คว่าอันเดิมเป็น 2 ตำแหน่งหรือไม่ แล้วทำการเปรียบเทียบว่า ปีเท่ากันมั้ย
                                {
                                    if (Convert.ToInt32(SYear.Substring(2, 2)) > itemR.DocYear)//เทียบปีปัจจุบันว่าเปลี่ยนไปหรือป่าว
                                    {
                                        itemR.DocYear = Convert.ToInt32(SYear.Substring(0, YearR));
                                        _ResetRunning = true;
                                    }
                                    else
                                        itemR.DocYear = Convert.ToInt32(SYear.Substring(0, YearR));
                                }
                                else
                                {
                                    itemR.DocYear = Convert.ToInt32(SYear.Substring(0, YearR));
                                    _ResetRunning = true;
                                }
                            }
                        }
                        else//ไม่เคยมี Setting นี้
                        {
                            itemR.DocYear = Convert.ToInt32(SYear.Substring(0, YearR));
                            _ResetRunning = true;
                        }
                    }
                    else
                    {
                        if (itemR.DocYear != null)
                        {
                            if (itemR.DocYear.Value.ToString().Length == 2)
                            {
                                if (Convert.ToInt32(SYear.Substring(2, YearR)) > itemR.DocYear)//เทียบปีปัจจุบันว่าเปลี่ยนไปหรือป่าว
                                {
                                    itemR.DocYear = Convert.ToInt32(SYear.Substring(2, YearR));
                                    _ResetRunning = true;
                                }
                            }
                            else//ไม่เคยมี Setting นี้
                            {
                                if (itemR.DocYear.Value.ToString().Length == 4)//เช็คว่าอันเดิมเป็น 4 ตำแหน่งหรือไม่ แล้วทำการเปรียบเทียบว่า ปีเท่ากันมั้ย
                                {
                                    if (Convert.ToInt32(SYear.Substring(0, 4)) > itemR.DocYear)//เทียบปีปัจจุบันว่าเปลี่ยนไปหรือป่าว
                                    {
                                        itemR.DocYear = Convert.ToInt32(SYear.Substring(2, YearR));
                                        _ResetRunning = true;
                                    }
                                    else
                                        itemR.DocYear = Convert.ToInt32(SYear.Substring(2, YearR));
                                }
                                else
                                {
                                    itemR.DocYear = Convert.ToInt32(SYear.Substring(2, YearR));
                                    _ResetRunning = true;
                                }
                            }
                        }
                        else//ไม่เคยมี Setting นี้
                        {
                            itemR.DocYear = Convert.ToInt32(SYear.Substring(2, YearR));
                            _ResetRunning = true;
                        }
                    }
                }
                else
                    itemR.DocYear = null;

                if (swith_Month.IsOn)
                {
                    if (itemR.DocMonth != null)
                    {
                        if (DateCurrent.Month > itemR.DocMonth)
                        {
                            itemR.DocMonth = DateCurrent.Month;
                            _ResetRunning = true;
                        }
                    }
                    else//ไม่เคยปี Setting นี้
                    {
                        itemR.DocMonth = DateCurrent.Month;
                        _ResetRunning = true;
                    }
                }
                else
                    itemR.DocMonth = null;

                if (swith_Day.IsOn)
                {
                    if (itemR.DocDay != null)
                    {
                        if (DateCurrent.Day > itemR.DocDay)
                        {
                            itemR.DocDay = DateCurrent.Day; ;
                            _ResetRunning = true;
                        }
                    }
                    else//ไม่เคยปี Setting นี้
                    {
                        itemR.DocDay = DateCurrent.Day;
                        _ResetRunning = true;
                    }
                }
                else
                    itemR.DocDay = null;

                if (_ResetRunning)// Reset Running is 0 
                    itemR.LastRunningID = 0;

                itemR.FormatString = txt_FormatString.Text.Trim();
                itemR.FormatDisplay = txt_FormatDisplay.Text.Trim();
                itemR.Description = txt_Description.Text.Trim();
                itemR.Active = 1;


                db_Format.Update(item, itemR);

                //using (var db_Log = new ContractLogService())
                //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, item.Format_Id.ToString(), "Update", "", "Success!!-ข้อมูล Format Running", "DocumentFormat,DocumentRunning");

                Click_loadFormat(GData.Menu_ID);
                Click_Clear();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Click_Clear();
        }

        private void btn_SaveSkin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะบันทึก Skin : " + comboBoxEdit1.EditValue.ToString() + " นี้หรือไม่ครับ?", "บันทึก Skin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utility.SetSkin(comboBoxEdit1.EditValue.ToString());

                //using (var db_Log = new ContractLogService())
                //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, "", "Save Skin", "", "comboBoxEdit1.EditValue.ToString()", "");
            }
        }

        private void Menu_MClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_MNew_Click(object sender, EventArgs e)
        {

            Frm_CreateMenu F_Menu = new Frm_CreateMenu();
            F_Menu.StatusNew = true;
            F_Menu.ShowDialog();
            if (Frm_CreateMenu.SuccessFrmLogin)
                Click_LoadMenu();
        }

        private void Menu_MUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Row_Menu < 0) return;
                Stock_DocumentMenu GData = (Stock_DocumentMenu)gridView1.GetRow(Row_Menu);
                Frm_CreateMenu F_Menu = new Frm_CreateMenu();
                F_Menu.StatusNew = false;
                F_Menu.ItemUpdate = GData;
                F_Menu.ShowDialog();
                if (Frm_CreateMenu.SuccessFrmLogin)
                    Click_LoadMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!...::" + ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Menu_MDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Stock_DocumentMenu GData = (Stock_DocumentMenu)gridView1.GetRow(Row_Menu);
                if (GData == null) return;

                using (var db = new DocumentRunningService(Utility.ConnSDB))
                {
                    bool DeleteS = true;
                    var Item = db.LoadAllWhereMenu(GData.Menu_ID);
                    if (Item.Count() > 0)
                    {
                        foreach (var Icheck in Item)
                        {
                            if (Icheck.LastRunningID > 0)
                            {
                                MessageBox.Show("ไม่สามารถลบข้อมูลเมนูได้...เนื่องจาก Running มีการใช้งานไปแล้วครับ", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                DeleteS = false;
                                break;
                            }
                        }
                    }
                    if (DeleteS == false)
                        return;
                }

                if (MessageBox.Show("คุณต้องการที่จะลบเมนู [" + GData.Menu_ID + "-" + GData.Description + "] หรือไม่ครับ?\nมีผลต่อ Format ที่ถูกตั้งค่าไปแล้วและเลขที่เอกสารที่ใช้ไปแล้ว จะถูกลบทั้งหมด", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db_Menu.Delete(GData);
                    //using (var db_Log = new ContractLogService())
                    //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, GData.Menu_ID, "Delete", "", "Success!!-ข้อมูลเมนู", "DocumentMenu");

                    Click_LoadMenu();
                    Click_loadFormat(GData.Menu_ID);
                }
            }
            catch (Exception ex)
            {
                //using (var db_Log = new ContractLogService())
                //    db_Log.InsertLog("", Utility._UserDB, DateTime.Now, this.Text, "", "Delete", "", "Error!!-ข้อมูลเมนู", "DocumentMenu");

                MessageBox.Show("Error!!...::" + ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DocRunning_Click(object sender, EventArgs e)
        {
            Frm_DocRunning F_Run = new Frm_DocRunning();
            F_Run.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Click_LoadMenu();
            Click_ProcessFormat();
            groupControl3.Enabled = false;
            timer1.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Row_Menu = e.FocusedRowHandle;
        }

        private void swith_Day_Toggled(object sender, EventArgs e)
        {
            Click_ProcessFormat();
        }


    }
}
