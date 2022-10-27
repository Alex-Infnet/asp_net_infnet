using AspNetRazor.Data;
using AspNetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRazor.Pages.Reports
{
    public class FaturamentoDoMesModel : PageModel
    {
        private DAReceita dAReceita { get; set; }

        // Attributes on the rendering
        public List<Receita> receitas { get; set; }

        public FaturamentoDoMesModel(DAReceita _dAReceita)
        {
            dAReceita = _dAReceita;

            receitas = new List<Receita>();
        }
        public void OnGet()
        {
            receitas = dAReceita.receitas;
        }

        public double TotalRecebido()
        {
            return receitas.Select(r => r.Valor).ToList().Sum();
        }

        public double TotalFaturado()
        {
            return receitas.Where(
                r => r.DataFaturamento.Month == DateTime.Today.Month
                ).Select(r => r.Valor).ToList().Sum();
        }
    }
}
