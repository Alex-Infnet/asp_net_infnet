using System;
using AspNetRazor.Models;

namespace AspNetRazor.Data
{
    public class DAReceita
    {
        public List<Receita> receitas { get; set; }
        public DAReceita()
        {
            receitas = new List<Receita>();
            receitas.Add(
                new Receita("Compra de Celulose", 10000, FormaPagamento.Credito, new DateOnly(2022, 10, 1))
                );
            receitas.Add(
                new Receita("Carbono", 2500000, FormaPagamento.Outros, new DateOnly(2022, 10, 28))
                );
        }
    }
}

