using BlazorBootstrapHelpers.PromptModal;
using BlazorBootstrapHelpers.Toast;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBootstrapHelpers
{
    public static class BlazorBootstrapHelpersExtensions
    {
        public static IApplicationBuilder UseBlazorBootstrapHelpers(this IApplicationBuilder app)
        {
            // This ensures static files from wwwroot are served
            app.UseStaticFiles();
            return app;
        }

        public static IServiceCollection AddBlazorBootstrapHelpers(this IServiceCollection services)
        {
            // Add any services needed by the library
            services.AddScoped<PromptModalService>();
            services.AddScoped<ToastService>();
            return services;
        }
    }
}