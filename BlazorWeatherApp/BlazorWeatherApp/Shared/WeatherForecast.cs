namespace BlazorWeatherApp.Shared;

// Represents a weather forecast for a specific date and location.
public class WeatherForecast
{
    // The date of the weather forecast.
    public DateTime Date { get; set; }

    // The temperature in Celsius.
    public int TemperatureC { get; set; }

    // A short summary of the weather (e.g., "Freezing", "Sweltering").
    public string? Summary { get; set; } // e.g., "Freezing", "Sweltering"

    // The location for which the forecast applies (e.g., "Pune", "Bengaluru").
    public string? Location { get; set; } // e.g., "Pune", "Bengaluru"

    // The temperature in Fahrenheit, calculated from Celsius.
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    // Indicates if the weather condition is considered harsh (e.g., "Freezing", "Bracing", "Sweltering", "Scorching").
    public bool IsHarshCondition => Summary == "Freezing" || Summary == "Bracing" || Summary == "Sweltering" || Summary == "Scorching";

    // Indicates if the weather condition is considered dangerous (e.g., "Freezing", "Scorching").
    public bool IsDangerousCondition => Summary == "Freezing" || Summary == "Scorching";

    // Tracks if a dangerous or harsh condition has been acknowledged by the user (for personalization).
    public bool IsAcknowledged { get; set; } = false;
}

