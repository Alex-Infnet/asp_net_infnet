using System;
namespace AspNetRazor.Models
{
    public enum FormaPagamento : ushort {
        Credito = 1,
        Debito = 2,
        Outros = 3
    }

    public class Receita
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public DateOnly DataPagamento { get; set; }
        public DateOnly DataFaturamento
        {
            get
            {
                switch (FormaPagamento)
                {
                    case FormaPagamento.Credito:
                        return DataPagamento.AddDays(60);
                    case FormaPagamento.Debito:
                        return DataPagamento.AddDays(2);
                    default:
                        return DataPagamento;
                }
            }
        }

        public Receita(string _Descricao, double _Valor, FormaPagamento _FormaPagamento, DateOnly _DataPgto)
        {
            Descricao = _Descricao;
            Valor = _Valor;
            FormaPagamento = _FormaPagamento;
            DataPagamento = _DataPgto;
        }
    }
}

