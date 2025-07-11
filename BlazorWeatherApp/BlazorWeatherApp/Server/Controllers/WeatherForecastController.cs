// This controller provides the API endpoint to fetch weather data.
// In a real application, this would interact with a database.
using BlazorWeatherApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeatherApp.Server.Controllers
{
    // Marks this class as an API controller and sets up routing based on the controller name.
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        // List of possible weather summaries, including normal, harsh, and dangerous conditions.
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Cloudy", "Sunny", "Rainy"
        };

        // List of locations to generate weather data for.
        private static readonly string[] Locations = new[]
        {
            "Pune", "Bengaluru", "Hyderabad", "Indore", "Mumbai", "Delhi", "Chennai", "Kolkata"
        };

        // HTTP GET endpoint: /WeatherForecast
        // Returns a list of weather forecasts for multiple locations.
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var forecasts = new List<WeatherForecast>();

            // Generate weather data for each location for 5 days
            foreach (var location in Locations)
            {
                for (int i = 0; i < 5; i++)
                {
                    forecasts.Add(new WeatherForecast
                    {
                        Date = DateTime.Now.AddDays(i), // Forecast date
                        TemperatureC = rng.Next(-10, 45), // Random temperature in Celsius
                        Summary = Summaries[rng.Next(Summaries.Length)], // Random weather summary
                        Location = location // Current location
                    });
                }
            }

            // Return the forecasts, ordered by location and then by date for better presentation
            return forecasts.OrderBy(f => f.Location).ThenBy(f => f.Date);
        }
    }
}