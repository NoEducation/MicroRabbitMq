using MicroRabbitMq.Presentation.Models.Dto;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbitMq.Presentation.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;
        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDto target)
        {
            var uri = "http://localhost:5001/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(target),
                System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PatchAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
