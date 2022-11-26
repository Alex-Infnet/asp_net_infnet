using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcEF.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetMvcEF.Controllers
{
    public class ProdutoController : Controller
    {
        public readonly ModelContext db;
        public ProdutoController(ModelContext modelContext)
        {
            db = modelContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            // lista de produtos
            // detalhes de um produto especifico
            // lista de produtos preco venda > 10
            // criar um produto
            // atualizar preco do produto
            // remove um produto

            return Ok(GetAllProdutos());
        }
        private List<Produto> GetAllProdutosPrecoMaior10()
        {
            return db.produtos.Where(p => p.PrecoVenda > 10).ToList();
        }
        private List<Produto> GetAllProdutos()
        {
            return db.produtos.ToList();
        }
        private Produto BuscarProduto(int Id)
        {
            return db.produtos.Where(p => p.Id == Id).First();
        }
    }
}

