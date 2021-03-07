using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using BlazorAssemblyApp.Data;

using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyApp.Pages
{
    public partial class FetchDataBehind : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        protected WeatherForecast[] Forecasts { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.Forecasts = await this.Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
