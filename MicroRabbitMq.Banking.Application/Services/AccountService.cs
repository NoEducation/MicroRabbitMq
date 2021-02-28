using MicroRabbitMq.Banking.Application.Interfaces;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMq.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            var accounts = this._accountRepository.GetAllAccounts();
            return accounts;
        }
    }
}
