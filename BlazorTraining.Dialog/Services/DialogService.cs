using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Events;
using BlazorTraining.Dialog.Infrastructure;
using BlazorTraining.Dialog.Models;
using BlazorTraining.Dialog.Options;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Dialog.Services;

internal sealed class DialogService : IDialogService
{
    private readonly DialogStack _stack = new();
    private readonly IDialogRenderer _renderer;

    public DialogService(IDialogRenderer renderer)
    {
        _renderer = renderer;
    }

    public event Action? Changed;

    public event EventHandler<DialogClosingEventArgs>? Closing;

    public event EventHandler<DialogClosedEventArgs>? Closed;

    public IReadOnlyList<IDialogReference> Dialogs => _stack.Dialogs;

    public Task<IDialogReference> ShowAsync<TComponent>(
        Action<DialogParameters>? parameters = null,
        Action<DialogOptions>? options = null)
        where TComponent : IComponent
        => ShowAsync<TComponent, object>(parameters, options);

    public Task<IDialogReference> ShowAsync<TComponent, TResult>(
        Action<DialogParameters>? parameters = null,
        Action<DialogOptions>? options = null)
        where TComponent : IComponent
    {
        var dialogParameters = new DialogParameters();
        parameters?.Invoke(dialogParameters);

        var dialogOptions = new DialogOptions();
        options?.Invoke(dialogOptions);

        var dialog = new DialogReference(
            typeof(TComponent),
            dialogParameters,
            dialogOptions,
            CloseInternalAsync);

        _stack.Push(dialog);

        _renderer.Add(dialog);

        UpdateActive();

        Changed?.Invoke();

        return Task.FromResult<IDialogReference>(dialog);
    }

    private Task CloseInternalAsync(DialogReference dialog, DialogResult result)
    {
        var args = new DialogClosingEventArgs(dialog, result);

        Closing?.Invoke(this, args);

        if (args.Cancel)
            return Task.CompletedTask;

        dialog.Complete(result);

        _renderer.Remove(dialog);

        _stack.Remove(dialog);

        UpdateActive();

        Closed?.Invoke(this, new DialogClosedEventArgs(dialog, result));

        Changed?.Invoke();

        return Task.CompletedTask;
    }

    private void UpdateActive()
    {
        foreach (var dialog in _stack.Dialogs)
            dialog.IsActive = false;

        if (_stack.Top is not null)
            _stack.Top.IsActive = true;
    }
}