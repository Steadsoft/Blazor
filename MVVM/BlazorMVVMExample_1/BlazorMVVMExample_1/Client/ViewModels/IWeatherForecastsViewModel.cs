using BlazorMVVMExample_1.Shared;

namespace BlazorMVVMExample_1.Client.ViewModels
{
    public interface IWeatherForecastsViewModel
    {
        WeatherForecast[] WeatherForecasts { get; }
        Task GetModelDataAsync();
    }
}
