using BlazorMultipleCascadingParametersIssue.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Pages
{
    public partial class FirstPage
    {
        [CascadingParameter]
        public HeaderInfo HeaderInfo { get; set; }

        [CascadingParameter]
        public PageInfo PageInfo { get; set; }
        protected override void OnInitialized()
        {
            HeaderInfo.Title = "First Page";
            PageInfo.Content = "This is first page";

            base.OnInitialized();
        }
    }
}
