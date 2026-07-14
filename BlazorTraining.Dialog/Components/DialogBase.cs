using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Dialog.Components
{
    public abstract class DialogBase : ComponentBase, IDialogComponent
    {
        [Parameter]
        public required DialogReference Dialog { get; set; }

        protected IDialogContext Context => new DialogContext(Dialog);

        protected Task CloseAsync()
            => Dialog.CloseAsync();

        protected Task CloseAsync(object? value)
            => Dialog.CloseAsync(value);

        protected Task CancelAsync()
            => Dialog.CancelAsync();

        protected virtual Task OnDialogOpeningAsync()
            => Task.CompletedTask;

        protected virtual Task OnDialogOpenedAsync()
            => Task.CompletedTask;

        protected virtual Task OnDialogClosingAsync()
            => Task.CompletedTask;

        protected virtual Task OnDialogClosedAsync()
            => Task.CompletedTask;

        protected sealed override async Task OnInitializedAsync()
        {
            await OnDialogOpeningAsync();

            await base.OnInitializedAsync();
        }

        protected sealed override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await OnDialogOpenedAsync();
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
