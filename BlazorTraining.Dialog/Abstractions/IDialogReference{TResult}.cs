using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Abstractions;

/// <summary>
/// Represents a strongly typed dialog reference.
/// </summary>
/// <typeparam name="TResult">The dialog result type.</typeparam>
public interface IDialogReference<TResult> : IDialogReference
{
    /// <summary>
    /// Gets the strongly typed result.
    /// </summary>
    new Task<DialogResult<TResult>> Result { get; }

    /// <summary>
    /// Closes the dialog with a strongly typed value.
    /// </summary>
    Task CloseAsync(TResult? result);
}