using MicroRabbitMq.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbitMq.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
