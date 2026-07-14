using System.Linq.Expressions;
using BlazorTraining.Dialog.Abstractions;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Dialog.Models;

internal sealed class DialogParametersBuilder
    : IDialogParametersBuilder
{
    private readonly Dictionary<string, object?> _parameters =
        new(StringComparer.Ordinal);

    public IDialogParametersBuilder Add<TComponent, TValue>(
        Func<TComponent, TValue> property,
        TValue value)
        where TComponent : IComponent
    {
        ArgumentNullException.ThrowIfNull(property);

        if (property.Target is null)
            throw new InvalidOperationException(
                "Use expression-based overload.");

        return this;
    }

    public IDialogParametersBuilder Add<TComponent, TValue>(
        Expression<Func<TComponent, TValue>> expression,
        TValue value)
        where TComponent : IComponent
    {
        ArgumentNullException.ThrowIfNull(expression);

        if (expression.Body is not MemberExpression member)
            throw new ArgumentException(
                "Expression must reference a component property.",
                nameof(expression));

        _parameters[member.Member.Name] = value;

        return this;
    }

    public IReadOnlyDictionary<string, object?> Build()
        => new DialogParameterCollection(_parameters).Values;
}