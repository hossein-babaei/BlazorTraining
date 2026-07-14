using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Events;

/// <summary>
/// Raised before a dialog is added to the render tree.
/// </summary>
public sealed class DialogOpeningEventArgs : EventArgs
{
    public DialogOpeningEventArgs(DialogReference dialog)
    {
        Dialog = dialog;
    }

    /// <summary>
    /// Gets the dialog.
    /// </summary>
    public DialogReference Dialog { get; }

    /// <summary>
    /// Cancels opening.
    /// </summary>
    public bool Cancel { get; set; }
}