namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    partial class RptAssignProductionTool
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule2 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.objectDataSource1 = new Telerik.Reporting.ObjectDataSource();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.panel2 = new Telerik.Reporting.Panel();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox31 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.panel1 = new Telerik.Reporting.Panel();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox28 = new Telerik.Reporting.TextBox();
            this.textBox30 = new Telerik.Reporting.TextBox();
            this.textBox32 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
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
            this.panel2,
            this.panel1});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.labelsGroupHeader.Style.Font.Name = "Times New Roman";
            // 
            // panel2
            // 
            this.panel2.Docking = Telerik.Reporting.DockingStyle.Bottom;
            this.panel2.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox3,
            this.textBox6,
            this.textBox7,
            this.textBox31,
            this.textBox1});
            this.panel2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.33102622628211975D));
            this.panel2.Name = "panel2";
            this.panel2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel2.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox3.Format = "";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39988183975219727D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.Style.Font.Name = "Times New Roman";
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "=Count(ToolTypeName)";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox6.Format = "";
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.39988183975219727D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.3001179695129395D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox6.Style.Font.Bold = true;
            this.textBox6.Style.Font.Name = "Times New Roman";
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = " ";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox7.Format = "{0:n0}";
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6999998092651367D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6999211311340332D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.Font.Name = "Times New Roman";
            this.textBox7.StyleName = "Data";
            this.textBox7.Value = "=Sum(ToolInv)";
            // 
            // textBox31
            // 
            this.textBox31.CanGrow = true;
            this.textBox31.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox31.Format = "{0:n0}";
            this.textBox31.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3999214172363281D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999994158744812D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox31.Style.Font.Bold = true;
            this.textBox31.Style.Font.Name = "Times New Roman";
            this.textBox31.StyleName = "Data";
            this.textBox31.Value = "=sum(PrepareQuantity)";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox1.Format = "";
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.199920654296875D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5000401735305786D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Times New Roman";
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = " ";
            // 
            // panel1
            // 
            this.panel1.Docking = Telerik.Reporting.DockingStyle.Bottom;
            this.panel1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox5,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox12,
            this.textBox14,
            this.textBox17,
            this.textBox18});
            this.panel1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.050000030547380447D));
            this.panel1.Name = "panel1";
            this.panel1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.panel1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.panel1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(0D);
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox5.Format = "";
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39988183975219727D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Style.Font.Name = "Times New Roman";
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "STT";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox9.Format = "";
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.39988183975219727D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0001182556152344D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Style.Font.Name = "Times New Roman";
            this.textBox9.StyleName = "Data";
            this.textBox9.Value = "Loại công cụ";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox10.Format = "";
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999998092651367D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox10.Style.Font.Bold = true;
            this.textBox10.Style.Font.Name = "Times New Roman";
            this.textBox10.StyleName = "Data";
            this.textBox10.Value = "Mã công cụ";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox11.Format = "";
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992121458053589D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.Style.Font.Name = "Times New Roman";
            this.textBox11.StyleName = "Data";
            this.textBox11.Value = "Máy";
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = true;
            this.textBox12.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox12.Format = "";
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.89992094039917D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80007916688919067D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox12.Style.Font.Bold = true;
            this.textBox12.Style.Font.Name = "Times New Roman";
            this.textBox12.StyleName = "Data";
            this.textBox12.Value = "Sản phẩm";
            // 
            // textBox14
            // 
            this.textBox14.CanGrow = true;
            this.textBox14.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox14.Format = "";
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6999998092651367D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6999211311340332D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox14.Style.Font.Bold = true;
            this.textBox14.Style.Font.Name = "Times New Roman";
            this.textBox14.StyleName = "Data";
            this.textBox14.Value = "Tồn kho";
            // 
            // textBox17
            // 
            this.textBox17.CanGrow = true;
            this.textBox17.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox17.Format = "";
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3999214172363281D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999994158744812D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox17.Style.Font.Bold = true;
            this.textBox17.Style.Font.Name = "Times New Roman";
            this.textBox17.StyleName = "Data";
            this.textBox17.Value = "Số lượng cần";
            // 
            // textBox18
            // 
            this.textBox18.CanGrow = true;
            this.textBox18.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox18.Format = "";
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.199920654296875D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5000401735305786D), Telerik.Reporting.Drawing.Unit.Inch(0.2810262143611908D));
            this.textBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.Font.Bold = true;
            this.textBox18.Style.Font.Name = "Times New Roman";
            this.textBox18.StyleName = "Data";
            this.textBox18.Value = "Ghi Chú";
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D);
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
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.92007905244827271D);
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
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox16,
            this.textBox19,
            this.textBox28,
            this.textBox30,
            this.textBox32,
            this.textBox2,
            this.textBox8});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted;
            this.detail.Style.Font.Name = "Times New Roman";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox4.Format = "{0}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9577484130859375E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39988157153129578D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox4.Style.Font.Name = "Times New Roman";
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= RowNumber()";
            // 
            // textBox16
            // 
            this.textBox16.CanGrow = true;
            this.textBox16.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox16.Format = "{0:dd/MM/yyyy}";
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.39988157153129578D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.000118613243103D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox16.Style.Font.Name = "Times New Roman";
            this.textBox16.StyleName = "Data";
            this.textBox16.Value = "=ToolTypeName";
            // 
            // textBox19
            // 
            this.textBox19.CanGrow = true;
            this.textBox19.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox19.Format = "{0:N0}";
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999996900558472D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox19.Style.Font.Name = "Times New Roman";
            this.textBox19.StyleName = "Data";
            this.textBox19.Value = "=ToolFullCode";
            // 
            // textBox28
            // 
            this.textBox28.CanGrow = true;
            this.textBox28.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox28.Format = "{0:N0}";
            this.textBox28.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0999996662139893D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80007916688919067D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox28.Style.Font.Name = "Times New Roman";
            this.textBox28.StyleName = "Data";
            this.textBox28.Value = "=MachineName";
            // 
            // textBox30
            // 
            this.textBox30.CanGrow = true;
            this.textBox30.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox30.Format = "{0:n1}";
            this.textBox30.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9000790119171143D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79984205961227417D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox30.Style.Font.Name = "Times New Roman";
            this.textBox30.StyleName = "Data";
            this.textBox30.Value = "=ProductCode";
            // 
            // textBox32
            // 
            this.textBox32.CanGrow = true;
            this.textBox32.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox32.Format = "";
            this.textBox32.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6999211311340332D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox32.Style.Font.Name = "Times New Roman";
            this.textBox32.StyleName = "Data";
            this.textBox32.Value = "=ToolInv";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            formattingRule2.Filters.AddRange(new Telerik.Reporting.Filter[] {
            new Telerik.Reporting.Filter("=PrepareQuantity", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=ToolInv")});
            formattingRule2.Style.BackgroundColor = System.Drawing.Color.Yellow;
            formattingRule2.Style.Font.Bold = true;
            this.textBox2.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule2});
            this.textBox2.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox2.Format = "{0}";
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3999214172363281D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79999905824661255D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox2.Style.Font.Name = "Times New Roman";
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=PrepareQuantity";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox8.Format = "{0}";
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.199920654296875D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5000399351119995D), Telerik.Reporting.Drawing.Unit.Inch(0.25D));
            this.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox8.Style.Font.Name = "Times New Roman";
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "=Fields.Note";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5D);
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
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6999607086181641D), Telerik.Reporting.Drawing.Unit.Inch(0.5D));
            this.titleTextBox.Style.Font.Bold = true;
            this.titleTextBox.Style.Font.Name = "Times New Roman";
            this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "DANH SÁCH CÔNG CỤ ĐANG SỬ DỤNG";
            // 
            // RptAssignProductionTool
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(7.6999607086181641D);
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
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox28;
        private Telerik.Reporting.TextBox textBox30;
        private Telerik.Reporting.TextBox textBox32;
        private Telerik.Reporting.Panel panel2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox31;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.Panel panel1;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox18;

    }
}