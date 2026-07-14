using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Events;

/// <summary>
/// Event arguments raised before a dialog closes.
/// </summary>
public sealed class DialogClosingEventArgs : EventArgs
{
    public DialogClosingEventArgs(DialogReference dialog, DialogResult result)
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

    /// <summary>
    /// Gets or sets whether closing should be cancelled.
    /// </summary>
    public bool Cancel { get; set; }
}