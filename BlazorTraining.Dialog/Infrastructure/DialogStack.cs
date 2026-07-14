using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Infrastructure;

/// <summary>
/// Maintains dialog ordering.
/// </summary>
internal sealed class DialogStack
{
    private readonly List<DialogReference> _dialogs = [];

    public IReadOnlyList<DialogReference> Dialogs => _dialogs;

    public int Count => _dialogs.Count;

    public DialogReference? Top =>
        _dialogs.Count == 0 ? null : _dialogs[^1];

    public void Push(DialogReference dialog)
    {
        ArgumentNullException.ThrowIfNull(dialog);

        _dialogs.Add(dialog);

        UpdateIndexes();
    }

    public bool Remove(DialogReference dialog)
    {
        ArgumentNullException.ThrowIfNull(dialog);

        var removed = _dialogs.Remove(dialog);

        if (removed)
        {
            UpdateIndexes();
        }

        return removed;
    }

    private void UpdateIndexes()
    {
        for (var i = 0; i < _dialogs.Count; i++)
        {
            _dialogs[i].StackIndex = i;
        }
    }
}