using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lottery.Pages;

public class Lotto739Model : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<int> RandomNums {get; set;}

    public Lotto739Model(ILogger<IndexModel> logger)
    {
        _logger = logger;
        RandomNums = new List<int>();
    }
    public void OnGet()
    {
        
        RandomNums = RandomNumberGenerator.GenerateRandomNum(7,39);
        
    }
}
