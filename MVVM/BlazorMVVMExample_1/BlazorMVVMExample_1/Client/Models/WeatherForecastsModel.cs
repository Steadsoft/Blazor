namespace BlazorMVVMExample_1.Client.Models
{
    public class WeatherForecastsModel : IWeatherForecastsModel
    {
        private HttpClient httpClient;

        public WeatherForecastsModel(HttpClient HttpClient)
        {
            httpClient = HttpClient;
        }
    }
}
