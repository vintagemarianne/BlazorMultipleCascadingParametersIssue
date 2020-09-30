using BlazorMultipleCascadingParametersIssue.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Pages
{
    public partial class FirstPage
    {
        [CascadingParameter]
        public HeaderTitle HeaderTitle { get; set; }

        [CascadingParameter]
        public HeaderSubtitle HeaderSubtitle { get; set; }
        protected override void OnInitialized()
        {
            HeaderTitle.Title = "Title1";
            HeaderSubtitle.Subtitle = "Subtitle1";

            base.OnInitialized();
        }
    }
}
