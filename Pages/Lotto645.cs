using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lottery.Pages;
public class Lotto645Model : PageModel
{

    public List<int> RandomNums {get; set;}
    private readonly ILogger<IndexModel> _logger;
    public Lotto645Model(ILogger<IndexModel> logger)
    {
        _logger = logger;
        RandomNums = new List<int>();
    }
    public void OnGet()
    {
        
        RandomNums = RandomNumberGenerator.GenerateRandomNum(6,45);
        
    }
}
