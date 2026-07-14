using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Rendering;

internal sealed class DialogRenderer : IDialogRenderer
{
    private readonly List<DialogReference> _dialogs = [];

    public IReadOnlyList<DialogReference> Dialogs => _dialogs;

    public void Add(DialogReference dialog)
    {
        ArgumentNullException.ThrowIfNull(dialog);

        _dialogs.Add(dialog);
    }

    public void Remove(DialogReference dialog)
    {
        ArgumentNullException.ThrowIfNull(dialog);

        _dialogs.Remove(dialog);
    }
}