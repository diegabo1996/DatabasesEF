using DatabasesEF.ControlDB;
using DatabasesEF.Interfaces;
using DatabasesEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesEF.Repository
{
    public class MoneyControlRepository : IMoneyControlDatabaseTransactions
    {
        ContextMoney context;
        public MoneyControlRepository (ContextMoney contextNew)
        {
            context = contextNew;
        }
        public void Create(MoneyControl Transaction)
        {
            context.Add(Transaction);
            context.SaveChanges();
        }

        public void Delete(MoneyControl Transaction)
        {
            context.Remove(Transaction);
            context.SaveChanges();
        }

        public List<MoneyControl> Read()
        {
            return context.RegistryMoneyControl.ToList();
        }

        public MoneyControl Read(Guid guid)
        {
            return context.RegistryMoneyControl.Find(guid);
        }

        public void Update(MoneyControl Transaction)
        {
            context.Update(Transaction);
        }
    }
}
