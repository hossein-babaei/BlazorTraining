namespace BlazorTraining.Dialog.Models;

/// <summary>
/// Represents a strongly typed dialog result.
/// </summary>
/// <typeparam name="T">Result type.</typeparam>
public sealed record DialogResult<T>
{
    /// <summary>
    /// Gets the returned value.
    /// </summary>
    public T? Data { get; init; }

    /// <summary>
    /// Gets whether the dialog was cancelled.
    /// </summary>
    public bool Cancelled { get; init; }

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    public static DialogResult<T> Ok(T? data)
        => new()
        {
            Data = data
        };

    /// <summary>
    /// Creates a cancelled result.
    /// </summary>
    public static DialogResult<T> Cancel()
        => new()
        {
            Cancelled = true
        };
}