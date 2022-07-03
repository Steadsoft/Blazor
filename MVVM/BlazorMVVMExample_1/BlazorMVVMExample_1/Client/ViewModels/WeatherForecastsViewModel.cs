using BlazorMVVMExample_1.Client.Models;
using BlazorMVVMExample_1.Shared;

namespace BlazorMVVMExample_1.Client.ViewModels
{
    /// <summary>
    /// Represents the abstract aspects of the user interface for the view.
    /// </summary>
    public class WeatherForecastsViewModel : IWeatherForecastsViewModel
    {
        private WeatherForecast[] _weatherForecasts;
        public WeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            set => _weatherForecasts = value;
        }
        private IWeatherForecastsModel model;
        public WeatherForecastsViewModel (IWeatherForecastsModel Model)
        {
            model = Model;
        }

        public async Task GetModelDataAsync()
        {
            _weatherForecasts = await model.FetchWeatherDataAsync();
        }
    }
}
