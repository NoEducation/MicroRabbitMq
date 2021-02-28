using MicroRabbitMq.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMq.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();
    }
}
