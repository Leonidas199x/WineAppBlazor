using Havit.Blazor.Components.Web;
using WineApp.Domain;
using WineApp.Domain.Countries;
using WineApp.Mappers;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var wineApiBaseUrl = configuration.GetValue<string>("WineApiBaseUrl") ?? string.Empty;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<IHttpRequestHandler, HttpRequestHandler>();
builder.Services.AddTransient<ICountryService, CountryService>();
builder.Services.AddSingleton<ICountryMapper, CountryMapper>();

builder.Services.AddHxServices();
builder.Services.AddHxMessenger();

builder.Services.AddHttpClient("WineApi", httpClient =>
{
    httpClient.BaseAddress = new Uri(wineApiBaseUrl);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
