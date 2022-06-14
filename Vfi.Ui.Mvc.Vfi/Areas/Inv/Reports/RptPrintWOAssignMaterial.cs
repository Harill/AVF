namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    public partial class RptPrintWOAssignMaterial : Telerik.Reporting.Report
    {
        public RptPrintWOAssignMaterial()
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