namespace BlazorMultipleCascadingParametersIssue.Shared
{
    public class HeaderTitle
    {
        public string Title { get; set; }
    }

    public class HeaderSubtitle
    {
        public string Subtitle { get; set; }
    }
    public partial class MainLayout
    {
        public HeaderTitle HeaderTitle { get; set; } = new HeaderTitle { Title = "" };
        public HeaderSubtitle HeaderSubtitle { get; set; } = new HeaderSubtitle { Subtitle = "" };
    }
}
