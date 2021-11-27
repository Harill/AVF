namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    public partial class RptPrintMaterialUseForm : Telerik.Reporting.Report
    {
        public RptPrintMaterialUseForm()
        {
            InitializeComponent();
            Name = "PhieuSuDungNL";
        }
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}