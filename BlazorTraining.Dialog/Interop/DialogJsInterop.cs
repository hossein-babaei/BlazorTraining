using Microsoft.JSInterop;

namespace BlazorTraining.Dialog.Interop;

internal sealed class DialogJsInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _module;

    public DialogJsInterop(IJSRuntime jsRuntime)
    {
        _module = new(() =>
            jsRuntime.InvokeAsync<IJSObjectReference>(
                "import",
                "./_content/BlazorTraining.Dialog/js/dialog.js")
            .AsTask());
    }

    public async ValueTask FocusAsync(string elementId)
    {
        var module = await _module.Value;

        await module.InvokeVoidAsync(
            "focus",
            elementId);
    }

    public async ValueTask DisposeAsync()
    {
        if (!_module.IsValueCreated)
            return;

        var module = await _module.Value;

        await module.DisposeAsync();
    }
}