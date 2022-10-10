using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteServidor.Pages;

public class IndexModel : PageModel
{
    public string? Method { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Method = this.HttpContext.Request.Method;
        Console.WriteLine(this.HttpContext.Request.Method);
        Console.WriteLine(this.HttpContext.Request.Path.ToString());
    }
}

