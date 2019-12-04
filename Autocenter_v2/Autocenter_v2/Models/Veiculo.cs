using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Veiculo
    {
        private string marca;
        private string modelo;
        private string placa;
        private string cor;

        public Veiculo() { }

        public Veiculo(string marca,string modelo,string placa,string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
        }

        public string getMarca() { return marca; }
        public string getModelo() { return modelo; }
        public string getPlaca() { return placa; }
        public string getCor() { return cor; }
        public void setMarca(string ma) { marca = ma; }
        public void setModelo(string mo) { modelo = mo; }
        public void setPlaca(string pl) { placa = pl; }
        public void setCor(string co) { cor = co; }
    }
}
