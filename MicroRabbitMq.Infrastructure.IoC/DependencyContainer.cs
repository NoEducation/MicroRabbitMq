using MediatR;
using MicroRabbitMq.Banking.Application.Interfaces;
using MicroRabbitMq.Banking.Application.Services;
using MicroRabbitMq.Banking.Data.Context;
using MicroRabbitMq.Banking.Data.Repository;
using MicroRabbitMq.Banking.Domain.CommandHandlers;
using MicroRabbitMq.Banking.Domain.Commands;
using MicroRabbitMq.Banking.Domain.Interfaces;
using MicroRabbitMq.Domain.Core.Bus;
using MicroRabbitMq.Infrastructure.Bus;
using MicroRabbitMq.Transfer.Application.Interfaces;
using MicroRabbitMq.Transfer.Application.Services;
using MicroRabbitMq.Transfer.Data.Context;
using MicroRabbitMq.Transfer.Data.Repository;
using MicroRabbitMq.Transfer.Domain.EventHandlers;
using MicroRabbitMq.Transfer.Domain.Events;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbitMq.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterCommonServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMqBus>();
        }

        public static void RegisterTransferServices(IServiceCollection services)
        {
            services.AddTransient<ITransferService, TransferService>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDbContext>();
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
        }

        public static void RegisterBankingServices(IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, CreateTransferCommandHandler>();
        }

    }
}
