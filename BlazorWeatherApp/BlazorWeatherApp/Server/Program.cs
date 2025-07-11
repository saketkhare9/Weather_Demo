using BlazorWeatherApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

// Create a new WebAssembly host builder with default settings.
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root App component to the HTML element with id "app".
builder.RootComponents.Add<App>("#app");

// Register the HeadOutlet component to manage content in the <head> section.
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient as a scoped service, configured with the application's base address.
// This allows making HTTP requests to the backend API.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Build and run the Blazor WebAssembly application.
await builder.Build().RunAsync();

