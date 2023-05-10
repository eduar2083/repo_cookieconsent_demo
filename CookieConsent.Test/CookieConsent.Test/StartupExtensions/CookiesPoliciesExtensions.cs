namespace CookieConsent.Test.StartupExtensions;

public static class CookiesPoliciesExtensions
{
    public static WebApplicationBuilder ConfigureCookiePolicies(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<CookiePolicyOptions>(options =>
        {
            options.CheckConsentNeeded = context => true;
            options.HttpOnly = HttpOnlyPolicy.None;
            options.MinimumSameSitePolicy = SameSiteMode.None;
            options.Secure = CookieSecurePolicy.Always;
        });

        return builder;
    }
}