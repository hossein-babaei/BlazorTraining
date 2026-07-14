using BlazorTraining.Dialog.Abstractions;

namespace BlazorTraining.Dialog.Abstractions;

/// <summary>
/// Implemented by components rendered inside a dialog.
/// </summary>
public interface IDialogContentComponent
{
    /// <summary>
    /// Gets or sets the owning dialog.
    /// </summary>
    IDialogReference Dialog { get; set; }
}