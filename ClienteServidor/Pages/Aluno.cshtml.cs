using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClienteServidor.Pages
{
    class Aluno
    {
        public string? Nome { get; set; }
    }

    public class AlunoModel : PageModel
    {
        public string? Method { get; set; }
        public string? Path { get; set; }
        public string? Body { get; set; }
        public string? Scheme { get; set; }
        public string? Host { get; set; }
        public IQueryCollection? Query { get; set; }
        public IHeaderDictionary? Headers { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public AlunoModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Method = this.HttpContext.Request.Method;
            Path = this.HttpContext.Request.Path.ToString();
            Scheme = this.HttpContext.Request.Scheme;
            Host = this.HttpContext.Request.Host.Host;
            Query = this.HttpContext.Request.Query;
        }

        public async void OnPost()
        {
            Method = this.HttpContext.Request.Method;
            Path = this.HttpContext.Request.Path.ToString();
            Scheme = this.HttpContext.Request.Scheme;
            Host = this.HttpContext.Request.Host.Host;
            using var reader = new StreamReader(this.HttpContext.Request.Body, Encoding.UTF8);
            Body = await reader.ReadToEndAsync();
            Headers = this.HttpContext.Request.Headers;
        }
    }
}

