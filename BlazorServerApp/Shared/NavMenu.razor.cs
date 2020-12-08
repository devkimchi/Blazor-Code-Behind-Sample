using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Shared
{
    public partial class NavMenu : ComponentBase
    {
        private bool _collapseNavMenu;

        public NavMenu()
        {
            this._collapseNavMenu = true;
        }

        protected string NavMenuCssClass
        {
            get
            {
                return this._collapseNavMenu ? "collapse" : null;
            }
        }

        protected void ToggleNavMenu()
        {
            this._collapseNavMenu = !this._collapseNavMenu;
        }
    }
}
