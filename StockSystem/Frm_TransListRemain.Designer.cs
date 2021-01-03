﻿namespace StockSystem
{
    partial class Frm_TransListRemain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TransListRemain));
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chk_DateCurrent = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Tranfer = new DevExpress.XtraEditors.DateEdit();
            this.dtp_TranferEnd = new DevExpress.XtraEditors.DateEdit();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_RowSelect = new DevExpress.XtraEditors.TextEdit();
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.grd_Data = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSparklineEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit();
            this.repositoryItemSpinEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker_Remain = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_DateCurrent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Tranfer.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Tranfer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_TranferEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_TranferEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RowSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btn_Cancel);
            this.panelControl1.Controls.Add(this.txt_RowSelect);
            this.panelControl1.Controls.Add(this.btn_Close);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.lbl_Status);
            this.panelControl1.Controls.Add(this.grd_Data);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1154, 526);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_DateCurrent);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.dtp_Tranfer);
            this.groupControl1.Controls.Add(this.dtp_TranferEnd);
            this.groupControl1.Controls.Add(this.btn_Search);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 80);
            this.groupControl1.TabIndex = 75;
            this.groupControl1.Text = "ค้นหาตามวันที่";
            // 
            // chk_DateCurrent
            // 
            this.chk_DateCurrent.EditValue = true;
            this.chk_DateCurrent.Location = new System.Drawing.Point(15, 44);
            this.chk_DateCurrent.Name = "chk_DateCurrent";
            this.chk_DateCurrent.Properties.Caption = "ดูตามวันที่ :";
            this.chk_DateCurrent.Size = new System.Drawing.Size(75, 19);
            this.chk_DateCurrent.TabIndex = 71;
            this.chk_DateCurrent.CheckedChanged += new System.EventHandler(this.chk_DateCurrent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "ถึง";
            // 
            // dtp_Tranfer
            // 
            this.dtp_Tranfer.EditValue = null;
            this.dtp_Tranfer.Location = new System.Drawing.Point(96, 44);
            this.dtp_Tranfer.Name = "dtp_Tranfer";
            this.dtp_Tranfer.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtp_Tranfer.Properties.Appearance.Options.UseBackColor = true;
            this.dtp_Tranfer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Tranfer.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Tranfer.Properties.DisplayFormat.FormatString = "D";
            this.dtp_Tranfer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtp_Tranfer.Properties.Mask.EditMask = "D";
            this.dtp_Tranfer.Size = new System.Drawing.Size(198, 20);
            this.dtp_Tranfer.TabIndex = 72;
            // 
            // dtp_TranferEnd
            // 
            this.dtp_TranferEnd.EditValue = null;
            this.dtp_TranferEnd.Location = new System.Drawing.Point(325, 44);
            this.dtp_TranferEnd.Name = "dtp_TranferEnd";
            this.dtp_TranferEnd.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtp_TranferEnd.Properties.Appearance.Options.UseBackColor = true;
            this.dtp_TranferEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_TranferEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_TranferEnd.Properties.DisplayFormat.FormatString = "D";
            this.dtp_TranferEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtp_TranferEnd.Properties.Mask.EditMask = "D";
            this.dtp_TranferEnd.Size = new System.Drawing.Size(198, 20);
            this.dtp_TranferEnd.TabIndex = 73;
            // 
            // btn_Search
            // 
            this.btn_Search.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btn_Search.Appearance.Options.UseFont = true;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(529, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(135, 44);
            this.btn_Search.TabIndex = 70;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Enabled = false;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(1009, 171);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 44);
            this.btn_Cancel.TabIndex = 69;
            this.btn_Cancel.Text = "ยกเลิกการโอน";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_RowSelect
            // 
            this.txt_RowSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RowSelect.Location = new System.Drawing.Point(1009, 95);
            this.txt_RowSelect.Name = "txt_RowSelect";
            this.txt_RowSelect.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_RowSelect.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_RowSelect.Properties.ReadOnly = true;
            this.txt_RowSelect.Size = new System.Drawing.Size(133, 20);
            this.txt_RowSelect.TabIndex = 68;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Appearance.Options.UseFont = true;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(1009, 458);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(133, 44);
            this.btn_Close.TabIndex = 67;
            this.btn_Close.Text = "ปิดหน้านี้";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Enabled = false;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(1009, 121);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 44);
            this.btn_Save.TabIndex = 66;
            this.btn_Save.Text = "บันทึกโอน";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 507);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 6;
            // 
            // grd_Data
            // 
            this.grd_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_Data.Cursor = System.Windows.Forms.Cursors.Default;
            this.grd_Data.Location = new System.Drawing.Point(12, 98);
            this.grd_Data.MainView = this.gridView1;
            this.grd_Data.Name = "grd_Data";
            this.grd_Data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2,
            this.repositoryItemSparklineEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemSpinEdit4,
            this.repositoryItemCheckEdit1});
            this.grd_Data.Size = new System.Drawing.Size(991, 404);
            this.grd_Data.TabIndex = 5;
            this.grd_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3});
            this.grd_Data.Click += new System.EventHandler(this.grd_Data_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn13,
            this.gridColumn16,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.grd_Data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "กรอกข้อมูลที่ต้องการค้นหา";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "รายการโอนคงค้าง";
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "เลขที่เอกสาร";
            this.gridColumn3.FieldName = "DocNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DocNo", "RowCount : {0:#,###}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "รหัสสินค้า";
            this.gridColumn6.FieldName = "ItemCode";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 101;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "วันที่เอกสาร";
            this.gridColumn7.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn7.FieldName = "DocDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 96;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.repositoryItemDateEdit2.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.repositoryItemDateEdit2.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "D";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "D";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "จำนวนค้างโอน";
            this.gridColumn8.ColumnEdit = this.repositoryItemSpinEdit3;
            this.gridColumn8.FieldName = "QtyRemain";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 97;
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.DisplayFormat.FormatString = "N2";
            this.repositoryItemSpinEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemSpinEdit3.EditFormat.FormatString = "N2";
            this.repositoryItemSpinEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            this.repositoryItemSpinEdit3.NullText = "0";
            this.repositoryItemSpinEdit3.ValidateOnEnterKey = true;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "ชื่อสินค้า";
            this.gridColumn13.FieldName = "ItemName";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 7;
            this.gridColumn13.Width = 220;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "gridColumn16";
            this.gridColumn16.FieldName = "Status";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.Caption = "จำนวนเบิก";
            this.gridColumn1.ColumnEdit = this.repositoryItemSpinEdit3;
            this.gridColumn1.FieldName = "QtyActual";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 89;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Line";
            this.gridColumn2.FieldName = "LineNumber";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 31;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "จำนวนคงค้าง";
            this.gridColumn4.ColumnEdit = this.repositoryItemSpinEdit3;
            this.gridColumn4.FieldName = "QtyRemain_Temp";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.ShowUnboundExpressionMenu = true;
            this.gridColumn4.UnboundExpression = "[QtyRemain] - [QtyActual]";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "เลขที่โอน";
            this.gridColumn5.FieldName = "Tran_DocNo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 104;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "วันที่โอน";
            this.gridColumn9.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn9.FieldName = "Tran_DocDate";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 99;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "หมายเหตุ";
            this.gridColumn10.FieldName = "Tran_Attribute01";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 11;
            this.gridColumn10.Width = 216;
            // 
            // repositoryItemSparklineEdit2
            // 
            this.repositoryItemSparklineEdit2.Name = "repositoryItemSparklineEdit2";
            this.repositoryItemSparklineEdit2.View = lineSparklineView1;
            // 
            // repositoryItemSpinEdit4
            // 
            this.repositoryItemSpinEdit4.AutoHeight = false;
            this.repositoryItemSpinEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit4.DisplayFormat.FormatString = "N2";
            this.repositoryItemSpinEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemSpinEdit4.EditFormat.FormatString = "N2";
            this.repositoryItemSpinEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemSpinEdit4.Name = "repositoryItemSpinEdit4";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22});
            this.gridView3.GridControl = this.grd_Data;
            this.gridView3.Name = "gridView3";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "เลขที่เอกสาร";
            this.gridColumn19.FieldName = "DocNo";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 83;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "ชำระครั้งที่";
            this.gridColumn20.FieldName = "RepaymentSet";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 83;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "ประเภทการชำระ";
            this.gridColumn21.FieldName = "PaymentType";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            this.gridColumn21.Width = 107;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "จำนวนเงิน";
            this.gridColumn22.FieldName = "PayAmount";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 3;
            this.gridColumn22.Width = 524;
            // 
            // backgroundWorker_Remain
            // 
            this.backgroundWorker_Remain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Remain_DoWork);
            this.backgroundWorker_Remain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Remain_RunWorkerCompleted);
            // 
            // Frm_TransListRemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 526);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_TransListRemain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ รายการโอนคงค้าง ]";
            this.Load += new System.EventHandler(this.Frm_TransListRemain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_DateCurrent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Tranfer.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Tranfer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_TranferEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_TranferEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RowSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grd_Data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit repositoryItemSparklineEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private System.Windows.Forms.Label lbl_Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Remain;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_RowSelect;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtp_TranferEnd;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraEditors.DateEdit dtp_Tranfer;
        private DevExpress.XtraEditors.CheckEdit chk_DateCurrent;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}