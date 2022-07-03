using BlazorMVVMExample_1.Shared;
using System.Net.Http.Json;

namespace BlazorMVVMExample_1.Client.Models
{
    /// <summary>
    /// Represents the abstract aspects of the business model.
    /// </summary>
    public class WeatherForecastsModel : IWeatherForecastsModel
    {
        private HttpClient httpClient;

        public WeatherForecastsModel(HttpClient HttpClient)
        {
            httpClient = HttpClient;
        }

        public async Task<WeatherForecast[]> FetchWeatherDataAsync()
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}
