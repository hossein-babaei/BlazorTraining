namespace BlazorBootstrapHelpers.Toast
{
    public class ToastService
    {
        public event Action<ToastMessage>? OnShow;
        public event Action? OnClear;

        public void ShowSuccess(string message, string? title = null, bool autoHide = true, ToastPosition position = ToastPosition.BottomCenter)
        {
            Show(new ToastMessage
            {
                Type = ToastType.Success,
                Title = title ?? "Success",
                Message = message,
                AutoHide = autoHide,
                Icon = "bi-check-circle-fill",
                Position = position
            });
        }

        public void ShowError(string message, string? title = null, bool autoHide = true, ToastPosition position = ToastPosition.BottomCenter)
        {
            Show(new ToastMessage
            {
                Type = ToastType.Error,
                Title = title ?? "Error",
                Message = message,
                AutoHide = autoHide,
                Icon = "bi-x-circle-fill",
                Position = position
            });
        }

        public void ShowWarning(string message, string? title = null, bool autoHide = true, ToastPosition position = ToastPosition.BottomCenter)
        {
            Show(new ToastMessage
            {
                Type = ToastType.Warning,
                Title = title ?? "Warning",
                Message = message,
                AutoHide = autoHide,
                Icon = "bi-exclamation-triangle-fill",
                Position = position
            });
        }

        public void ShowInfo(string message, string? title = null, bool autoHide = true, ToastPosition position = ToastPosition.BottomCenter)
        {
            Show(new ToastMessage
            {
                Type = ToastType.Info,
                Title = title ?? "Information",
                Message = message,
                AutoHide = autoHide,
                Icon = "bi-info-circle-fill",
                Position = position
            });
        }

        public void Show(ToastMessage message)
        {
            OnShow?.Invoke(message);
        }

        public void Clear()
        {
            OnClear?.Invoke();
        }
    }

    public enum ToastType
    {
        Success,
        Error,
        Warning,
        Info
    }

    public enum ToastPosition
    {
        TopRight,
        TopLeft,
        BottomRight,
        BottomLeft,
        TopCenter,
        BottomCenter
    }
}
