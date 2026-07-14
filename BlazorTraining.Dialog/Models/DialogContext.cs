using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Options;

namespace BlazorTraining.Dialog.Models;

internal sealed class DialogContext : IDialogContext
{
    public DialogContext(DialogReference dialog)
    {
        Dialog = dialog;
    }

    public IDialogReference Dialog { get; }

    public DialogOptions Options =>
        ((DialogReference)Dialog).Options;
}