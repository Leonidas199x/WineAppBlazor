using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IRetailerMapper
    {
        Retailer Map(RetailerViewModel value);

        RetailerViewModel Map(Retailer value);

        RetailerCreate MapNew(RetailerViewModel value);
    }
}