namespace StockSystem
{
    partial class Frm_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Pass = new DevExpress.XtraEditors.TextEdit();
            this.txt_User = new DevExpress.XtraEditors.TextEdit();
            this.txt_Db = new DevExpress.XtraEditors.TextEdit();
            this.txt_Server = new DevExpress.XtraEditors.TextEdit();
            this.btn_SelectDB = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ok = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Db.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_Pass);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.txt_Db);
            this.panel1.Controls.Add(this.txt_Server);
            this.panel1.Controls.Add(this.btn_SelectDB);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Ok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 214);
            this.panel1.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.EditValue = "";
            this.dxValidationProvider1.SetIconAlignment(this.txt_Pass, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txt_Pass.Location = new System.Drawing.Point(180, 126);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Pass.Properties.Mask.BeepOnError = true;
            this.txt_Pass.Properties.PasswordChar = '*';
            this.txt_Pass.Properties.ValidateOnEnterKey = true;
            this.txt_Pass.Size = new System.Drawing.Size(137, 20);
            this.txt_Pass.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "กรุณากรอก Password ด้วยครับ";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txt_Pass, conditionValidationRule1);
            this.txt_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pass_KeyPress);
            // 
            // txt_User
            // 
            this.dxValidationProvider1.SetIconAlignment(this.txt_User, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txt_User.Location = new System.Drawing.Point(180, 104);
            this.txt_User.Name = "txt_User";
            this.txt_User.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_User.Properties.Mask.BeepOnError = true;
            this.txt_User.Properties.ValidateOnEnterKey = true;
            this.txt_User.Size = new System.Drawing.Size(137, 20);
            this.txt_User.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "กรุณากรอก User ด้วยครับ";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txt_User, conditionValidationRule2);
            // 
            // txt_Db
            // 
            this.dxValidationProvider1.SetIconAlignment(this.txt_Db, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txt_Db.Location = new System.Drawing.Point(180, 82);
            this.txt_Db.Name = "txt_Db";
            this.txt_Db.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Db.Properties.Mask.BeepOnError = true;
            this.txt_Db.Properties.ValidateOnEnterKey = true;
            this.txt_Db.Size = new System.Drawing.Size(137, 20);
            this.txt_Db.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "กรุณากรอกชื่อ Database ด้วยครับ";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txt_Db, conditionValidationRule3);
            // 
            // txt_Server
            // 
            this.dxValidationProvider1.SetIconAlignment(this.txt_Server, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txt_Server.Location = new System.Drawing.Point(180, 60);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Server.Properties.Mask.BeepOnError = true;
            this.txt_Server.Size = new System.Drawing.Size(137, 20);
            this.txt_Server.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "กรุณากรอกชื่อ Server ด้วยครับ";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txt_Server, conditionValidationRule4);
            // 
            // btn_SelectDB
            // 
            this.btn_SelectDB.Image = ((System.Drawing.Image)(resources.GetObject("btn_SelectDB.Image")));
            this.btn_SelectDB.Location = new System.Drawing.Point(328, 39);
            this.btn_SelectDB.Name = "btn_SelectDB";
            this.btn_SelectDB.Size = new System.Drawing.Size(81, 23);
            this.btn_SelectDB.TabIndex = 6;
            this.btn_SelectDB.Text = "เลือกฐาน";
            this.btn_SelectDB.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(252, 150);
            this.btn_Cancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(65, 29);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(181, 150);
            this.btn_Ok.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(65, 29);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(87, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Server :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(87, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Database :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(73, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(113, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "User :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "4 ต.ค. 2550  11.00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 214);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login !";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Db.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_SelectDB;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Ok;
        private DevExpress.XtraEditors.TextEdit txt_Server;
        private DevExpress.XtraEditors.TextEdit txt_Pass;
        private DevExpress.XtraEditors.TextEdit txt_User;
        private DevExpress.XtraEditors.TextEdit txt_Db;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}