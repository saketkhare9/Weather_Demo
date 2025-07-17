using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using WeatherApp.Web.Data;

namespace WeatherApp.Web.Pages;
public partial class FetchData1
{
    [Inject]
    private HttpClient Http { get; set; } = null!;

    // private bool dense = false;
    // private bool hover = true;
    // private bool striped = false;
    //private bool bordered = false;
    private string searchString1 = "";
    private WeatherForecast selectedItem1 = null!;
    //private HashSet<WeatherForecast> selectedItems = new();

    private List<WeatherForecast>? WeatherForecasts = new();

    protected override async Task OnInitializedAsync()
    {
        WeatherForecasts = await Http.GetFromJsonAsync<List<WeatherForecast>>("/WeatherForecast");
    }

    private bool FilterFunc1(WeatherForecast WeatherForecast) =>
    FilterFunc(WeatherForecast, searchString1);

    private static bool FilterFunc(WeatherForecast? weatherForecast, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;

        else if (weatherForecast!.Summary!.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        /*if (WeatherForecast.Name.Contains(searchString,
        StringComparison.OrdinalIgnoreCase))
        return true;
        if ($"{WeatherForecast.Number} {WeatherForecast.Position}
        {WeatherForecast.Molar}".Contains(searchString))
        return true;*/
        return false;
    }
}
