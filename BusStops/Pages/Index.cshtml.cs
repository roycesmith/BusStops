using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using BusStops.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using BusStops.Data;
namespace BusStops.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    public IndexModel(ILogger<IndexModel> logger, BusStops.Data.BusStopsContext context)
    {
        _logger = logger;
        _context = context;
    }

    private readonly BusStops.Data.BusStopsContext _context;




    public IList<Shelter> shelters = [];
    public async Task OnGet()
    {
        await getData();
    }
    public async Task getData(){
        Loader loader = new();
        shelters = loader.LoadFile();
        // var allRecords = _context.Shelter.ToList();
        // _context.Shelter.RemoveRange(allRecords);

        _context.Database.ExecuteSqlRaw("""DELETE FROM Shelter""");

        foreach (var item in shelters)
        {

            _context.Shelter.Add(item);

            Console.WriteLine("-----------------");
        }
        await _context.SaveChangesAsync();
    }
}