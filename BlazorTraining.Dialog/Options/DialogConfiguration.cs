namespace BlazorTraining.Dialog.Options;

/// <summary>
/// Global dialog configuration.
/// </summary>
public sealed class DialogConfiguration
{
    /// <summary>
    /// Gets or sets the default dialog options.
    /// </summary>
    public DialogOptions DefaultOptions { get; } = new();

    /// <summary>
    /// Gets or sets the default z-index.
    /// </summary>
    public int BaseZIndex { get; set; } = 1055;

    /// <summary>
    /// Gets or sets whether multiple dialogs are allowed.
    /// </summary>
    public bool AllowMultipleDialogs { get; set; } = true;

    /// <summary>
    /// Gets or sets whether body scrolling is disabled while dialogs are open.
    /// </summary>
    public bool LockBodyScroll { get; set; } = true;
}