namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Represents the reason a dialog was closed.
/// </summary>
public enum DialogCloseReason
{
    None,
    Programmatic,
    PrimaryButton,
    SecondaryButton,
    CloseButton,
    Backdrop,
    Escape,
    Cancel
}