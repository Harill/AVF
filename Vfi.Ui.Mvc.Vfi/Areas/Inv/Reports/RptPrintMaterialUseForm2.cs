namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    public partial class RptPrintMaterialUseForm2 : Telerik.Reporting.Report
    {
        public RptPrintMaterialUseForm2()
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