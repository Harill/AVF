namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    partial class RptItemCard
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup6 = new Telerik.Reporting.TableGroup();
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
            this.panel1 = new Telerik.Reporting.Panel();
            this.panel16 = new Telerik.Reporting.Panel();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.panel2 = new Telerik.Reporting.Panel();
            this.panel3 = new Telerik.Reporting.Panel();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.panel4 = new Telerik.Reporting.Panel();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
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
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.52996081113815308D);
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.labelsGroupHeader.Style.Font.Name = "Times New Roman";
            this.labelsGroupHeader.Style.Visible = false;
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(2.3798036575317383D);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
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
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.500117838382721D);
            this.pageFooter.Name = "pageFooter";
            this.pageFooter.Style.Font.Name = "Times New Roman";
            this.pageFooter.Style.Visible = false;
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.670039176940918D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel1});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.detail.Style.Font.Name = "Times New Roman";
            // 
            // panel1
            // 
            this.panel1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel16,
            this.panel2});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.5117721557617188D), Telerik.Reporting.Drawing.Unit.Inch(1.670039176940918D));
            this.panel1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // panel16
            // 
            this.panel16.Docking = Telerik.Reporting.DockingStyle.Left;
            this.panel16.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8});
            this.panel16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel16.Name = "panel16";
            this.panel16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D), Telerik.Reporting.Drawing.Unit.Inch(1.670039176940918D));
            this.panel16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // textBox8
            // 
            this.textBox8.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D), Telerik.Reporting.Drawing.Unit.Inch(1.670039176940918D));
            this.textBox8.Style.Font.Bold = true;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "=DrawerCode";
            // 
            // panel2
            // 
            this.panel2.Docking = Telerik.Reporting.DockingStyle.Left;
            this.panel2.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel3,
            this.panel4});
            this.panel2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel2.Name = "panel2";
            this.panel2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(1.6699999570846558D));
            this.panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // panel3
            // 
            this.panel3.Docking = Telerik.Reporting.DockingStyle.Top;
            this.panel3.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.textBox5});
            this.panel3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel3.Name = "panel3";
            this.panel3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.47003936767578125D));
            this.panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // textBox1
            // 
            this.textBox1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7000000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.4699999988079071D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Mã Nguyên liệu\r\nMaterial Code";
            // 
            // textBox2
            // 
            this.textBox2.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.4699999988079071D));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "Lot Number";
            // 
            // textBox3
            // 
            this.textBox3.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.4699999988079071D));
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "Nhà CC\r\nVendor";
            // 
            // textBox4
            // 
            this.textBox4.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2999999523162842D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.4699999988079071D));
            this.textBox4.Style.Font.Bold = true;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "Nhập đầu\r\nFirst Import";
            // 
            // textBox5
            // 
            this.textBox5.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.4699999988079071D));
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox5.Value = "Ngày nhập\r\nImport Date";
            // 
            // panel4
            // 
            this.panel4.Docking = Telerik.Reporting.DockingStyle.Top;
            this.panel4.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.panel4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.47003936767578125D));
            this.panel4.Name = "panel4";
            this.panel4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            this.panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // table1
            // 
            this.table1.Bindings.Add(new Telerik.Reporting.Binding("DataSource", "=Details"));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.80000007152557373D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.80000007152557373D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.80000007152557373D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox16);
            this.table1.Body.SetCellContent(0, 1, this.textBox17);
            this.table1.Body.SetCellContent(0, 2, this.textBox6);
            this.table1.Body.SetCellContent(0, 3, this.textBox7);
            this.table1.Body.SetCellContent(0, 4, this.textBox9);
            tableGroup3.Name = "Group1";
            tableGroup4.Name = "Group2";
            tableGroup5.Name = "Group3";
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.ColumnGroups.Add(tableGroup5);
            this.table1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox16,
            this.textBox17,
            this.textBox6,
            this.textBox7,
            this.textBox9});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.table1.Name = "table1";
            tableGroup6.Groupings.AddRange(new Telerik.Reporting.Grouping[] {
            new Telerik.Reporting.Grouping("")});
            tableGroup6.Name = "detailGroup";
            this.table1.RowGroups.Add(tableGroup6);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            // 
            // textBox16
            // 
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263D), Telerik.Reporting.Drawing.Unit.Cm(1.0159997940063477D));
            this.textBox16.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox16.Style.BorderColor.Default = System.Drawing.Color.White;
            this.textBox16.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox16.Style.BorderColor.Right = System.Drawing.Color.Empty;
            this.textBox16.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox16.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox16.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox16.Style.Font.Name = "Times New Roman";
            this.textBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox16.Value = "=ReferenceInvCode";
            // 
            // textBox17
            // 
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000007152557373D), Telerik.Reporting.Drawing.Unit.Cm(1.0159997940063477D));
            this.textBox17.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox17.Style.BorderColor.Default = System.Drawing.Color.White;
            this.textBox17.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox17.Style.BorderColor.Right = System.Drawing.Color.Empty;
            this.textBox17.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox17.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox17.Style.Font.Name = "Times New Roman";
            this.textBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox17.Value = "=LotNumber";
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(96D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            this.textBox6.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox6.Style.BorderColor.Default = System.Drawing.Color.White;
            this.textBox6.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox6.Style.BorderColor.Right = System.Drawing.Color.Empty;
            this.textBox6.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox6.Style.Font.Name = "Times New Roman";
            this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox6.StyleName = "";
            this.textBox6.Value = "=VendorName";
            // 
            // textBox7
            // 
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(96.000007629394531D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            this.textBox7.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox7.Style.BorderColor.Default = System.Drawing.Color.White;
            this.textBox7.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox7.Style.BorderColor.Right = System.Drawing.Color.Empty;
            this.textBox7.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox7.Style.Font.Name = "Times New Roman";
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox7.StyleName = "";
            this.textBox7.Value = "=ImportQuantityStr";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(96.000007629394531D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            this.textBox9.Style.BorderColor.Bottom = System.Drawing.Color.Black;
            this.textBox9.Style.BorderColor.Default = System.Drawing.Color.White;
            this.textBox9.Style.BorderColor.Left = System.Drawing.Color.Black;
            this.textBox9.Style.BorderColor.Right = System.Drawing.Color.Empty;
            this.textBox9.Style.BorderColor.Top = System.Drawing.Color.Black;
            this.textBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.textBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5D);
            this.textBox9.Style.Font.Name = "Times New Roman";
            this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox9.StyleName = "";
            this.textBox9.Value = "=ImportDateStr";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D);
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.Font.Name = "Times New Roman";
            this.reportHeader.Style.Visible = false;
            // 
            // RptItemCard
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
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0D);
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
            this.Width = Telerik.Reporting.Drawing.Unit.Mm(139.99900817871094D);
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
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.Panel panel16;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.Panel panel2;
        private Telerik.Reporting.Panel panel3;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.Panel panel4;
        private Telerik.Reporting.Table table1;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox9;

    }
}