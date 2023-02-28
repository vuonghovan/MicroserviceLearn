using PlaformService.Dtos;

namespace PlaformService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto model);
    }
}
