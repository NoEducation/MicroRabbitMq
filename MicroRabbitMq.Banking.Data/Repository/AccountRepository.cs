using MicroRabbitMq.Banking.Data.Context;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Banking.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbitMq.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;
        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            var accounts = this._context.Accounts.ToList();
            return accounts;
        }
    }
}
