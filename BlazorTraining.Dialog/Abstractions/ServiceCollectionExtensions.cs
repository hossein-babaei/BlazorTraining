using BlazorTraining.Dialog.Abstractions;
using BlazorTraining.Dialog.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTraining.Dialog.Extensions;

/// <summary>
/// Registers BlazorTraining.Dialog services.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers the dialog framework.
    /// </summary>
    /// <param name="services">Application services.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection AddBlazorTrainingDialog(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddScoped<IDialogService, DialogService>();

        return services;
    }
}