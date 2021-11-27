namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    public partial class RptPrintProductionForm2 : Telerik.Reporting.Report
    {
        public RptPrintProductionForm2()
        {
            InitializeComponent();
            Name = "CanHang";
        }
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}