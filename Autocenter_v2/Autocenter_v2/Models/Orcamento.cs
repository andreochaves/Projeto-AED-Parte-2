using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Orcamento
    {
        public string TipoServico { get; set; }
        public double Valor { get; set; }
        public string FormaPagamento { get; set; }
        public double ValorTotal { get; set; }

        public Orcamento() { }

        public Orcamento(string tipoServico, double valor, string formaPagamento, double valorTotal)
        {
            this.tipoServico = tipoServico;
            this.valor = valor;
            this.formaPagamento = formaPagamento;
            this.valorTotal = valorTotal;
        }

       
    }
}
