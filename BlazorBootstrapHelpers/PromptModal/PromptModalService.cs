namespace BlazorBootstrapHelpers.PromptModal
{
    public class PromptModalService
    {
        public event Action<PromptModalConfig>? OnShow;
        public event Action? OnHide;

        public void Show(PromptModalConfig config)
        {
            OnShow?.Invoke(config);
        }

        public void Hide()
        {
            OnHide?.Invoke();
        }
    }

    public enum ModalType
    {
        Confirmation,
        Alert,
        Prompt
    }
}