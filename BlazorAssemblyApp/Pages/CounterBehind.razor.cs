using Microsoft.AspNetCore.Components;

namespace BlazorAssemblyApp.Pages
{
    public partial class CounterBehind : ComponentBase
    {
        protected int CurrentCount { get; set; } = 0;

        protected void IncrementCount(int count)
        {
            this.CurrentCount += count;
        }
    }
}
