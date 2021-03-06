using MicroRabbitMq.Presentation.Models.Dto;
using System.Threading.Tasks;

namespace MicroRabbitMq.Presentation.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto target);
    }
}
