using WineApp.Domain;
using WineApp.Mappers;
using WineApp.Domain.Maps;
using WineApp.Domain.Wine;
using WineApp.Domain.Rating;
using WineApp.Domain.Issue;

namespace WineApp.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterUserSevices(this IServiceCollection services, string apiKey) 
        {
            services.AddTransient<IMapsService>(x => new MapsService(apiKey, x.GetRequiredService<IHttpRequestHandler>()));
            services.AddTransient<IHttpRequestHandler, HttpRequestHandler>();
            services.AddTransient<IRequestService, RequestService>();
            services.AddTransient<IWineService, WineService>();
            services.AddTransient<IRatingService, RatingService>();
            services.AddTransient<IIssueService, IssueService>();
        }

        public static void RegisterUserMappers(this IServiceCollection services) 
        {
            services.AddSingleton<ICountryMapper, CountryMapper>();
            services.AddSingleton<IGrapeColourMapper, GrapeColourMapper>();
            services.AddSingleton<IStopperTypeMapper, StopperTypeMapper>();
            services.AddSingleton<IRetailerMapper, RetailerMapper>();
            services.AddSingleton<IRegionMapper, RegionMapper>();
            services.AddSingleton<IVineyardEstateMapper, VineyardEstateMapper>();
            services.AddSingleton<IWineTypeMapper, WineTypeMapper>();
            services.AddSingleton<IQualityControlMapper, QualityControlMapper>();
        }
    }
}
