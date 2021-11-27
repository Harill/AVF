using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Inv.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;
using Vfi.Server.Core.Repository.Inv;

namespace Vfi.Client.Module.Inv.Services
{
    public class TransactionService: ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ITransactionDetailRepository _transactionDetailRepository;
        [InjectionConstructor]
        public TransactionService(ITransactionRepository transactionRepository,
                                    ITransactionDetailRepository transactionDetailRepository)
        {
            if (transactionRepository == null) throw new ArgumentNullException("transactionRepository");
            if (transactionDetailRepository == null) throw new ArgumentNullException("transactionDetailRepository");

            _transactionRepository = transactionRepository;
            _transactionDetailRepository = transactionDetailRepository;
        }

        #region Transaction

        public IEnumerable<Transaction> GetAllTransactions()
        {
            try
            {
                return _transactionRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<TransactionDomainModel> GetAllTransactionDomainModels()
        {
            try
            {
                return GetAllTransactions().Select(
                    enity => new TransactionDomainModel
                                 {
                                     TransactionId = enity.TransactionId,
                                     TransactionCode = enity.TransactionCode,

                                     StockOrderId = enity.StockOrderId,
                                     StockOrderCode = enity.StockOrder != null ? enity.StockOrder.StockOrderCode : "",
                                     
                                     WarehouseIssueId = enity.WarehouseIssueId,
                                     WarehouseIssueName = enity.WarehouseIssue != null ? enity.WarehouseIssue.WarehouseName : "",

                                     WarehouseReceiptId = enity.WarehouseReceiptId,
                                     WarehouseReceiptName = enity.WarehouseReceipt != null ? enity.WarehouseReceipt.WarehouseName : "",
                                     
                                     MoP = enity.MoP,
                                     Status = enity.Status,
                                     Description = enity.Description,

                                     CreatedUser = enity.CreatedUser,
                                     CreatedDate = enity.CreatedDate.Value,
                                     ModifiedUser = enity.ModifiedUser,
                                     ModifiedDate = enity.ModifiedDate.Value
                                 });
            }
            catch
            {
                return null;
            }
        }
        public Transaction GetTransactionById(long transactionId)
        {
            try
            {
                return _transactionRepository.FindAsNoTracking(f => f.TransactionId == transactionId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Transaction> GetTransactionByStockOrderId(int stockOrderId)
        {
            try
            {
                return _transactionRepository.FindAsNoTracking(f => f.StockOrderId == stockOrderId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Transaction> GetTransactionByWarehouseIssueId(int warehouseIssueId)
        {
            try
            {
                return _transactionRepository.FindAsNoTracking(f=>f.WarehouseIssueId == warehouseIssueId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Transaction> GetTransactionByWarehouseReceiptId(int warehouseReceiptId)
        {
            try
            {
                return _transactionRepository.FindAsNoTracking(f => f.WarehouseIssueId == warehouseReceiptId);
            }
            catch
            {
                return null;
            }
        }
        public Transaction GetTransactionByCode(string transactionCode)
        {
            try
            {
                return
                    _transactionRepository.FindAsNoTracking(
                        f => f.TransactionCode.Equals(transactionCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Transaction> GetTransactionByMoP(bool mop)
        {
            try
            {
                return mop
                           ? _transactionRepository.FindAsNoTracking(f => f.MoP)
                           : _transactionRepository.FindAsNoTracking(f => f.MoP == false);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Transaction> GetTransactionByStatus(byte status)
        {
            try
            {
                return _transactionRepository.FindAsNoTracking(f => f.Status == status);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<TransactionDomainModel> ConvertTransactionToModels(IEnumerable<Transaction> transactions)
        {
            //try
            //{
                
            //    return transactions.Select(
            //        entity => new TransactionDomainModel
            //        {
            //            TransactionId = entity.TransactionId,
            //            TransactionCode = entity.TransactionCode,

            //            StockOrderId = entity.StockOrderId,
            //            StockOrderCode = entity.StockOrder != null ? entity.StockOrder.StockOrderCode : "",

            //            WarehouseIssueId = entity.WarehouseIssueId,
            //            WarehouseIssueName = entity.WarehouseIssue != null ? entity.WarehouseIssue.WarehouseName : "",

            //            WarehouseReceiptId = entity.WarehouseReceiptId,
            //            WarehouseReceiptName = entity.WarehouseReceipt != null ? entity.WarehouseReceipt.WarehouseName : "",

            //            EoI = entity.EoI,
            //            //EoIName = MyUtilities.. .GetTextExportOrImportEnumDomain(entity.EoI),

            //            MoP = entity.MoP,
            //            Status = entity.Status,
            //            StatusName = CastTransac/tionStatusEnumDomain.GetTextTransacti/onStatusEnumDomain(entity.Status),

            //            Description = entity.Description,

            //            Active = entity.Active,
            //            CreatedUser = entity.CreatedUser,
            //            CreatedDate = entity.CreatedDate.Value,
            //            ModifiedUser = entity.ModifiedUser,
            //            ModifiedDate = entity.ModifiedDate.Value,
            //        });
            //}
            //catch
            //{
                return null;
            //}
        }

        public string CreateTransaction(Transaction transaction)
        {
            try
            {
                var targetCreate = GetTransactionByCode(transaction.TransactionCode);
                if(targetCreate == null)
                {
                    _transactionRepository.Add(transaction);
                    var transactionDetails = transaction.TransactionDetails;
                    foreach (var transactionDetail in transactionDetails)
                    {
                        transactionDetail.TransactionId = transaction.TransactionId;
                        _transactionDetailRepository.Add(transactionDetail);
                    }

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string CreateTransactions(IEnumerable<Transaction> transactions)
        {
            try
            {
                foreach (var transaction in transactions)
                {
                    var targetCreate = GetTransactionByCode(transaction.TransactionCode);
                    if (targetCreate == null)
                    {
                        _transactionRepository.Add(transaction);
                        var transactionDetails = transaction.TransactionDetails;
                        foreach (var transactionDetail in transactionDetails)
                        {
                            transactionDetail.TransactionId = transaction.TransactionId;
                            _transactionDetailRepository.Add(transactionDetail);
                        }

                        return "1";
                    }
                }

                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        
        public string UpdateTransaction(Transaction transaction)
        {
            try
            {
                var targetUpdate =
                    _transactionRepository.Find(f => f.TransactionId == transaction.TransactionId).FirstOrDefault();
                if (targetUpdate != null)
                {

                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateStatusTransaction(long[] transactionIds, byte status, string modifiedUser)
        {
            try
            {
                var entities = _transactionRepository.Find(f => transactionIds.Contains(f.TransactionId));

                foreach (var transaction in entities)
                {
                    transaction.Status = status;
                    transaction.ModifiedUser = modifiedUser;
                    transaction.ModifiedDate = DateTime.Now;
                }

                return "1";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        
        #endregion

        #region TransactionDetail

        public IEnumerable<TransactionDetail> GetAllTransactionDetails()
        {
            try
            {
                return _transactionDetailRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<TransactionDetailDomainModel> GetAllTransactionDetailDomainModels()
        {
            try
            {
                return GetAllTransactionDetails().Select(
                    entity => new TransactionDetailDomainModel
                                  {
                                      TransactionDetailId = entity.TransactionDetailId,
                                      TransactionId = entity.TransactionId,
                                      ReferenceId = entity.ReferenceId,

                                      MoP = entity.MoP,
                                      Quantity = entity.Quantity,
                                      QuantityKg = entity.QuantityKg,
                                      Price = entity.Price,
                                      UnitMeasure = entity.UnitMeasure,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public TransactionDetail GetTransactionDetailById(long transactionDetailId)
        {
            try
            {
                return
                    _transactionDetailRepository.FindAsNoTracking(f => f.TransactionDetailId == transactionDetailId)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<TransactionDetail> GetTransactionDetailByTransactionId(long transactionId)
        {
            try
            {
                return _transactionDetailRepository.FindAsNoTracking(f=>f.TransactionId == transactionId);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<TransactionDetailDomainModel> ConvertTransactionDetailToModels(
            IEnumerable<TransactionDetail> transactionDetails)
        {
            try
            {
                return transactionDetails.Select(
                    entity =>
                        {
                            var model = new TransactionDetailDomainModel
                                            {
                                                TransactionDetailId = entity.TransactionDetailId,
                                                TransactionId = entity.TransactionId,
                                                ReferenceId = entity.ReferenceId,

                                                MoP = entity.MoP,
                                                Quantity = entity.Quantity,

                                                QuantityKg = entity.QuantityKg,
                                                Price = entity.Price,

                                                Active = entity.Active,
                                                UnitMeasure = entity.UnitMeasure,
                                                ModifiedUser = entity.ModifiedUser,
                                                ModifiedDate = entity.ModifiedDate
                                            };
                            if (model.MoP)
                            {
                                model.MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "";
                                model.MaterialName = entity.Material != null ? entity.Material.MaterialName : "";
                            }
                            else
                            {
                                model.ProductCode = entity.Product != null ? entity.Product.ProductCode : "";
                                model.ProductName = entity.Product != null ? entity.Product.ProductName : "";
                            }



                            return model;
                        });
            }
            catch
            {
                return null;
            }
        }

        

        #endregion
    }
}
