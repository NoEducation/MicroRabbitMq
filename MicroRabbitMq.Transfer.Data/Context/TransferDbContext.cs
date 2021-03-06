using MicroRabbitMq.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbitMq.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions<TransferDbContext> options) : base(options)
        {}

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
} 
