using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorServerApp.Components
{
    public partial class CounterComponent : ComponentBase
    {
        [Parameter]
        public int StartingCount { get; set; } = 0;

        [Parameter]
        public EventCallback<int> OnClick { get; set; }

        protected async Task OnButtonClicked(MouseEventArgs ev)
        {
            this.StartingCount++;

            await OnClick.InvokeAsync(this.StartingCount).ConfigureAwait(false);
        }
    }
}
