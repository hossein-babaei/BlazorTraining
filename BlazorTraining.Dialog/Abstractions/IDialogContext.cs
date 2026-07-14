using BlazorTraining.Dialog.Models;
using BlazorTraining.Dialog.Options;

namespace BlazorTraining.Dialog.Abstractions;

/// <summary>
/// Provides information about the currently executing dialog.
/// </summary>
public interface IDialogContext
{
    /// <summary>
    /// Gets the dialog reference.
    /// </summary>
    IDialogReference Dialog { get; }

    /// <summary>
    /// Gets the dialog options.
    /// </summary>
    DialogOptions Options { get; }
}