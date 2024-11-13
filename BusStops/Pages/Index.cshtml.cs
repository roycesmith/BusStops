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

    public async Task OnGetAsync()
    {
        getDataAsync();
    }
    public async Task getDataAsync(){
        
        // var allRecords = _context.Shelter.ToList();
        // _context.Shelter.RemoveRange(allRecords);

        // check of data exists in the table before deleting it
        if (_context.Shelter.Any()){
            shelters = _context.Shelter.ToList();
        }else
        {
            // _context.Database.ExecuteSqlRaw("DELETE FROM Shelter");
            // seeding the database with data from the csv file
            Loader loader = new();
            shelters = loader.LoadFile();
            foreach (var item in shelters)
            {
                _context.Shelter.Add(item);
            }
            await _context.SaveChangesAsync();
        }
       
    }
}