using BlazorWeatherApp.Client; // Import the client-specific namespace for the Blazor app
using Microsoft.AspNetCore.Components.Web; // Import Blazor web components
using Microsoft.AspNetCore.Components.WebAssembly.Hosting; // Import Blazor WebAssembly hosting

// Create a WebAssemblyHostBuilder with default settings
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the root App component to the #app element in index.html
builder.RootComponents.Add<App>("#app");

// Register the HeadOutlet component for managing the document head
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient as a scoped service with the base address set to the app's host environment
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

// Build and run the Blazor WebAssembly application
await builder.Build().RunAsync();