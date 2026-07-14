using BlazorTraining.Dialog.Abstractions;

namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Represents a footer button.
/// </summary>
public sealed class DialogButton
{
    /// <summary>
    /// Button text.
    /// </summary>
    public required string Text { get; init; }

    /// <summary>
    /// Bootstrap style.
    /// </summary>
    public DialogButtonStyle Style { get; init; } =
        DialogButtonStyle.Primary;

    /// <summary>
    /// Callback executed when clicked.
    /// </summary>
    public Func<IDialogReference, Task>? Callback { get; init; }

    /// <summary>
    /// Whether the button closes the dialog automatically.
    /// </summary>
    public bool AutoClose { get; init; } = true;

    /// <summary>
    /// Whether the button is disabled.
    /// </summary>
    public bool Disabled { get; init; }
}