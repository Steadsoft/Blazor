using BlazorMVVMExample_1.Client.Models;

namespace BlazorMVVMExample_1.Client.ViewModels
{
    public class WeatherForecastsViewModel : IWeatherForecastsViewModel
    {
        private IWeatherForecastsModel model;
        public WeatherForecastsViewModel (IWeatherForecastsModel Model)
        {
            model = Model;
        }
    }
}
