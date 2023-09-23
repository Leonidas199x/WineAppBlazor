using DataContract;

namespace WineApp.Domain.Producer
{
    public interface IProducerService
    {
        Task<Result<IEnumerable<ProducerLookup>>> GetLookup();
    }
}