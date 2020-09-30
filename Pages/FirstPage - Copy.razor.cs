using Microsoft.AspNetCore.Components;

namespace BlazorMultipleCascadingParametersIssue.Shared
{
    public partial class FirstPage
    {
        [CascadingParameter]
        public HeaderInfo HeaderInfo { get; set; }
    }
}
