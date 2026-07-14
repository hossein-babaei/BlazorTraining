using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Dialog.Abstractions;

/// <summary>
/// Provides a strongly typed dialog parameter builder.
/// </summary>
public interface IDialogParametersBuilder
{
    IDialogParametersBuilder Add<TComponent, TValue>(
        Func<TComponent, TValue> property,
        TValue value)
        where TComponent : IComponent;

    IReadOnlyDictionary<string, object?> Build();
}