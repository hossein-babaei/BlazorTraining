namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Represents the result returned by a dialog.
/// </summary>
public sealed record DialogResult
{
    public object? Data { get; init; }

    public bool Cancelled { get; init; }

    public DialogCloseReason CloseReason { get; init; }

    public static DialogResult Ok(
        object? data = null,
        DialogCloseReason reason = DialogCloseReason.Programmatic)
        => new()
        {
            Data = data,
            CloseReason = reason
        };

    public static DialogResult Cancel(
        DialogCloseReason reason = DialogCloseReason.Cancel)
        => new()
        {
            Cancelled = true,
            CloseReason = reason
        };
}