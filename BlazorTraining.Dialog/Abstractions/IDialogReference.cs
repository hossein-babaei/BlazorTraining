using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Abstractions;

/// <summary>
/// Represents an active dialog.
/// </summary>
public interface IDialogReference
{
    Guid Id { get; }

    bool IsActive { get; }

    Task<DialogResult> Result { get; }

    Task CloseAsync(DialogResult? result = null);

    Task CloseAsync(object? data);

    Task CancelAsync();
}