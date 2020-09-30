using BlazorMultipleCascadingParametersIssue.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Pages
{
    public partial class SecondPage
    {
        [CascadingParameter]
        public HeaderTitle HeaderTitle { get; set; }

        [CascadingParameter]
        public HeaderSubtitle HeaderSubtitle { get; set; }
        protected override void OnInitialized()
        {
            HeaderTitle.Title = "Title2";
            HeaderSubtitle.Subtitle = "Subtitle2";

            base.OnInitialized();
        }
    }
}
