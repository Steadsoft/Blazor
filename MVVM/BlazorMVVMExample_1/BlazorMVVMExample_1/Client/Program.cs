using BlazorMVVMExample_1.Client.Models;
using BlazorMVVMExample_1.Client.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorMVVMExample_1.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Configure dependency injection

            builder.Services.AddTransient<IWeatherForecastsModel, WeatherForecastsModel>();
            builder.Services.AddTransient<IWeatherForecastsViewModel, WeatherForecastsViewModel>();

            await builder.Build().RunAsync();
        }
    }
}