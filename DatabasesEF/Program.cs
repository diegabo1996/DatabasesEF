using DatabasesEF.ControlDB;
using DatabasesEF.Interfaces;
using DatabasesEF.Models;
using DatabasesEF.Repository;
using System;
using System.Linq;

namespace DatabasesEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContextMoney context = new ContextMoney();
            IMoneyControlDatabaseTransactions Transaction = new MoneyControlRepository(context);
            MoneyControl reg = new MoneyControl();
            reg.TransactionDateTime = DateTime.Now;
            reg.Description = "FIESTA ADRI";
            //reg.Details = "Salario de Nike";
            reg.IncomeTransaction = false;
            reg.AmountTransaction = 350;
            if (reg.IncomeTransaction == false)
            {
                reg.AmountTransaction = (reg.AmountTransaction * -1);
            }
            reg.BalanceTransaction = BalanceSum(Transaction, reg.AmountTransaction);
            Transaction.Create(reg);
            Console.WriteLine(Transaction.Read());
        }
        private static double BalanceSum(IMoneyControlDatabaseTransactions Transaction, double AmountTransaction)
        {
            var ListTransaction = Transaction.Read();
            double SumList = ListTransaction.Sum(x => x.AmountTransaction);
            return SumList + AmountTransaction;
        }
    }
}
