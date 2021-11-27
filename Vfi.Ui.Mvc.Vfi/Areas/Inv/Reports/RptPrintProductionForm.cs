namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    public partial class RptPrintProductionForm : Telerik.Reporting.Report
    {
        public RptPrintProductionForm()
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