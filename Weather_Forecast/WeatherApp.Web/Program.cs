using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WeatherApp.Web;
using MudBlazor.Services;
using System.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//// Hardcoded API URL
string hardcodedApiUrl = "https://localhost:7235/"; // Replace with your actual hardcoded API URL
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(hardcodedApiUrl) });

//string? apiBaseUrl = builder.Configuration["ApiSettings:WeatherAPI"];

//var apiBaseUrl = builder.HostEnvironment.BaseAddress;

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl!) }); // Use '!' for null-forgiving operator if you're sure it won't be null


//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(GetValue<string>("WeatherAPI"));

//builder.Services.AddMudServices();

await builder.Build().RunAsync();
