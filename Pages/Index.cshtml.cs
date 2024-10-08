using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_zev.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _config;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    public void OnGet()
    {
        ViewData["Greeting"] = _config["Greeting"];
    }
}
