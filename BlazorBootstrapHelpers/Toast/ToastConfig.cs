namespace BlazorBootstrapHelpers.Toast
{
    public class ToastConfig
    {
        public ToastType Type { get; set; } = ToastType.Info;
        public ToastPosition Position { get; set; } = ToastPosition.BottomRight;
        public string Title { get; set; } = "";
        public string Message { get; set; } = "";
        public bool AutoHide { get; set; } = true;
        public int AutoHideDelay { get; set; } = 5000; // milliseconds
        public string? Icon { get; set; }
        public string? CssClass { get; set; }
        // Whether to use CSS transition animation for show/hide (no JS required)
        public bool Animation { get; set; } = true;
        // Animation duration in milliseconds - used when removing the toast to wait for CSS transition to finish
        public int AnimationDuration { get; set; } = 300;
    }
}
