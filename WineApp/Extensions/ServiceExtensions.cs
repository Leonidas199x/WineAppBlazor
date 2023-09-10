using WineApp.Domain.Countries;
using WineApp.Domain.Drinker;
using WineApp.Domain.GrapeColour;
using WineApp.Domain.StopperType;
using WineApp.Domain;
using WineApp.Mappers;
using WineApp.Domain.Retailer;
using WineApp.Domain.Region;

namespace WineApp.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterUserSevices(this IServiceCollection services) 
        {
            services.AddTransient<IHttpRequestHandler, HttpRequestHandler>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IGrapeColourService, GrapeColourService>();
            services.AddTransient<IStopperTypeService, StopperTypeService>();
            services.AddTransient<IDrinkerService, DrinkerService>();
            services.AddTransient<IRetailerService, RetailerService>();
            services.AddTransient<IRegionService, RegionService>();
        }

        public static void RegisterUserMappers(this IServiceCollection services) 
        {
            services.AddSingleton<ICountryMapper, CountryMapper>();
            services.AddSingleton<IGrapeColourMapper, GrapeColourMapper>();
            services.AddSingleton<IStopperTypeMapper, StopperTypeMapper>();
            services.AddSingleton<IDrinkerMapper, DrinkerMapper>();
            services.AddSingleton<IRetailerMapper, RetailerMapper>();
            services.AddSingleton<IRegionMapper, RegionMapper>();
        }
    }
}
