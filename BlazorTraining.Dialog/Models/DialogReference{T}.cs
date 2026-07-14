using BlazorTraining.Dialog.Abstractions;

namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Strongly typed dialog reference.
/// </summary>
public sealed class DialogReference<TResult>
    : IDialogReference<TResult>
{
    private readonly DialogReference _inner;

    internal DialogReference(DialogReference inner)
    {
        _inner = inner;
    }

    public Guid Id => _inner.Id;

    public bool IsActive => _inner.IsActive;

    Task<DialogResult<TResult>> IDialogReference<TResult>.Result
    => GetResultAsync();

    private async Task<DialogResult<TResult>> GetResultAsync()
    {
        var result = await _inner.Result;

        return new DialogResult<TResult>
        {
            Cancelled = result.Cancelled,
            Data = result.Data is TResult value
                ? value
                : default
        };
    }

    Task<DialogResult> IDialogReference.Result
        => _inner.Result;

    public Task CloseAsync()
        => _inner.CloseAsync();

    public Task CloseAsync(DialogResult? result)
        => _inner.CloseAsync(result);

    public Task CloseAsync(object? data)
        => _inner.CloseAsync(data);

    public Task CloseAsync(TResult? result)
        => _inner.CloseAsync(result);

    public Task CancelAsync()
        => _inner.CancelAsync();
}