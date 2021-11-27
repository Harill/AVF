<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports" %>


<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.1.11.713, Culture=neutral, PublicKeyToken=A9D7983DFCC261BE" 
namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<script runat="server">
        
    public override void VerifyRenderingInServerForm(Control control)
    {
        // to avoid the server form (<form runat="server">) requirement
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
            
        // bind the report viewer
        var rp = new RptProductInvManagementForPeriod();
        //rp.ReferenceTypeParam = "M";
        
        //rp.BindDataOwner();
        rp.BindDataOwner(Model);
        
        rptvPageReportProductInvManagementForPeriod.Report = rp;   
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>
<%--<telerik:ReportViewer ID="rptvPageReportMaterialInvManagement" runat="server">
</telerik:ReportViewer>--%>
<%--
public void BindDataOwner(object models)
        {
            DataSource = models;
        }
--%>


<telerik:ReportViewer ID="rptvPageReportProductInvManagementForPeriod" runat="server" Width="100%" Height="100%" >
</telerik:ReportViewer>



