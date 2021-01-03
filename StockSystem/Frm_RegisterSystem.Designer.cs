namespace StockSystem
{
    partial class Frm_RegisterSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegisterSystem));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Title = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Activate = new DevExpress.XtraEditors.TextEdit();
            this.txt_SerialN = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Activate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SerialN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Title);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txt_Activate);
            this.panelControl1.Controls.Add(this.txt_SerialN);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.btn_Close);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(445, 222);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Title
            // 
            this.btn_Title.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btn_Title.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Title.Appearance.Options.UseFont = true;
            this.btn_Title.Appearance.Options.UseForeColor = true;
            this.btn_Title.Image = ((System.Drawing.Image)(resources.GetObject("btn_Title.Image")));
            this.btn_Title.Location = new System.Drawing.Point(20, 5);
            this.btn_Title.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Title.Name = "btn_Title";
            this.btn_Title.Size = new System.Drawing.Size(405, 103);
            this.btn_Title.TabIndex = 44;
            this.btn_Title.Text = "Contract System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Activate Code :";
            // 
            // txt_Activate
            // 
            this.txt_Activate.Location = new System.Drawing.Point(102, 140);
            this.txt_Activate.Name = "txt_Activate";
            this.txt_Activate.Size = new System.Drawing.Size(323, 20);
            this.txt_Activate.TabIndex = 0;
            // 
            // txt_SerialN
            // 
            this.txt_SerialN.Location = new System.Drawing.Point(102, 114);
            this.txt_SerialN.Name = "txt_SerialN";
            this.txt_SerialN.Properties.ReadOnly = true;
            this.txt_SerialN.Size = new System.Drawing.Size(323, 20);
            this.txt_SerialN.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Serial Number :";
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(21, 166);
            this.btn_Save.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 46);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Register";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(324, 166);
            this.btn_Close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(101, 46);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "ปิดหน้านี้";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Frm_RegisterSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 222);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_RegisterSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ Register - ContractSystem ]";
            this.Load += new System.EventHandler(this.Frm_RegisterSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Activate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SerialN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_Activate;
        private DevExpress.XtraEditors.TextEdit txt_SerialN;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_Title;
    }
}