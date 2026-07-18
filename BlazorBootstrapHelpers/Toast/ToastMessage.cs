namespace BlazorBootstrapHelpers.Toast
{
    public class ToastMessage
    {
        public ToastType Type { get; set; } = ToastType.Info;
        public ToastPosition Position { get; set; } = ToastPosition.BottomRight;
        public string Title { get; set; } = "";
        public string Message { get; set; } = "";
        public bool AutoHide { get; set; } = true;
        public int AutoHideDelay { get; set; } = 5000; // milliseconds
        public string? Icon { get; set; }
        public string? CssClass { get; set; }
    }
}
