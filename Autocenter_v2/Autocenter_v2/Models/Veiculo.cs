using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Veiculo
    {
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected string Placa { get; set; }
        protected string Cor { get; set; }

        public Veiculo() { }

        public Veiculo(string marca,string modelo,string placa,string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
        }
    }
}
