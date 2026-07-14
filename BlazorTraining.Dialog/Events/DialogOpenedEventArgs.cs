using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Events;

/// <summary>
/// Raised after a dialog is rendered.
/// </summary>
public sealed class DialogOpenedEventArgs : EventArgs
{
    public DialogOpenedEventArgs(DialogReference dialog)
    {
        Dialog = dialog;
    }

    /// <summary>
    /// Gets the dialog.
    /// </summary>
    public DialogReference Dialog { get; }
}