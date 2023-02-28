using PlaformService.Dtos;

namespace PlaformService.SyncDataServices.Http
{
    public class CommandDataClient : ICommandDataClient
    {
        HttpClient httpClient;

        public CommandDataClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task SendPlatformToCommand(PlatformReadDto model)
        {

        }
    }
}
