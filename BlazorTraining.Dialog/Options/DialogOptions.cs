using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Options;

/// <summary>
/// Dialog configuration.
/// </summary>
public sealed class DialogOptions
{
    public string? Title { get; set; }

    public DialogSize Size { get; set; } = DialogSize.Medium;

    public DialogPosition Position { get; set; } =
        DialogPosition.Center;

    public bool CloseOnBackdropClick { get; set; } = true;

    public bool CloseOnEscape { get; set; } = true;

    public bool Scrollable { get; set; }

    public bool VerticallyCentered { get; set; } = true;

    public bool ShowCloseButton { get; set; } = true;

    public bool PreventScroll { get; set; } = true;

    public bool DisableAnimation { get; set; }

    public IList<DialogButton> Buttons { get; } =
        new List<DialogButton>();

    public DialogOptions AddButton(DialogButton button)
    {
        ArgumentNullException.ThrowIfNull(button);

        Buttons.Add(button);

        return this;
    }
}