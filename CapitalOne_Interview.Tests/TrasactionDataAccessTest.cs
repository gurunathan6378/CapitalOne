using CapitalOne_Interview.BusinessObject;
// <copyright file="TrasactionDataAccessTest.cs">Copyright ©  2017</copyright>

using System;
using CapitalOne_Interview.DataAccess;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalOne_Interview.DataAccess.Tests
{
    /// <summary>This class contains parameterized unit tests for TrasactionDataAccess</summary>
    [TestClass]
    [PexClass(typeof(TrasactionDataAccess))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TrasactionDataAccessTest
    {

        /// <summary>Test stub for CalculateTransactions(Boolean, TransactionCollection)</summary>
        [PexMethod]
        public string CalculateTransactionsTest(
            [PexAssumeUnderTest]TrasactionDataAccess target,
            bool ignoreDonutTransactions,
            TransactionCollection transactions
        )
        {
            string result = target.CalculateTransactions(ignoreDonutTransactions, transactions);
            return result;
            // TODO: add assertions to method TrasactionDataAccessTest.CalculateTransactionsTest(TrasactionDataAccess, Boolean, TransactionCollection)
        }

        /// <summary>Test stub for GetCreditCardTransactions(TransactionCollection)</summary>
        [PexMethod]
        public string GetCreditCardTransactionsTest([PexAssumeUnderTest]TrasactionDataAccess target, TransactionCollection transactions)
        {
            string result = target.GetCreditCardTransactions(transactions);
            return result;
            // TODO: add assertions to method TrasactionDataAccessTest.GetCreditCardTransactionsTest(TrasactionDataAccess, TransactionCollection)
        }
       
    }
}
