using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Dialog.Models;

public sealed class DialogParameters
{
    private readonly Dictionary<string, object?> _parameters =
        new(StringComparer.Ordinal);

    public IReadOnlyDictionary<string, object?> Values =>
        new ReadOnlyDictionary<string, object?>(_parameters);

    public DialogParameters Add<TComponent, TValue>(
        Expression<Func<TComponent, TValue>> property,
        TValue value)
        where TComponent : IComponent
    {
        ArgumentNullException.ThrowIfNull(property);

        if (property.Body is not MemberExpression member)
            throw new ArgumentException(nameof(property));

        _parameters[member.Member.Name] = value;

        return this;
    }

    public DialogParameters Add(
        string name,
        object? value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        _parameters[name] = value;

        return this;
    }

    internal IDictionary<string, object?> ToDictionary()
        => new Dictionary<string, object?>(_parameters);
}