using System;
using System.Collections.Generic;
using FinanceApp.Models;
using FinanceApp.Accounts;
using FinanceApp.Interfaces;
using FinanceApp.Processors;

namespace FinanceApp.App
{
    public class FinanceApp
    {
        private List<Transaction> _transactions = new();

        public void Run()
        {
            var account = new SavingsAccount("UG12345", 1000m);

            var transaction1 = new Transaction(1, DateTime.Now, 150m, "Groceries");
            var transaction2 = new Transaction(2, DateTime.Now, 300m, "Utilities");
            var transaction3 = new Transaction(3, DateTime.Now, 200m, "Entertainment");

            ITransactionProcessor mobileMoney = new MobileMoneyProcessor();
            ITransactionProcessor bankTransfer = new BankTransferProcessor();
            ITransactionProcessor crypto = new CryptoWalletProcessor();

            mobileMoney.Process(transaction1);
            account.ApplyTransaction(transaction1);

            bankTransfer.Process(transaction2);
            account.ApplyTransaction(transaction2);

            crypto.Process(transaction3);
            account.ApplyTransaction(transaction3);

            _transactions.Add(transaction1);
            _transactions.Add(transaction2);
            _transactions.Add(transaction3);
        }
    }
}
