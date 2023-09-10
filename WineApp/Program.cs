using Havit.Blazor.Components.Web;
using WineApp.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var wineApiBaseUrl = configuration.GetValue<string>("WineApiBaseUrl") ?? string.Empty;
var bingMapsBaseUrl = configuration.GetValue<string>("BingMapsApi") ?? string.Empty;
var apiKey = configuration.GetValue<string>("BingMapsApiKey") ?? string.Empty;
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.RegisterUserSevices(apiKey);
builder.Services.RegisterUserMappers();

builder.Services.AddHxServices();
builder.Services.AddHxMessenger();

builder.Services.AddHttpClient("WineApi", httpClient =>
{
    httpClient.BaseAddress = new Uri(wineApiBaseUrl);
});

builder.Services.AddHttpClient("BingMaps", httpClient =>
{
    httpClient.BaseAddress = new Uri(bingMapsBaseUrl);
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
