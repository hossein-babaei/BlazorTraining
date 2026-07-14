namespace BlazorTraining.Dialog.Infrastructure;

/// <summary>
/// Manages keyboard focus for dialogs.
/// </summary>
internal sealed class DialogFocusManager
{
    public ValueTask FocusFirstAsync()
        => ValueTask.CompletedTask;

    public ValueTask RestoreFocusAsync()
        => ValueTask.CompletedTask;

    public ValueTask TrapFocusAsync()
        => ValueTask.CompletedTask;
}