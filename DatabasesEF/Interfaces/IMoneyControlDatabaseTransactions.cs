﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabasesEF.Models;

namespace DatabasesEF.Interfaces
{
    public interface IMoneyControlDatabaseTransactions
    {
        void Create(MoneyControl Transaction);
        List<MoneyControl> Read();
        MoneyControl Read(Guid guid);
        void Update(MoneyControl Transaction);
        void Delete(MoneyControl Transaction);

    }
}
