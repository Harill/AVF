namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    partial class RptMaterialLotCard
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
            this.panelFirstImport = new Telerik.Reporting.Panel();
            this.panel1 = new Telerik.Reporting.Panel();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.panel2 = new Telerik.Reporting.Panel();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.panel3 = new Telerik.Reporting.Panel();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.panel4 = new Telerik.Reporting.Panel();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
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
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.labelsGroupHeader.Style.Font.Name = "Times New Roman";
            this.labelsGroupHeader.Style.Visible = false;
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
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
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.6523584127426148D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panelFirstImport});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.detail.Style.Font.Name = "Times New Roman";
            // 
            // panelFirstImport
            // 
            this.panelFirstImport.Docking = Telerik.Reporting.DockingStyle.Left;
            this.panelFirstImport.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4});
            this.panelFirstImport.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panelFirstImport.Name = "panelFirstImport";
            this.panelFirstImport.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(91.44000244140625D), Telerik.Reporting.Drawing.Unit.Inch(1.6523584127426148D));
            this.panelFirstImport.Style.BackgroundColor = System.Drawing.Color.White;
            this.panelFirstImport.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panelFirstImport.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.panelFirstImport.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.panelFirstImport.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.panelFirstImport.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.panelFirstImport.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelFirstImport.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.panelFirstImport.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelFirstImport.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panelFirstImport.Style.Font.Bold = true;
            this.panelFirstImport.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            // 
            // panel1
            // 
            this.panel1.Docking = Telerik.Reporting.DockingStyle.Top;
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox20,
            this.textBox1,
            this.textBox2,
            this.textBox3});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(91.44000244140625D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.panel1.Style.BackgroundColor = System.Drawing.Color.White;
            this.panel1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.panel1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.panel1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.panel1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel1.Style.Font.Bold = true;
            this.panel1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            // 
            // textBox20
            // 
            this.textBox20.CanGrow = true;
            this.textBox20.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox20.Format = "{0:N0}";
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox20.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox20.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox20.Style.Font.Name = "Times New Roman";
            this.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox20.StyleName = "Data";
            this.textBox20.Value = "Nhà cung cấp\r\nSupplier";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox1.Format = "{0:N0}";
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox1.Style.Font.Name = "Times New Roman";
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "=VendorCode";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox2.Format = "{0:N0}";
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0000003576278687D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox2.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox2.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox2.Style.Font.Name = "Times New Roman";
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "Số lô\r\nLot";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox3.Format = "{0:N0}";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox3.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox3.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox3.Style.Font.Name = "Times New Roman";
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "=LotNumber";
            // 
            // panel2
            // 
            this.panel2.Docking = Telerik.Reporting.DockingStyle.Top;
            this.panel2.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox7});
            this.panel2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.panel2.Name = "panel2";
            this.panel2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(91.44000244140625D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.panel2.Style.BackgroundColor = System.Drawing.Color.White;
            this.panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.panel2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.panel2.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel2.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel2.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel2.Style.Font.Bold = true;
            this.panel2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox4.Format = "{0:N0}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox4.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox4.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox4.Style.Font.Name = "Times New Roman";
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "Nguyên liệu\r\nMaterial";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox5.Format = "{0:N0}";
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox5.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox5.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox5.Style.Font.Name = "Times New Roman";
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "=MaterialName";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox6.Format = "{0:N0}";
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992150068283081D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox6.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox6.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox6.Style.Font.Name = "Times New Roman";
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "Vị trí kho\r\nStore";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox7.Format = "{0:N0}";
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6999213695526123D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox7.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox7.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox7.Style.Font.Name = "Times New Roman";
            this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox7.StyleName = "Data";
            this.textBox7.Value = "=StoreCode";
            // 
            // panel3
            // 
            this.panel3.Docking = Telerik.Reporting.DockingStyle.Top;
            this.panel3.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8,
            this.textBox9,
            this.textBox10,
            this.textBox11});
            this.panel3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.80015724897384644D));
            this.panel3.Name = "panel3";
            this.panel3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(91.44000244140625D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.panel3.Style.BackgroundColor = System.Drawing.Color.White;
            this.panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.panel3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.panel3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.panel3.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel3.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel3.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel3.Style.Font.Bold = true;
            this.panel3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox8.Format = "{0:N0}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox8.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox8.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox8.Style.Font.Name = "Times New Roman";
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "Quy cách\r\nSpecification";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox9.Format = "{0:N0}";
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox9.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox9.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox9.Style.Font.Name = "Times New Roman";
            this.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox9.StyleName = "Data";
            this.textBox9.Value = "=MaterialDesignNo";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox10.Format = "{0:N0}";
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99984234571456909D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox10.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox10.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox10.Style.Font.Name = "Times New Roman";
            this.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox10.StyleName = "Data";
            this.textBox10.Value = "Trọng lượng/Số cây\r\nWeight(kg)/pcs";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox11.Format = "{0:N0}";
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6998422145843506D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox11.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox11.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox11.Style.Font.Name = "Times New Roman";
            this.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox11.StyleName = "Data";
            this.textBox11.Value = "=QuantityKg+\"/\"+Quantity";
            // 
            // panel4
            // 
            this.panel4.Docking = Telerik.Reporting.DockingStyle.Top;
            this.panel4.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox12,
            this.textBox13,
            this.textBox14,
            this.textBox15});
            this.panel4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(1.2002358436584473D));
            this.panel4.Name = "panel4";
            this.panel4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(91.44000244140625D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.panel4.Style.BackgroundColor = System.Drawing.Color.White;
            this.panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.panel4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.panel4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.panel4.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel4.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel4.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            this.panel4.Style.Font.Bold = true;
            this.panel4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(11D);
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = true;
            this.textBox12.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox12.Format = "{0:N0}";
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox12.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox12.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox12.Style.Font.Name = "Times New Roman";
            this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox12.StyleName = "Data";
            this.textBox12.Value = "Ngày nhập\r\nImport Date";
            // 
            // textBox13
            // 
            this.textBox13.CanGrow = true;
            this.textBox13.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox13.Format = "{0:dd/MM/yyyy}";
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox13.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox13.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox13.Style.Font.Name = "Times New Roman";
            this.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox13.StyleName = "Data";
            this.textBox13.Value = "=CreatedDate";
            // 
            // textBox14
            // 
            this.textBox14.CanGrow = true;
            this.textBox14.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox14.Format = "{0:N0}";
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992150068283081D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox14.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox14.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox14.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox14.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox14.Style.Font.Name = "Times New Roman";
            this.textBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox14.StyleName = "Data";
            this.textBox14.Value = "Ngày kiểm tra\r\nCheck Date";
            // 
            // textBox15
            // 
            this.textBox15.CanGrow = true;
            this.textBox15.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox15.Format = "{0:dd/MM/yyyy}";
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6999213695526123D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731D), Telerik.Reporting.Drawing.Unit.Inch(0.40007862448692322D));
            this.textBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox15.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox15.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox15.Style.Font.Name = "Times New Roman";
            this.textBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox15.StyleName = "Data";
            this.textBox15.Value = "=ModifiedDate";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.Font.Name = "Times New Roman";
            this.reportHeader.Style.Visible = false;
            // 
            // RptMaterialLotCard
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
            this.Width = Telerik.Reporting.Drawing.Unit.Mm(193.98995971679688D);
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
        private Telerik.Reporting.Panel panelFirstImport;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.Panel panel2;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.Panel panel3;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.Panel panel4;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.TextBox textBox15;

    }
}