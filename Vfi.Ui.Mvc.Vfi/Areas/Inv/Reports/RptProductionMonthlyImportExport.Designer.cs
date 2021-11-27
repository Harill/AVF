namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    partial class RptProductionMonthlyImportExport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.objectDataSource1 = new Telerik.Reporting.ObjectDataSource();
            this.fromDateDataTextBox1 = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox35 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.panelRow = new Telerik.Reporting.Panel();
            this.textBox76 = new Telerik.Reporting.TextBox();
            this.warehouseNameDataTextBox1 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.panel2 = new Telerik.Reporting.Panel();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox33 = new Telerik.Reporting.TextBox();
            this.panel9 = new Telerik.Reporting.Panel();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox48 = new Telerik.Reporting.TextBox();
            this.textBox47 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox77 = new Telerik.Reporting.TextBox();
            this.warehouseNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.Name = "objectDataSource1";
            this.objectDataSource1.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("materialTypeId", typeof(int), null),
            new Telerik.Reporting.ObjectDataSourceParameter("materialName", typeof(string), null),
            new Telerik.Reporting.ObjectDataSourceParameter("fromDate", typeof(string), null),
            new Telerik.Reporting.ObjectDataSourceParameter("toDate", typeof(string), null)});
            // 
            // fromDateDataTextBox1
            // 
            this.fromDateDataTextBox1.CanGrow = true;
            this.fromDateDataTextBox1.Format = "{0:dd/MM/yyyy}";
            this.fromDateDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3645833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0.70007872581481934D));
            this.fromDateDataTextBox1.Name = "fromDateDataTextBox1";
            this.fromDateDataTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.72916674613952637D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.fromDateDataTextBox1.Style.Font.Bold = true;
            this.fromDateDataTextBox1.Style.Font.Name = "Times New Roman";
            this.fromDateDataTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(15D);
            this.fromDateDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.fromDateDataTextBox1.StyleName = "Data";
            this.fromDateDataTextBox1.Value = "Ngày:";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25656136870384216D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.textBox10,
            this.textBox9,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            this.pageFooter.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.pageFooter.Style.Font.Name = "Times New Roman";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Format = "{0:dd/MM/yyyy HH:mm:ss}";
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.09375D), Telerik.Reporting.Drawing.Unit.Inch(0.05656132847070694D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3020833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.18330258131027222D));
            this.currentTimeTextBox.Style.Font.Name = "Times New Roman";
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3645833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0.056561365723609924D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.72916668653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.18330265581607819D));
            this.textBox10.Style.Font.Name = "Times New Roman";
            this.textBox10.StyleName = "Caption";
            this.textBox10.Value = "Today:";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.520911693572998D), Telerik.Reporting.Drawing.Unit.Inch(0.053206197917461395D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78124994039535522D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox9.Style.Font.Name = "Times New Roman";
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Page:";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3022403717041016D), Telerik.Reporting.Drawing.Unit.Inch(0.056561365723609924D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78117156028747559D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pageInfoTextBox.Style.Font.Name = "Times New Roman";
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0000001192092896D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.fromDateDataTextBox1,
            this.titleTextBox,
            this.textBox35});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.Font.Name = "Times New Roman";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Docking = Telerik.Reporting.DockingStyle.Top;
            this.titleTextBox.KeepTogether = true;
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.083411693572998D), Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071D));
            this.titleTextBox.Style.Font.Bold = true;
            this.titleTextBox.Style.Font.Name = "Times New Roman";
            this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "THỐNG KÊ NHẬP XUẤT KHO";
            // 
            // textBox35
            // 
            this.textBox35.CanGrow = true;
            this.textBox35.Format = "{0:MM/yyyy}";
            this.textBox35.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.09375D), Telerik.Reporting.Drawing.Unit.Inch(0.70007872581481934D));
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3020833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox35.Style.Font.Bold = true;
            this.textBox35.Style.Font.Name = "Times New Roman";
            this.textBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(15D);
            this.textBox35.StyleName = "Data";
            this.textBox35.Value = "=Fields.ReportDate";
            // 
            // detail
            // 
            formattingRule1.Filters.AddRange(new Telerik.Reporting.Filter[] {
            new Telerik.Reporting.Filter("=RowNumber() % 2", Telerik.Reporting.FilterOperator.Equal, "0")});
            formattingRule1.StopIfTrue = true;
            formattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.detail.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panelRow});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.Font.Name = "Times New Roman";
            // 
            // panelRow
            // 
            this.panelRow.Docking = Telerik.Reporting.DockingStyle.Left;
            this.panelRow.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox76,
            this.warehouseNameDataTextBox1,
            this.textBox6,
            this.textBox18,
            this.textBox7,
            this.textBox8,
            this.textBox11,
            this.textBox12,
            this.textBox13});
            this.panelRow.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(0D), Telerik.Reporting.Drawing.Unit.Pixel(0.007568359375D));
            this.panelRow.Name = "panelRow";
            this.panelRow.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(680.007568359375D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.panelRow.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.panelRow.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.panelRow.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.panelRow.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.panelRow.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelRow.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelRow.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelRow.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelRow.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.panelRow.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            // 
            // textBox76
            // 
            this.textBox76.CanGrow = true;
            this.textBox76.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox76.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Pixel(0D));
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(35D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox76.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox76.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox76.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox76.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox76.Style.Font.Name = "Times New Roman";
            this.textBox76.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox76.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox76.StyleName = "Data";
            this.textBox76.Value = "=RowNumber()";
            // 
            // warehouseNameDataTextBox1
            // 
            this.warehouseNameDataTextBox1.CanGrow = true;
            this.warehouseNameDataTextBox1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.warehouseNameDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3645833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.warehouseNameDataTextBox1.Name = "warehouseNameDataTextBox1";
            this.warehouseNameDataTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(69.999992370605469D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.warehouseNameDataTextBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.warehouseNameDataTextBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.warehouseNameDataTextBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.warehouseNameDataTextBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.warehouseNameDataTextBox1.Style.Font.Name = "Times New Roman";
            this.warehouseNameDataTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.warehouseNameDataTextBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2D);
            this.warehouseNameDataTextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.warehouseNameDataTextBox1.StyleName = "Data";
            this.warehouseNameDataTextBox1.Value = "=Fields.ProductCustomerCode";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0937498807907105D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(125D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox6.Style.Font.Name = "Times New Roman";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox6.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2D);
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "=Fields.ProductCode";
            // 
            // textBox18
            // 
            this.textBox18.CanGrow = true;
            this.textBox18.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox18.Format = "{0:n3}";
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3958332538604736D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox18.Style.Font.Name = "Times New Roman";
            this.textBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox18.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox18.StyleName = "Data";
            this.textBox18.Value = "=Fields.ImportWeight";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox7.Format = "{0:n3}";
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1770832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox7.Style.Font.Name = "Times New Roman";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox7.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox7.StyleName = "Data";
            this.textBox7.Value = "=Fields.ExportWeight";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox8.Format = "{0:n0}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9583332538604736D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox8.Style.Font.Name = "Times New Roman";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox8.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "=FormatNumber(Fields.ImportQuantity)";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox11.Format = "{0:n0}";
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7395834922790527D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox11.Style.Font.Name = "Times New Roman";
            this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox11.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox11.StyleName = "Data";
            this.textBox11.Value = "=FormatNumber(Fields.ExportQuantity)";
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = true;
            this.textBox12.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox12.Format = "{0:n1}";
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5208334922790527D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox12.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox12.Style.Font.Name = "Times New Roman";
            this.textBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox12.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox12.StyleName = "Data";
            this.textBox12.Value = "=Fields.ProductivityInMonth";
            // 
            // textBox13
            // 
            this.textBox13.CanGrow = true;
            this.textBox13.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox13.Format = "{0:n1}";
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3020834922790527D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.33894792199134827D));
            this.textBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox13.Style.Font.Name = "Times New Roman";
            this.textBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox13.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox13.StyleName = "Data";
            this.textBox13.Value = "=Fields.DesignProductivity";
            // 
            // labelsGroup
            // 
            this.labelsGroup.GroupFooter = this.labelsGroupFooter;
            this.labelsGroup.GroupHeader = this.labelsGroupHeader;
            this.labelsGroup.Name = "labelsGroup";
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.Font.Name = "Times New Roman";
            this.labelsGroupFooter.Style.Visible = false;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0999999046325684D);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel2,
            this.textBox33,
            this.panel9,
            this.textBox24});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.labelsGroupHeader.Style.Font.Name = "Times New Roman";
            // 
            // panel2
            // 
            this.panel2.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox21,
            this.textBox22,
            this.textBox23});
            this.panel2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.panel2.Name = "panel2";
            this.panel2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3958327770233154D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.panel2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            // 
            // textBox21
            // 
            this.textBox21.CanGrow = true;
            this.textBox21.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(35D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.textBox21.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox21.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox21.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox21.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox21.Style.Font.Bold = true;
            this.textBox21.Style.Font.Name = "Times New Roman";
            this.textBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox21.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2D);
            this.textBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox21.StyleName = "Data";
            this.textBox21.Value = "S\r\nT\r\nT";
            // 
            // textBox22
            // 
            this.textBox22.CanGrow = true;
            this.textBox22.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3645833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(69.999992370605469D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.textBox22.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox22.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox22.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox22.Style.Font.Bold = true;
            this.textBox22.Style.Font.Name = "Times New Roman";
            this.textBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox22.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(2D);
            this.textBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox22.StyleName = "Data";
            this.textBox22.Value = "Khách hàng";
            // 
            // textBox23
            // 
            this.textBox23.CanGrow = true;
            this.textBox23.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0937498807907105D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(124.99622344970703D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.textBox23.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox23.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox23.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox23.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox23.Style.Font.Bold = true;
            this.textBox23.Style.Font.Name = "Times New Roman";
            this.textBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox23.StyleName = "Data";
            this.textBox23.Value = "Sản phẩm";
            // 
            // textBox33
            // 
            this.textBox33.CanGrow = true;
            this.textBox33.Format = "{0:N0}";
            this.textBox33.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9584119319915771D), Telerik.Reporting.Drawing.Unit.Pixel(76.834022521972656D));
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.29964545369148254D));
            this.textBox33.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox33.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox33.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox33.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox33.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox33.Style.Font.Name = "Times New Roman";
            this.textBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox33.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox33.StyleName = "Data";
            this.textBox33.Value = "=sum(Fields.ImportQuantity)";
            // 
            // panel9
            // 
            this.panel9.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox14,
            this.textBox15,
            this.textBox16,
            this.textBox17,
            this.textBox19,
            this.textBox20});
            this.panel9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.395911693572998D), Telerik.Reporting.Drawing.Unit.Inch(0.00055189488921314478D));
            this.panel9.Name = "panel9";
            this.panel9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(450.00003051757812D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.panel9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // textBox14
            // 
            this.textBox14.CanGrow = true;
            this.textBox14.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox14.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox14.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox14.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox14.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox14.Style.Font.Bold = true;
            this.textBox14.Style.Font.Name = "Times New Roman";
            this.textBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox14.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox14.StyleName = "Data";
            this.textBox14.Value = "Trọng lượng\r\nSX1\r\n(g/pc)";
            // 
            // textBox15
            // 
            this.textBox15.CanGrow = true;
            this.textBox15.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.78125D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox15.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox15.Style.Font.Bold = true;
            this.textBox15.Style.Font.Name = "Times New Roman";
            this.textBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox15.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox15.StyleName = "Data";
            this.textBox15.Value = "Trọng lượng\r\nQC\r\n(g/pc)";
            // 
            // textBox16
            // 
            this.textBox16.CanGrow = true;
            this.textBox16.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5625D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox16.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox16.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox16.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox16.Style.Font.Bold = true;
            this.textBox16.Style.Font.Name = "Times New Roman";
            this.textBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox16.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox16.StyleName = "Data";
            this.textBox16.Value = "Lũy kế\r\nSX\r\n(pcs)";
            // 
            // textBox17
            // 
            this.textBox17.CanGrow = true;
            this.textBox17.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.34375D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox17.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox17.Style.Font.Bold = true;
            this.textBox17.Style.Font.Name = "Times New Roman";
            this.textBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox17.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox17.StyleName = "Data";
            this.textBox17.Value = "Xuất\r\nbán\r\n(pcs)";
            // 
            // textBox19
            // 
            this.textBox19.CanGrow = true;
            this.textBox19.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.125D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox19.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox19.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox19.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox19.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox19.Style.Font.Bold = true;
            this.textBox19.Style.Font.Name = "Times New Roman";
            this.textBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox19.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox19.StyleName = "Data";
            this.textBox19.Value = "NS\r\nSX1\r\n(s/pc)";
            // 
            // textBox20
            // 
            this.textBox20.CanGrow = true;
            this.textBox20.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.90625D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox20.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox20.Style.Font.Bold = true;
            this.textBox20.Style.Font.Name = "Times New Roman";
            this.textBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(14D);
            this.textBox20.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox20.StyleName = "Data";
            this.textBox20.Value = "NS\r\nthiết kế\r\n(s/pc)";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox5.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox5.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox5.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox5.Style.Color = System.Drawing.Color.Black;
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.Font.Name = "Times New Roman";
            this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.StyleName = "Caption";
            this.textBox5.Value = "NS thiêt kế";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox4.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox4.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox4.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox4.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox4.Style.Color = System.Drawing.Color.Black;
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.Font.Name = "Times New Roman";
            this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.StyleName = "Caption";
            this.textBox4.Value = "Trung bình\r\nNS SX1";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox3.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox3.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox3.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox3.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox3.Style.Color = System.Drawing.Color.Black;
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Name = "Times New Roman";
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.StyleName = "Caption";
            this.textBox3.Value = "Xuất bán";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox2.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox2.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox2.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox2.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox2.Style.Color = System.Drawing.Color.Black;
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Name = "Times New Roman";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Lũy kế SX";
            // 
            // textBox48
            // 
            this.textBox48.CanGrow = true;
            this.textBox48.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox48.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox48.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox48.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox48.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox48.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox48.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox48.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox48.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox48.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox48.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox48.Style.Color = System.Drawing.Color.Black;
            this.textBox48.Style.Font.Bold = true;
            this.textBox48.Style.Font.Name = "Times New Roman";
            this.textBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            this.textBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox48.StyleName = "Caption";
            this.textBox48.Value = "Trọng lượng\r\nQC";
            // 
            // textBox47
            // 
            this.textBox47.CanGrow = true;
            this.textBox47.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox47.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.79972380399703979D));
            this.textBox47.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox47.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox47.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox47.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox47.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox47.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox47.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox47.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.textBox47.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox47.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox47.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox47.Style.Color = System.Drawing.Color.Black;
            this.textBox47.Style.Font.Bold = true;
            this.textBox47.Style.Font.Name = "Times New Roman";
            this.textBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            this.textBox47.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(0D);
            this.textBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox47.StyleName = "Caption";
            this.textBox47.Value = "Trọng lượng\r\nSX1";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(125D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.textBox1.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox1.Style.Color = System.Drawing.Color.Black;
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Times New Roman";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(13D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Sản phẩm";
            // 
            // textBox77
            // 
            this.textBox77.CanGrow = true;
            this.textBox77.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox77.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(70D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.textBox77.Style.BackgroundColor = System.Drawing.Color.White;
            this.textBox77.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox77.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox77.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox77.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox77.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox77.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox77.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox77.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox77.Style.Color = System.Drawing.Color.Black;
            this.textBox77.Style.Font.Bold = true;
            this.textBox77.Style.Font.Name = "Times New Roman";
            this.textBox77.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(13D);
            this.textBox77.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox77.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox77.StyleName = "Caption";
            this.textBox77.Value = "Khách hàng";
            // 
            // warehouseNameCaptionTextBox
            // 
            this.warehouseNameCaptionTextBox.Angle = 0D;
            this.warehouseNameCaptionTextBox.CanGrow = true;
            this.warehouseNameCaptionTextBox.Docking = Telerik.Reporting.DockingStyle.Left;
            this.warehouseNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.warehouseNameCaptionTextBox.Name = "warehouseNameCaptionTextBox";
            this.warehouseNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(35D), Telerik.Reporting.Drawing.Unit.Inch(0.80023634433746338D));
            this.warehouseNameCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.White;
            this.warehouseNameCaptionTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.warehouseNameCaptionTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.warehouseNameCaptionTextBox.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.warehouseNameCaptionTextBox.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.warehouseNameCaptionTextBox.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.warehouseNameCaptionTextBox.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.warehouseNameCaptionTextBox.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.warehouseNameCaptionTextBox.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.warehouseNameCaptionTextBox.Style.Color = System.Drawing.Color.Black;
            this.warehouseNameCaptionTextBox.Style.Font.Bold = true;
            this.warehouseNameCaptionTextBox.Style.Font.Name = "Times New Roman";
            this.warehouseNameCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(13D);
            this.warehouseNameCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.warehouseNameCaptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.warehouseNameCaptionTextBox.StyleName = "Caption";
            this.warehouseNameCaptionTextBox.Value = "STT";
            // 
            // textBox24
            // 
            this.textBox24.CanGrow = true;
            this.textBox24.Format = "{0:N0}";
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.73974084854126D), Telerik.Reporting.Drawing.Unit.Pixel(76.834030151367188D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(75D), Telerik.Reporting.Drawing.Unit.Inch(0.29964545369148254D));
            this.textBox24.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox24.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox24.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox24.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.textBox24.Style.Font.Name = "Times New Roman";
            this.textBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(12D);
            this.textBox24.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox24.StyleName = "Data";
            this.textBox24.Value = "=sum(Fields.ExportQuantity)";
            // 
            // RptProductionMonthlyImportExport
            // 
            this.DataSource = this.objectDataSource1;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "RptProductInvTotal";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(97)))), ((int)(((byte)(74)))));
            styleRule1.Style.Font.Name = "Georgia";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            styleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(168)))), ((int)(((byte)(212)))));
            styleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dotted;
            styleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            styleRule2.Style.Font.Name = "Georgia";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Georgia";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Georgia";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Pixel;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(7.083411693572998D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.ObjectDataSource objectDataSource1;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox fromDateDataTextBox1;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox textBox35;
        private Telerik.Reporting.Panel panelRow;
        private Telerik.Reporting.TextBox textBox76;
        private Telerik.Reporting.TextBox warehouseNameDataTextBox1;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.Panel panel2;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox33;
        private Telerik.Reporting.Panel panel9;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox48;
        private Telerik.Reporting.TextBox textBox47;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox77;
        private Telerik.Reporting.TextBox warehouseNameCaptionTextBox;
        private Telerik.Reporting.TextBox textBox24;

    }
}