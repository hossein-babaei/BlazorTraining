using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Events;

/// <summary>
/// Event arguments raised after a dialog has closed.
/// </summary>
public sealed class DialogClosedEventArgs : EventArgs
{
    public DialogClosedEventArgs(DialogReference dialog, DialogResult result)
    {
        Dialog = dialog;
        Result = result;
    }

    /// <summary>
    /// Gets the dialog.
    /// </summary>
    public DialogReference Dialog { get; }

    /// <summary>
    /// Gets the dialog result.
    /// </summary>
    public DialogResult Result { get; }
}