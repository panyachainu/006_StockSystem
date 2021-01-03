namespace StockSystem
{
    partial class Frm_CreateMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CreateMenu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_New = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Update = new DevExpress.XtraEditors.TextEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Description = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MenuID = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_New.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Update.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MenuID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(404, 141);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbl_New);
            this.groupControl1.Controls.Add(this.lbl_Update);
            this.groupControl1.Controls.Add(this.btn_Save);
            this.groupControl1.Controls.Add(this.btn_Update);
            this.groupControl1.Controls.Add(this.btn_Close);
            this.groupControl1.Controls.Add(this.txt_Description);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txt_MenuID);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Location = new System.Drawing.Point(12, 9);
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 123);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "เพิ่มข้อมูลเมนูหลัก";
            // 
            // lbl_New
            // 
            this.lbl_New.EditValue = "   New Item";
            this.lbl_New.Location = new System.Drawing.Point(286, 26);
            this.lbl_New.Name = "lbl_New";
            this.lbl_New.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_New.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_New.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_New.Properties.Appearance.Options.UseBackColor = true;
            this.lbl_New.Properties.Appearance.Options.UseFont = true;
            this.lbl_New.Properties.Appearance.Options.UseForeColor = true;
            this.lbl_New.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbl_New.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbl_New.Properties.ReadOnly = true;
            this.lbl_New.Size = new System.Drawing.Size(82, 20);
            this.lbl_New.TabIndex = 35;
            // 
            // lbl_Update
            // 
            this.lbl_Update.EditValue = " Update Item";
            this.lbl_Update.Location = new System.Drawing.Point(286, 26);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Properties.Appearance.BackColor = System.Drawing.Color.Blue;
            this.lbl_Update.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Update.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_Update.Properties.Appearance.Options.UseBackColor = true;
            this.lbl_Update.Properties.Appearance.Options.UseFont = true;
            this.lbl_Update.Properties.Appearance.Options.UseForeColor = true;
            this.lbl_Update.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbl_Update.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbl_Update.Properties.ReadOnly = true;
            this.lbl_Update.Size = new System.Drawing.Size(82, 20);
            this.lbl_Update.TabIndex = 34;
            this.lbl_Update.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(175, 76);
            this.btn_Save.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 37);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "บันทึกข้อมูล";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(175, 76);
            this.btn_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(101, 37);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "แก้ไขข้อมูล";
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(282, 76);
            this.btn_Close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 37);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "ปิดหน้านี้";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(83, 50);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Description.Size = new System.Drawing.Size(285, 20);
            this.txt_Description.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description :";
            // 
            // txt_MenuID
            // 
            this.txt_MenuID.Location = new System.Drawing.Point(83, 26);
            this.txt_MenuID.Name = "txt_MenuID";
            this.txt_MenuID.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_MenuID.Size = new System.Drawing.Size(193, 20);
            this.txt_MenuID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Menu ID :";
            // 
            // Frm_CreateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 141);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_CreateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลเมนูหลัก - [Frm_CreateMenu]";
            this.Load += new System.EventHandler(this.Frm_CreateMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_New.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Update.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MenuID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_Description;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_MenuID;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit lbl_Update;
        private DevExpress.XtraEditors.TextEdit lbl_New;
    }
}