using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Shared
{
    public partial class Header
    {
        [CascadingParameter]
        public HeaderInfo HeaderInfo { get; set; }
    }
}
