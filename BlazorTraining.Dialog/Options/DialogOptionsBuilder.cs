using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Options;

/// <summary>
/// Fluent builder for dialog options.
/// </summary>
public sealed class DialogOptionsBuilder
{
    private readonly DialogOptions _options = new();

    public DialogOptionsBuilder Title(string title)
    {
        _options.Title = title;
        return this;
    }

    public DialogOptionsBuilder Size(DialogSize size)
    {
        _options.Size = size;
        return this;
    }

    public DialogOptionsBuilder Position(DialogPosition position)
    {
        _options.Position = position;
        return this;
    }

    public DialogOptionsBuilder DisableBackdropClose()
    {
        _options.CloseOnBackdropClick = false;
        return this;
    }

    public DialogOptionsBuilder DisableEscape()
    {
        _options.CloseOnEscape = false;
        return this;
    }

    public DialogOptionsBuilder Scrollable()
    {
        _options.Scrollable = true;
        return this;
    }

    public DialogOptionsBuilder Fullscreen()
    {
        _options.Size = DialogSize.Fullscreen;
        return this;
    }

    public DialogOptionsBuilder Button(DialogButton button)
    {
        _options.Buttons.Add(button);
        return this;
    }

    internal DialogOptions Build()
        => _options;
}