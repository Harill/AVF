namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    public partial class RptPrintNewAssignMaterial : Telerik.Reporting.Report
    {
        public RptPrintNewAssignMaterial()
        {
            InitializeComponent();
            Name = "PhieuPhatNL";
        }
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}