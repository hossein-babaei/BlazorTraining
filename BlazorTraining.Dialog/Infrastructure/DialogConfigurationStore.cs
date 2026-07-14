using BlazorTraining.Dialog.Options;

namespace BlazorTraining.Dialog.Infrastructure;

internal sealed class DialogConfigurationStore
{
    public DialogConfiguration Configuration { get; } = new();
}