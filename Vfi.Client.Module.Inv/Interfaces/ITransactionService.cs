
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Client.Module.Inv.Interfaces
{
    public interface ITransactionService
    {
        #region Transaction

        IEnumerable<Transaction> GetAllTransactions();
        IEnumerable<TransactionDomainModel> GetAllTransactionDomainModels();
        Transaction GetTransactionById(long transactionId);
        IEnumerable<Transaction> GetTransactionByStockOrderId(int stockOrderId);
        IEnumerable<Transaction> GetTransactionByWarehouseIssueId(int warehouseIssueId);
        IEnumerable<Transaction> GetTransactionByWarehouseReceiptId(int warehouseReceiptId);
        Transaction GetTransactionByCode(string transactionCode);
        IEnumerable<Transaction> GetTransactionByMoP(bool mop);
        IEnumerable<Transaction> GetTransactionByStatus(byte status);

        IEnumerable<TransactionDomainModel> ConvertTransactionToModels(IEnumerable<Transaction> transactions);

        string CreateTransaction(Transaction transaction);
        string CreateTransactions(IEnumerable<Transaction> transactions);

        string UpdateTransaction(Transaction transaction);
        string UpdateStatusTransaction(long[] transactionIds, byte status, string modifiedUser);
        
        #endregion

        #region TransactionDetail

        IEnumerable<TransactionDetail> GetAllTransactionDetails();
        IEnumerable<TransactionDetailDomainModel> GetAllTransactionDetailDomainModels();
        TransactionDetail GetTransactionDetailById(long transactionDetailId);
        IEnumerable<TransactionDetail> GetTransactionDetailByTransactionId(long transactionId);

        IEnumerable<TransactionDetailDomainModel> ConvertTransactionDetailToModels(
            IEnumerable<TransactionDetail> transactionDetails);

        #endregion
    }
}
