using MicroRabbitMq.Banking.Application.Interfaces;
using MicroRabbitMq.Banking.Application.Models;
using MicroRabbitMq.Banking.Domain.Commands;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Banking.Domain.Models;
using MicroRabbitMq.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbitMq.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository,
            IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            var accounts = this._accountRepository.GetAllAccounts();
            return accounts;
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.Amount);

            _bus.SendCommand(createTransferCommand);
        }
    }
}
