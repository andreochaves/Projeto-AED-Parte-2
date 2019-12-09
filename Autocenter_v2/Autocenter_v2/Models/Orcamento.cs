using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Orcamento
    {
        private string nomeCliente;
        private string veiculo;
        private string placa;
        private string servicos;
        private string formaPagamento;
        private double valorTotal;

        public Orcamento() { }

        public Orcamento(string nomeCliente, string veiculo, string placa,string servicos, string formaPagamento, double valorTotal)
        {
            this.nomeCliente = nomeCliente;
            this.veiculo = veiculo;
            this.placa = placa;
            this.servicos = servicos;
            this.formaPagamento = formaPagamento;
            this.valorTotal = valorTotal;
        }
        public string getNomeCliente() { return nomeCliente; }
        public string getVeiculo() { return veiculo; }
        public string getPlaca() { return placa; }
        public string getServicos() { return servicos; }
        public string getFormaPagamento() { return formaPagamento; }
        public double getValorTotal() { return valorTotal; }
        public void setNomeCliente(string nc) { nomeCliente = nc; }
        public void setVeiculo(string ve) { veiculo = ve; }
        public void setPlaca(string pl) { placa = pl; }
        public void setServiços(string se) {servicos  = se; }
        public void setFormaPagamento(string fp) { formaPagamento = fp; }
        public void setValorTotal(double vt) { valorTotal = vt; }
       
    }
}
