using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Sales.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Client.Module.Sales.Services
{
    public class InvoiceService: IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IInvoiceDetailRepository _invoiceDetailRepository;
        [InjectionConstructor]
        public InvoiceService(IInvoiceRepository invoiceRepository, 
                                IInvoiceDetailRepository invoiceDetailRepository)
        {
            if (invoiceRepository == null) throw new ArgumentNullException("invoiceRepository");
            if (invoiceDetailRepository == null) throw new ArgumentNullException("invoiceDetailRepository");

            _invoiceRepository = invoiceRepository;
            _invoiceDetailRepository = invoiceDetailRepository;
        }

        #region Invoice
        
        public IEnumerable<Invoice> GetAllInvoices()
        {
            try
            {
                return _invoiceRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<InvoiceDomainModel> GetAllInvoiceDomainModels()
        {
            try
            {
                return GetAllInvoices().Select(
                    entity => new InvoiceDomainModel
                                  {
                                      InvoiceId = entity.InvoiceId,
                                      CustomerId = entity.CustomerId,
                                      PriceListId = entity.PriceListId,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public Invoice GetInvoiceById(long invoiceId)
        {
            try
            {
                return _invoiceRepository.FindAsNoTracking(f=>f.InvoiceId == invoiceId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public Invoice GetInvoiceByCustomerId(int customerId)
        {
            try
            {
                return _invoiceRepository.FindAsNoTracking(f => f.CustomerId == customerId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public string CreateInvoice(Invoice invoice)
        {
            try
            {
                var targetCreate = GetInvoiceById(invoice.InvoiceId);
                if(targetCreate == null)
                {
                    _invoiceRepository.Add(invoice);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateInvoice(Invoice invoice)
        {
            try
            {
                var targetUpdate = _invoiceRepository.Find(f => f.InvoiceId == invoice.InvoiceId).FirstOrDefault();
                if (targetUpdate == null)
                {
                    

                    //return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        
        #endregion

        #region Invoice Detail

        public IEnumerable<InvoiceDetail> GetAllInvoiceDetails()
        {
            try
            {
                return _invoiceDetailRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        //IEnumerable<InvoiceDetailDomainModel> GetAllInvoiceDetailDomainModels();
        public InvoiceDetail GetInvoiceDetailById(long invoiceDetailId)
        {
            try
            {
                return _invoiceDetailRepository.FindAsNoTracking(
                        f => f.InvoiceDetailId == invoiceDetailId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<InvoiceDetail> GetInvoiceDetailByInvoiceId(long invoiceId)
        {
            try
            {
                return _invoiceDetailRepository.FindAsNoTracking(f => f.InvoiceId == invoiceId);
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
