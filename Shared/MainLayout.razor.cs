namespace BlazorMultipleCascadingParametersIssue.Shared
{
    public class HeaderInfo
    {
        public string Title { get; set; }
    }

    public class PageInfo
    {
        public string Content { get; set; }
    }
    public partial class MainLayout
    {
        public HeaderInfo HeaderInfo { get; set; } = new HeaderInfo { Title = "" };
        public PageInfo PageInfo { get; set; } = new PageInfo { Content = "" };
    }
}
