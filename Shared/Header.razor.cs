using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Shared
{
    public partial class Header
    {
        [CascadingParameter]
        public HeaderTitle HeaderTitle { get; set; }

        [CascadingParameter]
        public HeaderSubtitle HeaderSubtitle { get; set; }
    }
}
