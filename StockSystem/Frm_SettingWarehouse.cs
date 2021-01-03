using BC.Models;
using BC.Services;
using Microsoft.Win32;
using StockSystem.Models;
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
    public partial class Frm_SettingWarehouse : Form
    {
        public Frm_SettingWarehouse()
        {
            InitializeComponent();
        }
        IEnumerable<BCWarehouse> Item_BCWarehouse = null;

        private void Frm_SettingWarehouse_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void GetSettingWarehouse()
        {
            // บัคตัวแปรไม่มี
            //กำหนด path ที่ต้องการ ซึ่ง path นี้จะอยู่ใน HKEY_CURRENT_USER
            RegistryKey r = Registry.CurrentUser.OpenSubKey(Utility.Server_Path); //เรียกใช้งาน OpenSubKey เพื่อทำให้สามารถเข้าถึง regiskey นี้ได้

            if (r != null)
            {
                if (r.GetValue(Utility._SettingWarehousePath) != null)
                    Utility._SettingWarehouseValue = r.GetValue(Utility._SettingWarehousePath).ToString();
                else
                    Utility._SettingWarehouseValue = "";

                txt_CodeWarehouse.Text = Utility._SettingWarehouseValue;
            }
            else
                return;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (Utility.MessageQuestion("คุณต้องการ [บันทึกข้อมูล Warehouse] ที่เลือกหรือไม่...กด Yes เพื่อทำการบันทึก") == DialogResult.No)
                    return;

                int[] rows = gridView1.GetSelectedRows();
                List<BCWarehouse> ItemAdd = new List<BCWarehouse>();
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {

                    BCWarehouse IReture = (BCWarehouse)gridView1.GetRow(rows[i]);
                    ItemAdd.Add(IReture);
                }
                SetWarehouse(ItemAdd);

            }
        }

        bool SetWarehouse(List<BCWarehouse> Item)
        {
            try
            {
                string ListWarehouse = "";
                if (Item.Count > 0)
                {
                    foreach (var iadd in Item)
                        ListWarehouse += iadd.Code + ";";

                    if (ListWarehouse.ToString().EndsWith(";"))
                        ListWarehouse = ListWarehouse.ToString().Substring(0, ListWarehouse.Length - 1);

                    RegistryKey r = Registry.CurrentUser.CreateSubKey(Utility.Server_Path);//สร้าง registry ที่ชื่อ MyRegistry1
                    r.SetValue(Utility._SettingWarehousePath, ListWarehouse);
                    r.Close();

                    backgroundWorker1.RunWorkerAsync();
                    Utility.MessageInformation("บันทึกข้อมูลสำเร็จ...");
                }
                return true;
            }
            catch (Exception ex)
            {
                string ErrorMessage = ex.InnerException.Message == null ? ex.Message :
                       ex.InnerException.InnerException.Message == null ? ex.InnerException.Message :
                       ex.InnerException.InnerException.Message;

                Utility.MessageError("บันทึกไม่ได้...เนื่องจาก : " + ErrorMessage);
                return false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            lbl_status.BeginInvoke(new MethodInvoker(delegate { lbl_status.Text = "Status : กำลังโหลดข้อมูลกรุณารอสักครู่......."; ; }));
            this.BeginInvoke(new Action(() => { btn_Save.Enabled = false; }));
            Fn_LoadData();
        }

        private void Fn_LoadData()
        {
            using (var srv = new BCWarehouseService(Utility.ConnSDB))
            {
                Item_BCWarehouse = srv.LoadAll();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Fn_LoadDataCompleted();
            this.BeginInvoke(new Action(() => { btn_Save.Enabled = true; }));
            lbl_status.BeginInvoke(new MethodInvoker(delegate { lbl_status.Text = "Status : โหลดข้อมูลเสร็จสิ้น"; }));
        }

        private void Fn_LoadDataCompleted()
        {
            Grd_Data.DataSource = Item_BCWarehouse;
            GetSettingWarehouse();
        }
    }
}
