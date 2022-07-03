using BlazorMVVMExample_1.Shared;

namespace BlazorMVVMExample_1.Client.Models
{
    public interface IWeatherForecastsModel
    {
        Task<WeatherForecast[]> FetchWeatherDataAsync();
    }
}
