namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    partial class RptCustomerList
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
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.panel1 = new Telerik.Reporting.Panel();
            this.textBox26 = new Telerik.Reporting.TextBox();
            this.textBox33 = new Telerik.Reporting.TextBox();
            this.textBox34 = new Telerik.Reporting.TextBox();
            this.textBox32 = new Telerik.Reporting.TextBox();
            this.textBox31 = new Telerik.Reporting.TextBox();
            this.textBox30 = new Telerik.Reporting.TextBox();
            this.textBox29 = new Telerik.Reporting.TextBox();
            this.textBox35 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox38 = new Telerik.Reporting.TextBox();
            this.textBox36 = new Telerik.Reporting.TextBox();
            this.textBox37 = new Telerik.Reporting.TextBox();
            this.panel3 = new Telerik.Reporting.Panel();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.textBox25 = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.textBox28 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
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
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.58102625608444214D);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel1});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.labelsGroupHeader.Style.Font.Name = "Times New Roman";
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2689741849899292D);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.labelsGroupFooter.Style.Font.Name = "Times New Roman";
            this.labelsGroupFooter.Style.Visible = false;
            // 
            // labelsGroup
            // 
            this.labelsGroup.GroupFooter = this.labelsGroupFooter;
            this.labelsGroup.GroupHeader = this.labelsGroupHeader;
            this.labelsGroup.Name = "labelsGroup";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.pageFooter.Name = "pageFooter";
            this.pageFooter.Style.Font.Name = "Times New Roman";
            this.pageFooter.Style.Visible = false;
            // 
            // detail
            // 
            formattingRule1.Filters.AddRange(new Telerik.Reporting.Filter[] {
            new Telerik.Reporting.Filter("=RowNumber() % 2", Telerik.Reporting.FilterOperator.Equal, "0")});
            formattingRule1.StopIfTrue = true;
            formattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.detail.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel3,
            this.textBox2,
            this.textBox8,
            this.textBox9,
            this.textBox10,
            this.textBox12});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.detail.Style.Font.Name = "Times New Roman";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.Font.Name = "Times New Roman";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Docking = Telerik.Reporting.DockingStyle.Top;
            this.titleTextBox.KeepTogether = true;
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(385.83670043945312D), Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D));
            this.titleTextBox.Style.Font.Bold = true;
            this.titleTextBox.Style.Font.Name = "Times New Roman";
            this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "DANH SÁCH KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Docking = Telerik.Reporting.DockingStyle.Bottom;
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox26,
            this.textBox33,
            this.textBox34,
            this.textBox32,
            this.textBox31,
            this.textBox30,
            this.textBox29,
            this.textBox35,
            this.textBox23,
            this.textBox38,
            this.textBox36,
            this.textBox37,
            this.textBox1,
            this.textBox3,
            this.textBox6,
            this.textBox7,
            this.textBox11});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(385.83670043945312D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            // 
            // textBox26
            // 
            this.textBox26.CanGrow = true;
            this.textBox26.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox26.Format = "";
            this.textBox26.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.399881511926651D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox26.Style.Font.Bold = true;
            this.textBox26.Style.Font.Name = "Times New Roman";
            this.textBox26.StyleName = "Data";
            this.textBox26.Value = "STT";
            // 
            // textBox33
            // 
            this.textBox33.Angle = 0D;
            this.textBox33.CanGrow = true;
            this.textBox33.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox33.Format = "";
            this.textBox33.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.399881511926651D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4999997615814209D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox33.Style.Font.Bold = true;
            this.textBox33.Style.Font.Name = "Times New Roman";
            this.textBox33.StyleName = "Data";
            this.textBox33.Value = "Mã KH";
            // 
            // textBox34
            // 
            this.textBox34.CanGrow = true;
            this.textBox34.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox34.Format = "";
            this.textBox34.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.89988130331039429D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox34.Style.Font.Bold = true;
            this.textBox34.Style.Font.Name = "Times New Roman";
            this.textBox34.StyleName = "Data";
            this.textBox34.Value = "Tên KH";
            // 
            // textBox32
            // 
            this.textBox32.CanGrow = true;
            this.textBox32.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox32.Format = "";
            this.textBox32.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2998812198638916D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.59984302520751953D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox32.Style.Font.Bold = true;
            this.textBox32.Style.Font.Name = "Times New Roman";
            this.textBox32.StyleName = "Data";
            this.textBox32.Value = "Tên viết tắt";
            // 
            // textBox31
            // 
            this.textBox31.CanGrow = true;
            this.textBox31.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox31.Format = "";
            this.textBox31.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8997242450714111D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox31.Style.Font.Bold = true;
            this.textBox31.Style.Font.Name = "Times New Roman";
            this.textBox31.StyleName = "Data";
            this.textBox31.Value = "Tên công ty";
            // 
            // textBox30
            // 
            this.textBox30.CanGrow = true;
            this.textBox30.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox30.Format = "";
            this.textBox30.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2997241020202637D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox30.Style.Font.Bold = true;
            this.textBox30.Style.Font.Name = "Times New Roman";
            this.textBox30.StyleName = "Data";
            this.textBox30.Value = "Tên liên hệ";
            // 
            // textBox29
            // 
            this.textBox29.CanGrow = true;
            this.textBox29.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox29.Format = "";
            this.textBox29.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6997241973876953D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox29.Style.Font.Bold = true;
            this.textBox29.Style.Font.Name = "Times New Roman";
            this.textBox29.StyleName = "Data";
            this.textBox29.Value = "Địa chỉ";
            // 
            // textBox35
            // 
            this.textBox35.CanGrow = true;
            this.textBox35.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox35.Format = "";
            this.textBox35.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.099724292755127D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox35.Style.Font.Bold = true;
            this.textBox35.Style.Font.Name = "Times New Roman";
            this.textBox35.StyleName = "Data";
            this.textBox35.Value = "Địa chỉ giao hàng";
            // 
            // textBox23
            // 
            this.textBox23.CanGrow = true;
            this.textBox23.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox23.Format = "";
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4997234344482422D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox23.Style.Font.Bold = true;
            this.textBox23.Style.Font.Name = "Times New Roman";
            this.textBox23.StyleName = "Data";
            this.textBox23.Value = "Thông tin";
            // 
            // textBox38
            // 
            this.textBox38.CanGrow = true;
            this.textBox38.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox38.Format = "";
            this.textBox38.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.4997243881225586D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99260014295578D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox38.Style.Font.Bold = true;
            this.textBox38.Style.Font.Name = "Times New Roman";
            this.textBox38.StyleName = "Data";
            this.textBox38.Value = "Thông tin 2";
            // 
            // textBox36
            // 
            this.textBox36.CanGrow = true;
            this.textBox36.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox36.Format = "";
            this.textBox36.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.492323875427246D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox36.Style.Font.Bold = true;
            this.textBox36.Style.Font.Name = "Times New Roman";
            this.textBox36.StyleName = "Data";
            this.textBox36.Value = "Hoạt động";
            // 
            // textBox37
            // 
            this.textBox37.CanGrow = true;
            this.textBox37.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox37.Format = "";
            this.textBox37.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.992323875427246D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968348741531372D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox37.Style.Font.Bold = true;
            this.textBox37.Style.Font.Name = "Times New Roman";
            this.textBox37.StyleName = "Data";
            this.textBox37.Value = "Ghi Chú";
            // 
            // panel3
            // 
            this.panel3.Docking = Telerik.Reporting.DockingStyle.Left;
            this.panel3.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox15,
            this.textBox16,
            this.textBox17,
            this.textBox18,
            this.textBox19,
            this.textBox20,
            this.textBox21,
            this.textBox24,
            this.textBox25,
            this.textBox27,
            this.textBox28});
            this.panel3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel3.Name = "panel3";
            this.panel3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(1122.4327392578125D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox4.Format = "{0}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39988157153129578D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox4.Style.Font.Name = "Times New Roman";
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= RowNumber()";
            // 
            // textBox15
            // 
            this.textBox15.CanGrow = true;
            this.textBox15.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox15.Format = "{0}";
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.39988157153129578D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49999967217445374D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox15.Style.Font.Bold = true;
            this.textBox15.Style.Font.Name = "Times New Roman";
            this.textBox15.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox15.StyleName = "Data";
            this.textBox15.Value = "=CustomerCode";
            // 
            // textBox16
            // 
            this.textBox16.CanGrow = true;
            this.textBox16.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox16.Format = "";
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.89988124370574951D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox16.Style.Font.Name = "Times New Roman";
            this.textBox16.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox16.StyleName = "Data";
            this.textBox16.Value = "=CustomerName";
            // 
            // textBox17
            // 
            this.textBox17.CanGrow = true;
            this.textBox17.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox17.Format = "";
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2998812198638916D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.59984302520751953D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox17.Style.Font.Name = "Times New Roman";
            this.textBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox17.StyleName = "Data";
            this.textBox17.Value = "=ShortName";
            // 
            // textBox18
            // 
            this.textBox18.CanGrow = true;
            this.textBox18.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox18.Format = "";
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8997242450714111D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox18.Style.Font.Name = "Times New Roman";
            this.textBox18.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox18.StyleName = "Data";
            this.textBox18.Value = "=CompanyName";
            // 
            // textBox19
            // 
            this.textBox19.CanGrow = true;
            this.textBox19.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox19.Format = "";
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2997241020202637D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox19.Style.Font.Name = "Times New Roman";
            this.textBox19.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox19.StyleName = "Data";
            this.textBox19.Value = "=ContactName";
            // 
            // textBox20
            // 
            this.textBox20.CanGrow = true;
            this.textBox20.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox20.Format = "";
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6997241973876953D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox20.Style.Font.Name = "Times New Roman";
            this.textBox20.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox20.StyleName = "Data";
            this.textBox20.Value = "=Address";
            // 
            // textBox21
            // 
            this.textBox21.CanGrow = true;
            this.textBox21.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox21.Format = "";
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.099724292755127D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox21.Style.Font.Name = "Times New Roman";
            this.textBox21.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox21.StyleName = "Data";
            this.textBox21.Value = "=Eaddress";
            // 
            // textBox24
            // 
            this.textBox24.CanGrow = true;
            this.textBox24.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox24.Format = "";
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4997234344482422D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000003576278687D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox24.Style.Font.Name = "Times New Roman";
            this.textBox24.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox24.StyleName = "Data";
            this.textBox24.Value = "=Info1";
            // 
            // textBox25
            // 
            this.textBox25.CanGrow = true;
            this.textBox25.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox25.Format = "";
            this.textBox25.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.4997243881225586D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99260109663009644D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox25.Style.Font.Name = "Times New Roman";
            this.textBox25.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox25.StyleName = "Data";
            this.textBox25.Value = "=Info2";
            // 
            // textBox27
            // 
            this.textBox27.CanGrow = true;
            this.textBox27.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox27.Format = "";
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.492324829101563D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox27.Style.Font.Name = "Times New Roman";
            this.textBox27.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox27.StyleName = "Data";
            this.textBox27.Value = "=Active";
            // 
            // textBox28
            // 
            this.textBox28.CanGrow = true;
            this.textBox28.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox28.Format = "";
            this.textBox28.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.992324829101563D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968318939208984D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox28.Style.Font.Name = "Times New Roman";
            this.textBox28.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox28.StyleName = "Data";
            this.textBox28.Value = "=Note";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox1.Format = "";
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.692008018493652D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968348741531372D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Times New Roman";
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "Loại khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox2.Format = "";
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.692008018493652D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968318939208984D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox2.Style.Font.Name = "Times New Roman";
            this.textBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=CustomerTypeName";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox3.Format = "";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.391692161560059D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968348741531372D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Name = "Times New Roman";
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "Hình thức\r\nthanh toán";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox6.Format = "";
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.091376304626465D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968348741531372D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.Font.Name = "Times New Roman";
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "Phân loại";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox7.Format = "";
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.791060447692871D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968348741531372D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.Font.Name = "Times New Roman";
            this.textBox7.StyleName = "Data";
            this.textBox7.Value = "Khu vực";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox8.Format = "";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.391691207885742D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968318939208984D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox8.Style.Font.Name = "Times New Roman";
            this.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "=PayType";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox9.Format = "";
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.091373443603516D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968318939208984D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox9.Style.Font.Name = "Times New Roman";
            this.textBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox9.StyleName = "Data";
            this.textBox9.Value = "=ClassifiedName";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox10.Format = "";
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.791056632995606D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968318939208984D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox10.Style.Font.Name = "Times New Roman";
            this.textBox10.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox10.StyleName = "Data";
            this.textBox10.Value = "=AreaName";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox11.Format = "";
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.490744590759277D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968348741531372D), Telerik.Reporting.Drawing.Unit.Pixel(36.578521728515625D));
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.Style.Font.Name = "Times New Roman";
            this.textBox11.StyleName = "Data";
            this.textBox11.Value = "Nhân viên";
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = true;
            this.textBox12.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox12.Format = "";
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.490739822387695D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69968318939208984D), Telerik.Reporting.Drawing.Unit.Inch(0.45000001788139343D));
            this.textBox12.Style.Font.Name = "Times New Roman";
            this.textBox12.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox12.StyleName = "Data";
            this.textBox12.Value = "=EmloyeeName";
            // 
            // RptCustomerList
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
            this.Name = "CustomerList";
            this.PageSettings.Landscape = true;
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
            this.Width = Telerik.Reporting.Drawing.Unit.Mm(385.83670043945312D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.ObjectDataSource objectDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.TextBox textBox26;
        private Telerik.Reporting.TextBox textBox33;
        private Telerik.Reporting.TextBox textBox34;
        private Telerik.Reporting.TextBox textBox32;
        private Telerik.Reporting.TextBox textBox31;
        private Telerik.Reporting.TextBox textBox30;
        private Telerik.Reporting.TextBox textBox29;
        private Telerik.Reporting.TextBox textBox35;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox38;
        private Telerik.Reporting.TextBox textBox36;
        private Telerik.Reporting.TextBox textBox37;
        private Telerik.Reporting.Panel panel3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox25;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;

    }
}