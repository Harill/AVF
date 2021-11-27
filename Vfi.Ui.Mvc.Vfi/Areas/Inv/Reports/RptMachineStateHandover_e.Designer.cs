namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    partial class RptMachineStateHandover_e
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
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox34 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.textBox25 = new Telerik.Reporting.TextBox();
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
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D);
            this.pageFooter.Name = "pageFooter";
            this.pageFooter.PrintOnFirstPage = false;
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Format = "{0:dd/MM HH:mm}";
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2082972526550293D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9498428106307983D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.currentTimeTextBox.Style.Font.Name = "Arial";
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // detail
            // 
            formattingRule1.Filters.AddRange(new Telerik.Reporting.Filter[] {
            new Telerik.Reporting.Filter("=RowNumber() % 2", Telerik.Reporting.FilterOperator.Equal, "0")});
            formattingRule1.StopIfTrue = true;
            formattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.detail.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox16,
            this.textBox19,
            this.textBox5,
            this.textBox18,
            this.textBox20,
            this.textBox21,
            this.textBox22,
            this.textBox23,
            this.textBox24,
            this.textBox25});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detail.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1D);
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.9000003337860107D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.currentTimeTextBox,
            this.textBox34});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Docking = Telerik.Reporting.DockingStyle.Top;
            this.titleTextBox.KeepTogether = true;
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.1584548950195312D), Telerik.Reporting.Drawing.Unit.Inch(1.3188163042068481D));
            this.titleTextBox.Style.Font.Bold = true;
            this.titleTextBox.Style.Font.Name = "Arial";
            this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15D);
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "BIÊN BẢN BÀN GIAO CA";
            // 
            // textBox34
            // 
            this.textBox34.Format = "{0:dd/MM HH:mm}";
            this.textBox34.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373D));
            this.textBox34.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox34.Style.Font.Name = "Arial";
            this.textBox34.StyleName = "PageInfo";
            this.textBox34.Value = "Ca 1 : 7h -> 19h\r\nCa 2 : 19h -> 7h";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox4.Format = "{0}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49984267354011536D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox4.Style.Font.Name = "Arial";
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= RowNumber()";
            // 
            // textBox16
            // 
            this.textBox16.CanGrow = true;
            this.textBox16.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox16.Format = "{0:dd/MM/yyyy}";
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.49984267354011536D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox16.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox16.Style.Font.Name = "Arial";
            this.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox16.StyleName = "Data";
            this.textBox16.Value = "=MachineName";
            // 
            // textBox19
            // 
            this.textBox19.CanGrow = true;
            this.textBox19.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox19.Format = "{0:N0}";
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1998426914215088D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox19.Style.Font.Name = "Arial";
            this.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox19.StyleName = "Data";
            this.textBox19.Value = "=ProductCode";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox5.Format = "{0:N0}";
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1998426914215088D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49999991059303284D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox5.Style.Font.Name = "Arial";
            this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "=IIF(NormalState, \"V\", \"\")";
            // 
            // textBox18
            // 
            this.textBox18.CanGrow = true;
            this.textBox18.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox18.Format = "{0:N0}";
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6998424530029297D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49999991059303284D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox18.Style.Font.Name = "Arial";
            this.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox18.StyleName = "Data";
            this.textBox18.Value = "=IIF(ErrorState, \"V\", \"\")";
            // 
            // textBox20
            // 
            this.textBox20.CanGrow = true;
            this.textBox20.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox20.Format = "{0:N0}";
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1998424530029297D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49999991059303284D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox20.Style.Font.Name = "Arial";
            this.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox20.StyleName = "Data";
            this.textBox20.Value = "=IIF(SetupState, \"V\", \"\")";
            // 
            // textBox21
            // 
            this.textBox21.CanGrow = true;
            this.textBox21.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox21.Format = "{0:N0}";
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6998424530029297D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox21.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox21.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox21.Style.Font.Name = "Arial";
            this.textBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox21.StyleName = "Data";
            this.textBox21.Value = "=RunningTime";
            // 
            // textBox22
            // 
            this.textBox22.CanGrow = true;
            this.textBox22.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox22.Format = "{0:N0}";
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.299842357635498D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.60000050067901611D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox22.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox22.Style.Font.Name = "Arial";
            this.textBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox22.StyleName = "Data";
            this.textBox22.Value = "=ErrorTime";
            // 
            // textBox23
            // 
            this.textBox23.CanGrow = true;
            this.textBox23.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox23.Format = "{0:N0}";
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8998432159423828D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.59999924898147583D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox23.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox23.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox23.Style.Font.Name = "Arial";
            this.textBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox23.StyleName = "Data";
            this.textBox23.Value = "=ProductionMaterialPlan";
            // 
            // textBox24
            // 
            this.textBox24.CanGrow = true;
            this.textBox24.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox24.Format = "{0:N0}";
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4998421669006348D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.59999966621398926D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox24.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox24.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox24.Style.Font.Name = "Arial";
            this.textBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox24.StyleName = "Data";
            this.textBox24.Value = "=ProductionProductPlan";
            // 
            // textBox25
            // 
            this.textBox25.CanGrow = true;
            this.textBox25.Docking = Telerik.Reporting.DockingStyle.Left;
            this.textBox25.Format = "{0:N0}";
            this.textBox25.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0998420715332031D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.058297872543335D), Telerik.Reporting.Drawing.Unit.Inch(0.31897386908531189D));
            this.textBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            this.textBox25.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox25.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox25.Style.Font.Name = "Arial";
            this.textBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox25.StyleName = "Data";
            this.textBox25.Value = "";
            // 
            // RptMachineStateHandover_e
            // 
            this.DataSource = this.objectDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(7.1584548950195312D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.ObjectDataSource objectDataSource1;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox textBox34;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox25;

    }
}