namespace StockSystem
{
    partial class Frm_TranferCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TranferCancel));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_SaveCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_QtyRemain = new DevExpress.XtraEditors.TextEdit();
            this.txt_QtyActual = new DevExpress.XtraEditors.TextEdit();
            this.txt_Qty = new DevExpress.XtraEditors.TextEdit();
            this.txt_ItemName = new DevExpress.XtraEditors.TextEdit();
            this.txt_ItemCode = new DevExpress.XtraEditors.TextEdit();
            this.txt_Line = new DevExpress.XtraEditors.TextEdit();
            this.txt_DocDate = new DevExpress.XtraEditors.TextEdit();
            this.txt_DocNo = new DevExpress.XtraEditors.TextEdit();
            this.txt_TranDocDate = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tran_Attribute01 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QtyRemain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QtyActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Line.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DocDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DocNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TranDocDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tran_Attribute01.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_SaveCancel);
            this.panelControl1.Controls.Add(this.btn_Close);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(602, 326);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_SaveCancel
            // 
            this.btn_SaveCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCancel.Appearance.Options.UseFont = true;
            this.btn_SaveCancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveCancel.Image")));
            this.btn_SaveCancel.Location = new System.Drawing.Point(473, 12);
            this.btn_SaveCancel.Name = "btn_SaveCancel";
            this.btn_SaveCancel.Size = new System.Drawing.Size(117, 44);
            this.btn_SaveCancel.TabIndex = 69;
            this.btn_SaveCancel.Text = "บันทึกยกเลิก";
            this.btn_SaveCancel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Appearance.Options.UseFont = true;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(473, 270);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(117, 44);
            this.btn_Close.TabIndex = 68;
            this.btn_Close.Text = "ปิดหน้านี้";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.txt_QtyRemain);
            this.groupControl1.Controls.Add(this.txt_QtyActual);
            this.groupControl1.Controls.Add(this.txt_Qty);
            this.groupControl1.Controls.Add(this.txt_ItemName);
            this.groupControl1.Controls.Add(this.txt_ItemCode);
            this.groupControl1.Controls.Add(this.txt_Line);
            this.groupControl1.Controls.Add(this.txt_DocDate);
            this.groupControl1.Controls.Add(this.txt_DocNo);
            this.groupControl1.Controls.Add(this.txt_TranDocDate);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txt_Tran_Attribute01);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(453, 302);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "รายละเอียดการโอนข้อมูล";
            // 
            // txt_QtyRemain
            // 
            this.txt_QtyRemain.Location = new System.Drawing.Point(119, 221);
            this.txt_QtyRemain.Name = "txt_QtyRemain";
            this.txt_QtyRemain.Properties.ReadOnly = true;
            this.txt_QtyRemain.Size = new System.Drawing.Size(232, 20);
            this.txt_QtyRemain.TabIndex = 20;
            // 
            // txt_QtyActual
            // 
            this.txt_QtyActual.Location = new System.Drawing.Point(119, 197);
            this.txt_QtyActual.Name = "txt_QtyActual";
            this.txt_QtyActual.Properties.ReadOnly = true;
            this.txt_QtyActual.Size = new System.Drawing.Size(232, 20);
            this.txt_QtyActual.TabIndex = 19;
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(119, 173);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Properties.ReadOnly = true;
            this.txt_Qty.Size = new System.Drawing.Size(232, 20);
            this.txt_Qty.TabIndex = 18;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(119, 150);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Properties.ReadOnly = true;
            this.txt_ItemName.Size = new System.Drawing.Size(320, 20);
            this.txt_ItemName.TabIndex = 17;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.Location = new System.Drawing.Point(119, 127);
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.Properties.ReadOnly = true;
            this.txt_ItemCode.Size = new System.Drawing.Size(232, 20);
            this.txt_ItemCode.TabIndex = 16;
            // 
            // txt_Line
            // 
            this.txt_Line.Location = new System.Drawing.Point(119, 103);
            this.txt_Line.Name = "txt_Line";
            this.txt_Line.Properties.ReadOnly = true;
            this.txt_Line.Size = new System.Drawing.Size(232, 20);
            this.txt_Line.TabIndex = 15;
            // 
            // txt_DocDate
            // 
            this.txt_DocDate.Location = new System.Drawing.Point(119, 79);
            this.txt_DocDate.Name = "txt_DocDate";
            this.txt_DocDate.Properties.ReadOnly = true;
            this.txt_DocDate.Size = new System.Drawing.Size(232, 20);
            this.txt_DocDate.TabIndex = 14;
            // 
            // txt_DocNo
            // 
            this.txt_DocNo.Location = new System.Drawing.Point(119, 55);
            this.txt_DocNo.Name = "txt_DocNo";
            this.txt_DocNo.Properties.ReadOnly = true;
            this.txt_DocNo.Size = new System.Drawing.Size(232, 20);
            this.txt_DocNo.TabIndex = 13;
            // 
            // txt_TranDocDate
            // 
            this.txt_TranDocDate.Location = new System.Drawing.Point(119, 31);
            this.txt_TranDocDate.Name = "txt_TranDocDate";
            this.txt_TranDocDate.Properties.ReadOnly = true;
            this.txt_TranDocDate.Size = new System.Drawing.Size(232, 20);
            this.txt_TranDocDate.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "หมายเหตุยกเลิก : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "จำนวนคงค้าง : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "จำนวนเบิก : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "จำนวนสินค้า : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ชื่อสินค้า : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "รหัสสินค้า : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "วันที่เอกสาร : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "เลขที่เอกสาร : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "วันที่โอน : ";
            // 
            // txt_Tran_Attribute01
            // 
            this.txt_Tran_Attribute01.Location = new System.Drawing.Point(118, 244);
            this.txt_Tran_Attribute01.Name = "txt_Tran_Attribute01";
            this.txt_Tran_Attribute01.Size = new System.Drawing.Size(321, 52);
            this.txt_Tran_Attribute01.TabIndex = 0;
            // 
            // Frm_TranferCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 326);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_TranferCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-[ ยกเลิกโอนข้อมูล ]-";
            this.Load += new System.EventHandler(this.Frm_TranferCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QtyRemain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QtyActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Line.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DocDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DocNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TranDocDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tran_Attribute01.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_SaveCancel;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.MemoEdit txt_Tran_Attribute01;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_QtyRemain;
        private DevExpress.XtraEditors.TextEdit txt_QtyActual;
        private DevExpress.XtraEditors.TextEdit txt_Qty;
        private DevExpress.XtraEditors.TextEdit txt_ItemName;
        private DevExpress.XtraEditors.TextEdit txt_ItemCode;
        private DevExpress.XtraEditors.TextEdit txt_Line;
        private DevExpress.XtraEditors.TextEdit txt_DocDate;
        private DevExpress.XtraEditors.TextEdit txt_DocNo;
        private DevExpress.XtraEditors.TextEdit txt_TranDocDate;

    }
}