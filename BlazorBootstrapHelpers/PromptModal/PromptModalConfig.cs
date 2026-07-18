namespace BlazorBootstrapHelpers.PromptModal
{
    public class PromptModalConfig
    {
        public string Title { get; set; } = "Confirmation";
        public string Message { get; set; } = "";
        public string ConfirmText { get; set; } = "Confirm";
        public string CancelText { get; set; } = "Cancel";
        public ModalType Type { get; set; } = ModalType.Confirmation;
        public string? PromptValue { get; set; }
        public string PromptPlaceholder { get; set; } = "Enter value...";
        public Func<Task>? OnConfirm { get; set; }
        public Func<string, Task>? OnPromptConfirm { get; set; }
        public Func<Task>? OnCancel { get; set; }
        public string ConfirmButtonClass { get; set; } = "btn-primary";
        public string CancelButtonClass { get; set; } = "btn-secondary";
    }
}
