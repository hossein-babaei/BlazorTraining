namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Represents a dialog component instance.
/// </summary>
public sealed class DialogInstance
{
    private readonly DialogReference _reference;

    internal DialogInstance(DialogReference reference)
    {
        _reference = reference;
    }

    /// <summary>
    /// Gets the dialog identifier.
    /// </summary>
    public Guid Id => _reference.Id;

    /// <summary>
    /// Closes the dialog.
    /// </summary>
    public Task CloseAsync()
        => _reference.CloseAsync();

    /// <summary>
    /// Closes the dialog with data.
    /// </summary>
    public Task CloseAsync(object? data)
        => _reference.CloseAsync(data);

    /// <summary>
    /// Cancels the dialog.
    /// </summary>
    public Task CancelAsync()
        => _reference.CancelAsync();
}