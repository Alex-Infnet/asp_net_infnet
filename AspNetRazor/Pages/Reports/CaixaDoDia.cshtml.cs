using AspNetRazor.Data;
using AspNetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRazor.Pages.Reports
{
    public class CaixaDoDiaModel : PageModel
    {
        private DAReceita dAReceita { get; set; }

        // Attributes on the rendering
        public List<Receita> receitas { get; set; }

        public CaixaDoDiaModel(DAReceita _dAReceita)
        {
            dAReceita = _dAReceita;

            receitas = new List<Receita>();
        }
        public void OnGet()
        {
            receitas = dAReceita.receitas;
        }
    }
}
