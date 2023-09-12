namespace WineApp.Domain.Maps
{
    public interface IMapsService
    {
        Task<Result<MapInfo>> GetRegionInfo(string region);
    }
}