using System;
using CapitalOne_Interview.BusinessObject;
namespace CapitalOne_Interview.Interface
{
    /// <summary>
    /// IProcess Interface
    /// </summary>
    interface ITransactionDataAccess
    {
        string CalculateTransactions(bool ignoreDonutTransactions, TransactionCollection transactionCollection);

        string GetCreditCardTransactions(TransactionCollection transactionCollection);
    }
}
