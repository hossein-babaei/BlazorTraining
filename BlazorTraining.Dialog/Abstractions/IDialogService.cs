using BlazorTraining.Dialog.Events;
using BlazorTraining.Dialog.Models;
using BlazorTraining.Dialog.Options;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Dialog.Abstractions;

public interface IDialogService
{
    event Action? Changed;

    event EventHandler<DialogClosingEventArgs>? Closing;

    event EventHandler<DialogClosedEventArgs>? Closed;

    IReadOnlyList<IDialogReference> Dialogs { get; }

    Task<IDialogReference> ShowAsync<TComponent>(
        Action<DialogParameters>? parameters = null,
        Action<DialogOptions>? options = null)
        where TComponent : IComponent;

    Task<IDialogReference> ShowAsync<TComponent, TResult>(
        Action<DialogParameters>? parameters = null,
        Action<DialogOptions>? options = null)
        where TComponent : IComponent;
}