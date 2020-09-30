using BlazorMultipleCascadingParametersIssue.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Pages
{
    public partial class SecondPage
    {
        [CascadingParameter]
        public HeaderInfo HeaderInfo { get; set; }

        [CascadingParameter]
        public PageInfo PageInfo { get; set; }
        protected override void OnInitialized()
        {
            HeaderInfo.Title = "Second Page";
            PageInfo.Content = "This is second page";

            base.OnInitialized();
        }
    }
}
