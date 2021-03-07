using System;
using System.Threading.Tasks;

using BlazorServerApp.Data;

using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages
{
    public partial class FetchDataBehind : ComponentBase
    {
        [Inject]
        protected WeatherForecastService Service { get; set; }

        protected WeatherForecast[] Forecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.Forecasts = await this.Service.GetForecastAsync(DateTime.Now).ConfigureAwait(false);
        }
    }
}
