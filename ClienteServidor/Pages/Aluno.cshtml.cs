using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteServidor.Pages;

class Aluno
{
    public string? Nome { get; set; }
}

public class AlunoModel : PageModel
{
    public string? Method { get; set; }
    public string? Path { get; set; }
    public string? Body { get; set; }


    private readonly ILogger<IndexModel> _logger;

    public AlunoModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Method = this.HttpContext.Request.Method;
        Path = this.HttpContext.Request.Path.ToString();
    }

    public async void OnPost()
    {
        Method = this.HttpContext.Request.Method;
        Path = this.HttpContext.Request.Path.ToString();
    }
}

