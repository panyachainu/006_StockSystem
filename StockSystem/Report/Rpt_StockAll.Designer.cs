namespace StockSystem.Report
{
    partial class Rpt_StockAll
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_StockAll));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings3 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings4 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.StockDB = new DevExpress.DataAccess.Sql.SqlDataSource("._CPSConnection");
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lbl_Where = new DevExpress.XtraReports.UI.XRRichText();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lbl_UserPrint = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Date1 = new DevExpress.XtraReports.Parameters.Parameter();
            this.Date2 = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemCode1 = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemCode2 = new DevExpress.XtraReports.Parameters.Parameter();
            this.F_Balance = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.ItemGroup1 = new DevExpress.XtraReports.Parameters.Parameter();
            this.ItemGroup2 = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Where)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // StockDB
            // 
            customSqlQuery1.Name = "StockAll";
            customSqlQuery1.Sql = "select Top 1 * from VStock_TranferAllTableReport";
            customSqlQuery2.Name = "BCConfigurations";
            customSqlQuery2.Sql = "select * from BCConfigurations";
            customSqlQuery3.Name = "StockAll_Item";
            customSqlQuery3.Sql = "select distinct itemcode, itemcode+\' - \'+itemname as itemname from VStock_Tranfer" +
    "AllTableReport order by itemCode\r\n";
            customSqlQuery4.Name = "SotckAll_Group";
            customSqlQuery4.Sql = "select distinct Groupcode,Groupcode+\' - \'+ GroupName as GroupName from VStock_Tra" +
    "nferAllTableReport order by GroupCode\r\n";
            this.StockDB.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3,
            customSqlQuery4});
            this.StockDB.ResultSchemaSerializable = resources.GetString("StockDB.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrLine2});
            this.Detail.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Detail.HeightF = 30.70833F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DocDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(43.33334F, 3.125F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1072.667F, 25F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell7,
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell6,
            this.xrTableCell3});
            this.xrTableRow1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseFont = false;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.DocDate", "{0:dd MMM yyyy}")});
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Weight = 0.24019476973851978D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.docno")});
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Weight = 0.36968161687184586D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.name")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Weight = 1.216176481335113D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.IQty", "{0:n2}")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell1.Weight = 0.33974810579877479D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.Oqty", "{0:n2}")});
            this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.Weight = 0.38732476479191197D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.F_Balance", "{0:n2}")});
            this.xrTableCell3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.Weight = 0.3720641815909097D;
            // 
            // xrLine2
            // 
            this.xrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(43.33334F, 28.45831F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1072.667F, 2.250023F);
            this.xrLine2.StylePriority.UseBorderDashStyle = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.TopMargin.HeightF = 31.04167F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseFont = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.BottomMargin.HeightF = 21.20838F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbl_Where});
            this.pageFooterBand1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.pageFooterBand1.HeightF = 54.12503F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            this.pageFooterBand1.StylePriority.UseFont = false;
            // 
            // lbl_Where
            // 
            this.lbl_Where.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbl_Where.LocationFloat = new DevExpress.Utils.PointFloat(0.0001827876F, 0F);
            this.lbl_Where.Name = "lbl_Where";
            this.lbl_Where.SerializableRtfString = resources.GetString("lbl_Where.SerializableRtfString");
            this.lbl_Where.SizeF = new System.Drawing.SizeF(505.5002F, 54.12503F);
            this.lbl_Where.StylePriority.UseFont = false;
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.reportHeaderBand1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.reportHeaderBand1.HeightF = 90.37495F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            this.reportHeaderBand1.StylePriority.UseFont = false;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(1116F, 82.0416F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 43.41669F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(1116F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "รายงานเคลื่อนไหวสินค้า";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "BCConfigurations.CompanyName")});
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1116F, 33.41667F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.PageHeader.HeightF = 104.5833F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable3,
            this.xrPageInfo1,
            this.xrPageInfo2,
            this.lbl_UserPrint});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0.0001827876F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(1116F, 104.5833F);
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrTable2.BorderColor = System.Drawing.Color.White;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.BorderWidth = 1F;
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.ForeColor = System.Drawing.Color.White;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.70833F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1116F, 30F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseBorderWidth = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseForeColor = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "รหัสสินค้า";
            this.xrTableCell11.Weight = 0.39650484774956812D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "ชื่อสินค้า";
            this.xrTableCell12.Weight = 2.6034951522504315D;
            // 
            // xrTable3
            // 
            this.xrTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrTable3.BorderColor = System.Drawing.Color.White;
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.BorderWidth = 1F;
            this.xrTable3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable3.ForeColor = System.Drawing.Color.White;
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 72.70832F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1116F, 30F);
            this.xrTable3.StylePriority.UseBackColor = false;
            this.xrTable3.StylePriority.UseBorderColor = false;
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseBorderWidth = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseForeColor = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Text = "วันที่เอกสาร";
            this.xrTableCell17.Weight = 0.3532595425500914D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Text = "เลขที่เอกสาร";
            this.xrTableCell18.Weight = 0.36441442801461837D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "รายการ";
            this.xrTableCell21.Weight = 1.1550789086757052D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Text = "ยอดเข้า";
            this.xrTableCell22.Weight = 0.34843692895398476D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "ยอดออก";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell23.Weight = 0.39723050274460564D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Text = "คงเหลือ";
            this.xrTableCell24.Weight = 0.38157968906099471D;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrPageInfo1.Format = "พิมพ์เมื่อวันที่ : {0:\'วัน\'dddd\'ที่\' d MMMM yyyy H:mm}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(766.0711F, 19.70831F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(256.75F, 23F);
            this.xrPageInfo1.StyleName = "PageInfo";
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrPageInfo2.Format = "หน้า {0} of {1}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(1022.821F, 19.70831F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(93.17871F, 23F);
            this.xrPageInfo2.StyleName = "PageInfo";
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lbl_UserPrint
            // 
            this.lbl_UserPrint.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbl_UserPrint.LocationFloat = new DevExpress.Utils.PointFloat(532.0946F, 19.70831F);
            this.lbl_UserPrint.Name = "lbl_UserPrint";
            this.lbl_UserPrint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbl_UserPrint.SizeF = new System.Drawing.SizeF(233.9767F, 23F);
            this.lbl_UserPrint.StylePriority.UseFont = false;
            this.lbl_UserPrint.StylePriority.UseTextAlignment = false;
            this.lbl_UserPrint.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 8.916664F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // Date1
            // 
            this.Date1.Description = "วันที่เอกสาร : ";
            this.Date1.Name = "Date1";
            this.Date1.Type = typeof(System.DateTime);
            // 
            // Date2
            // 
            this.Date2.Description = "ถึงวันที่ : ";
            this.Date2.Name = "Date2";
            this.Date2.Type = typeof(System.DateTime);
            // 
            // ItemCode1
            // 
            this.ItemCode1.Description = "สินค้า : ";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "StockAll_Item";
            dynamicListLookUpSettings1.DataSource = this.StockDB;
            dynamicListLookUpSettings1.DisplayMember = "itemname";
            dynamicListLookUpSettings1.ValueMember = "itemcode";
            this.ItemCode1.LookUpSettings = dynamicListLookUpSettings1;
            this.ItemCode1.Name = "ItemCode1";
            // 
            // ItemCode2
            // 
            this.ItemCode2.Description = "ถึงสินค้า : ";
            dynamicListLookUpSettings2.DataAdapter = null;
            dynamicListLookUpSettings2.DataMember = "StockAll_Item";
            dynamicListLookUpSettings2.DataSource = this.StockDB;
            dynamicListLookUpSettings2.DisplayMember = "itemname";
            dynamicListLookUpSettings2.ValueMember = "itemcode";
            this.ItemCode2.LookUpSettings = dynamicListLookUpSettings2;
            this.ItemCode2.Name = "ItemCode2";
            // 
            // F_Balance
            // 
            this.F_Balance.DataMember = "StockAll";
            this.F_Balance.Expression = "[IQty] - [Oqty]";
            this.F_Balance.Name = "F_Balance";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel4,
            this.xrLabel3});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("itemcode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 27.16669F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1116F, 2.166687F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.itemname")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(147.5F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(475F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.itemcode")});
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(137.5F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5});
            this.GroupFooter1.HeightF = 43.75F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(517.1133F, 2.166684F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(195.8334F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "รวมยอด :  ";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.F_Balance")});
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(979.5641F, 2.166684F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(136.436F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel7.Summary = xrSummary1;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.Oqty")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(837.5322F, 2.166684F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(142.032F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StockAll.itemcode")});
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(712.9467F, 2.166684F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(124.5855F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel5.Summary = xrSummary3;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ItemGroup1
            // 
            this.ItemGroup1.Description = "กลุ่มสินค้า : ";
            dynamicListLookUpSettings3.DataAdapter = null;
            dynamicListLookUpSettings3.DataMember = "SotckAll_Group";
            dynamicListLookUpSettings3.DataSource = this.StockDB;
            dynamicListLookUpSettings3.DisplayMember = "GroupName";
            dynamicListLookUpSettings3.ValueMember = "Groupcode";
            this.ItemGroup1.LookUpSettings = dynamicListLookUpSettings3;
            this.ItemGroup1.Name = "ItemGroup1";
            // 
            // ItemGroup2
            // 
            this.ItemGroup2.Description = "ถึงกลุ่มสินค้า : ";
            dynamicListLookUpSettings4.DataAdapter = null;
            dynamicListLookUpSettings4.DataMember = "SotckAll_Group";
            dynamicListLookUpSettings4.DataSource = this.StockDB;
            dynamicListLookUpSettings4.DisplayMember = "GroupName";
            dynamicListLookUpSettings4.ValueMember = "Groupcode";
            this.ItemGroup2.LookUpSettings = dynamicListLookUpSettings4;
            this.ItemGroup2.Name = "ItemGroup2";
            // 
            // Rpt_StockAll
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.PageHeader,
            this.ReportFooter,
            this.GroupHeader1,
            this.GroupFooter1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.F_Balance});
            this.DataMember = "StockAll";
            this.DataSource = this.StockDB;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(26, 27, 31, 21);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Date1,
            this.Date2,
            this.ItemCode1,
            this.ItemCode2,
            this.ItemGroup1,
            this.ItemGroup2});
            this.SnapGridSize = 1F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "14.1";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.Rpt_Tranfer_ParametersRequestBeforeShow);
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.Rpt_Tranfer_ParametersRequestSubmit);
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.Rpt_StockAll_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Rpt_Tranfer_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Where)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource StockDB;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lbl_UserPrint;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRRichText lbl_Where;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.Parameters.Parameter Date1;
        private DevExpress.XtraReports.Parameters.Parameter Date2;
        private DevExpress.XtraReports.Parameters.Parameter ItemCode1;
        private DevExpress.XtraReports.Parameters.Parameter ItemCode2;
        private DevExpress.XtraReports.UI.CalculatedField F_Balance;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.Parameters.Parameter ItemGroup1;
        private DevExpress.XtraReports.Parameters.Parameter ItemGroup2;
    }
}
