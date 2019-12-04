using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Orcamento
    {
        private string tipoServico;
        private double valor;
        private string formaPagamento;
        private double valorTotal;

        public Orcamento() { }

        public Orcamento(string tipoServico, double valor, string formaPagamento, double valorTotal)
        {
            this.TipoServico = tipoServico;
            this.Valor = valor;
            this.FormaPagamento = formaPagamento;
            this.ValorTotal = valorTotal;
        }
        public string getTipoServico() { return tipoServico; }
        public double getvalor() { return valor; }
        public string getFormaPagamento() { return formaPagamento; }
        public double getValorTotal() { return valorTotal; }
        public void setMarca(string ts) { tipoServico = ts; }
        public void setModelo(double va) { valor = va; }
        public void setPlaca(string fp) { formaPagamento = fp; }
        public void setCor(double vt) { valorTotal = vt; }
       
    }
}
