using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinMarketNotifier.Models;

namespace SkinMarketNotifier.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly MyDbContext _context;

    [BindProperty]
    public User NewUser { get; set; }
    public IndexModel(ILogger<IndexModel> logger , MyDbContext context)
    {
        _logger = logger;
        _context = context;
        
    }
    public void OnGet()
    {
    }
    
    public IActionResult OnPost()
    {
        _context.User.Add(NewUser);
        _context.SaveChanges();
        return RedirectToPage();

    }
}