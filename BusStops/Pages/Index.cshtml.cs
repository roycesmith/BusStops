using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using BusStops.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace BusStops.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public IList<Shelter> shelters = [];
    public void OnGet()
    {
        Loader loader = new();
        shelters = loader.LoadFile();
    }
}