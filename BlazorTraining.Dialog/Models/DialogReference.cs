using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Options;

namespace BlazorTraining.Dialog.Models;

public sealed class DialogReference : IDialogReference
{
    private readonly TaskCompletionSource<DialogResult> _completion =
        new(TaskCreationOptions.RunContinuationsAsynchronously);

    private readonly Func<DialogReference, DialogResult, Task> _close;

    internal DialogReference(
        Type componentType,
        DialogParameters parameters,
        DialogOptions options,
        Func<DialogReference, DialogResult, Task> close)
    {
        Id = Guid.NewGuid();
        ComponentType = componentType;
        Parameters = parameters;
        Options = options;
        _close = close;
        Instance = new DialogInstance(this);
    }

    public Guid Id { get; }

    public int StackIndex { get; internal set; }

    public bool IsActive { get; internal set; }

    public Type ComponentType { get; }

    public DialogParameters Parameters { get; }

    public DialogOptions Options { get; }

    public DialogInstance Instance { get; }

    public Task<DialogResult> Result => _completion.Task;

    public Task CloseAsync(DialogResult? result = null)
        => _close(this, result ?? DialogResult.Ok());

    public Task CloseAsync(object? data)
        => CloseAsync(DialogResult.Ok(data));

    public Task CancelAsync()
        => CloseAsync(DialogResult.Cancel());

    internal void Complete(DialogResult result)
        => _completion.TrySetResult(result);
}