namespace StockSystem
{
    partial class Frm_ChangeRunning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangeRunning));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Day = new DevExpress.XtraEditors.TextEdit();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Running = new DevExpress.XtraEditors.SpinEdit();
            this.txt_Format = new DevExpress.XtraEditors.TextEdit();
            this.txt_Year = new DevExpress.XtraEditors.TextEdit();
            this.txt_Month = new DevExpress.XtraEditors.TextEdit();
            this.txt_description = new DevExpress.XtraEditors.TextEdit();
            this.txt_docGroup = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Day.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Running.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Format.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_docGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(326, 246);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txt_Day);
            this.groupControl1.Controls.Add(this.btn_Update);
            this.groupControl1.Controls.Add(this.btn_Close);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.num_Running);
            this.groupControl1.Controls.Add(this.txt_Format);
            this.groupControl1.Controls.Add(this.txt_Year);
            this.groupControl1.Controls.Add(this.txt_Month);
            this.groupControl1.Controls.Add(this.txt_description);
            this.groupControl1.Controls.Add(this.txt_docGroup);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(300, 226);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "วัน :";
            // 
            // txt_Day
            // 
            this.txt_Day.Location = new System.Drawing.Point(122, 109);
            this.txt_Day.Name = "txt_Day";
            this.txt_Day.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Day.Properties.ReadOnly = true;
            this.txt_Day.Size = new System.Drawing.Size(163, 20);
            this.txt_Day.TabIndex = 12;
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(92, 182);
            this.btn_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(101, 37);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "แก้ไขข้อมูล";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(199, 182);
            this.btn_Close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 37);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "ปิดหน้านี้";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "รูปแบบเอกสาร :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "เลข Running ปัจจุบัน :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ปี :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "เดือน :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doc. Group :";
            // 
            // num_Running
            // 
            this.num_Running.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_Running.Location = new System.Drawing.Point(122, 133);
            this.num_Running.Name = "num_Running";
            this.num_Running.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.num_Running.Properties.IsFloatValue = false;
            this.num_Running.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.num_Running.Properties.Mask.EditMask = "N00";
            this.num_Running.Size = new System.Drawing.Size(97, 20);
            this.num_Running.TabIndex = 0;
            // 
            // txt_Format
            // 
            this.txt_Format.Location = new System.Drawing.Point(122, 156);
            this.txt_Format.Name = "txt_Format";
            this.txt_Format.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Format.Properties.ReadOnly = true;
            this.txt_Format.Size = new System.Drawing.Size(163, 20);
            this.txt_Format.TabIndex = 4;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(122, 60);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Year.Properties.ReadOnly = true;
            this.txt_Year.Size = new System.Drawing.Size(163, 20);
            this.txt_Year.TabIndex = 3;
            // 
            // txt_Month
            // 
            this.txt_Month.Location = new System.Drawing.Point(122, 84);
            this.txt_Month.Name = "txt_Month";
            this.txt_Month.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_Month.Properties.ReadOnly = true;
            this.txt_Month.Size = new System.Drawing.Size(163, 20);
            this.txt_Month.TabIndex = 2;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(122, 36);
            this.txt_description.Name = "txt_description";
            this.txt_description.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_description.Properties.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(163, 20);
            this.txt_description.TabIndex = 1;
            // 
            // txt_docGroup
            // 
            this.txt_docGroup.Location = new System.Drawing.Point(122, 13);
            this.txt_docGroup.Name = "txt_docGroup";
            this.txt_docGroup.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txt_docGroup.Properties.ReadOnly = true;
            this.txt_docGroup.Size = new System.Drawing.Size(163, 20);
            this.txt_docGroup.TabIndex = 0;
            // 
            // Frm_ChangeRunning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 246);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ChangeRunning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แก้ไขเลขที่ Running";
            this.Load += new System.EventHandler(this.Frm_ChangeRunning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Day.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Running.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Format.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_docGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit num_Running;
        private DevExpress.XtraEditors.TextEdit txt_Format;
        private DevExpress.XtraEditors.TextEdit txt_Year;
        private DevExpress.XtraEditors.TextEdit txt_Month;
        private DevExpress.XtraEditors.TextEdit txt_description;
        private DevExpress.XtraEditors.TextEdit txt_docGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txt_Day;
    }
}