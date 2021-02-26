using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Routing;

namespace Microsoft.AspNetCore.Components.WebView
{
    internal class WebViewNavigationInterception : INavigationInterception
    {
        public Task EnableNavigationInterceptionAsync()
        {
            // NO:OP
            return Task.CompletedTask;
        }
    }
}