using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusStops.Pages;

public class MapsModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public MapsModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

