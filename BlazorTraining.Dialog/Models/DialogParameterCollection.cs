using System.Collections.ObjectModel;

namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Immutable dialog parameter collection.
/// </summary>
public sealed class DialogParameterCollection
{
    private readonly IReadOnlyDictionary<string, object?> _values;

    internal DialogParameterCollection(
        IDictionary<string, object?> values)
    {
        _values = new ReadOnlyDictionary<string, object?>(
            new Dictionary<string, object?>(values));
    }

    /// <summary>
    /// Gets all parameters.
    /// </summary>
    public IReadOnlyDictionary<string, object?> Values => _values;

    /// <summary>
    /// Gets a value by name.
    /// </summary>
    public T? Get<T>(string name)
    {
        if (_values.TryGetValue(name, out var value))
            return (T?)value;

        return default;
    }

    /// <summary>
    /// Determines whether a parameter exists.
    /// </summary>
    public bool Contains(string name)
        => _values.ContainsKey(name);
}