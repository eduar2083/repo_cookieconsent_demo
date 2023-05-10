namespace CookieConsent.Test.Configurations;

public static class ServicesConfiguration
{
    public static WebApplication ConfigureWebAppServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddHttpContextAccessor();

        // Add services to the container.
        builder.Services.AddRazorPages();

        builder.Services.AddAntiforgery();

        builder.ConfigureCookiePolicies();

        return builder.Build();
    }
}