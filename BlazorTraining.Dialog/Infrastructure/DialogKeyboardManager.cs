using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Infrastructure;

/// <summary>
/// Manages keyboard interaction for dialogs.
/// </summary>
internal sealed class DialogKeyboardManager
{
    public Task HandleEscapeAsync(DialogReference? dialog)
    {
        if (dialog is null)
            return Task.CompletedTask;

        if (!dialog.Options.CloseOnEscape)
            return Task.CompletedTask;

        return dialog.CancelAsync();
    }
}