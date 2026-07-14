using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Infrastructure;
using BlazorTraining.Dialog.Options;
using BlazorTraining.Dialog.Rendering;
using BlazorTraining.Dialog.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTraining.Dialog.Extensions;

/// <summary>
/// Registers BlazorTraining.Dialog.
/// </summary>
public static class DependencyContainer
{
    public static IServiceCollection AddBlazorTrainingDialog(
        this IServiceCollection services,
        Action<DialogConfiguration>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddScoped<IDialogService, DialogService>();

        services.AddScoped<IDialogRenderer, DialogRenderer>();

        services.AddScoped<DialogKeyboardManager>();

        services.AddScoped<DialogFocusManager>();

        services.AddSingleton<DialogConfigurationStore>();

        if (configure is not null)
        {
            services.PostConfigure(configure);
        }

        return services;
    }

    private static IServiceCollection PostConfigure(
        this IServiceCollection services,
        Action<DialogConfiguration> configure)
    {
        using var provider = services.BuildServiceProvider();

        var store = provider.GetRequiredService<DialogConfigurationStore>();

        configure(store.Configuration);

        return services;
    }
}