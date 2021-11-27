
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Client.Module.Sales.Interfaces
{
    public interface IInvoiceService
    {
        #region Invoice

        IEnumerable<Invoice> GetAllInvoices();
        IEnumerable<InvoiceDomainModel> GetAllInvoiceDomainModels();
        Invoice GetInvoiceById(long invoiceId);
        Invoice GetInvoiceByCustomerId(int customerId);

        string CreateInvoice(Invoice invoice);
        string UpdateInvoice(Invoice invoice);

        #endregion

        #region Invoice Detail

        IEnumerable<InvoiceDetail> GetAllInvoiceDetails();
        //IEnumerable<InvoiceDetailDomainModel> GetAllInvoiceDetailDomainModels();
        InvoiceDetail GetInvoiceDetailById(long invoiceDetailId);
        IEnumerable<InvoiceDetail> GetInvoiceDetailByInvoiceId(long invoiceId);

        #endregion
    }
}
