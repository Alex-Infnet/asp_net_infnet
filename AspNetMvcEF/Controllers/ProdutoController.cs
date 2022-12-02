using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetMvcEF.Controllers
{
    public class ProdutoResponse
    {
        public string? Nome { get; set; }
        public string? Identificador { get; set; }
        public int Count { get; set; }
    }
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
            //Apresente a lista de produtos + nome do fornecedor
            //Apresente a lista de fornecedores e quantidade de produtos fornecidos
            //Crie um fornecedor
            //Atualize o fornecedor de um produto
            //Tente remover um fornecedor que possui produtos associados
            
            return Ok(GetAllProdutosOrderByPrecoVenda());
        }
        private List<Produto> GetAllProdutos()
        {
            return db.produtos.Include("Fornecedor").ToList();
        }
        private List<Produto> GetAllProdutosOrderByPrecoVenda()
        {
            return db.produtos.Include("Fornecedor").OrderByDescending(p => p.PrecoVenda).ToList();
        }
        private List<Fornecedor> GetAllFornecedores()
        {
            return db.Fornecedor.ToList();
        }
        private List<ProdutoResponse> GetAllFornecedoresWithProductCount()
        {
            return db.produtos
                .Include("Fornecedor")
                .Select(f => new
                {
                    Nome = f.Fornecedor != null ? f.Fornecedor.Nome : "",
                    Identificator = f.Fornecedor != null ? f.Fornecedor.Identificator : "",
                    Id = f.Id
                })
                .GroupBy(f => new {f.Nome, f.Identificator})
                .Select(g => new ProdutoResponse(){
                    Nome = g.Key.Nome,
                    Identificador = g.Key.Identificator,
                    Count = g.Count()
                })
                .ToList();
        }
        private void CreateFornecedor()
        {
            var forn = new Fornecedor()
            {
                Identificator = "00.234.567/0001-00",
                Nome = "Fornecedor principale"
            };
            db.Fornecedor.Add(forn);
            db.SaveChanges();
        }
        private void UpdateFornecedorOfProduto()
        {
            var produto = db.produtos.Where(p => p.Id == 4).First();
            produto.Fornecedor = db.Fornecedor.Where(f => f.Id == 2).First();

            db.SaveChanges();
        }
        private void DeleteFornecedor()
        {
            var fornecedor = db.Fornecedor.Where(f => f.Id == 2).First();
            db.Fornecedor.Remove(fornecedor);
            db.SaveChanges();
        }
    }
}

