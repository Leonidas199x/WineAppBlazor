namespace WineApp.Domain.GoogleMaps
{
    public interface IGoogleMapsService
    {
        Task<Result<MapInfo>> GetRegionInfo(string region);
    }
}