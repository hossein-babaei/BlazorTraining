using BlazorTraining.Dialog.Models;

namespace BlazorTraining.Dialog.Abstractions;

/// <summary>
/// Responsible for rendering dialogs.
/// </summary>
internal interface IDialogRenderer
{
    IReadOnlyList<DialogReference> Dialogs { get; }

    void Add(DialogReference dialog);

    void Remove(DialogReference dialog);
}