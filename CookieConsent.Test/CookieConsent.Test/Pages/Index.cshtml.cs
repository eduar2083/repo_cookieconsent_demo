namespace CookieConsent.Test.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> Logger;
    private readonly IHttpContextAccessor HttpContextAccessor;

    public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor httpContextAccessor)
    {
        Logger = logger;
        HttpContextAccessor = httpContextAccessor;
    }

    public void OnGet()
    {

    }

    public void OnPostSetConsent()
    {
        Logger.LogInformation("Se inicia consentimiento de cookies");

        var consentFeature = HttpContextAccessor.HttpContext.Features.Get<ITrackingConsentFeature>();
        if (consentFeature != null)
        {
            consentFeature.GrantConsent();

            Logger.LogInformation("Se concede consentimiento de cookies");
        }
    }
}
