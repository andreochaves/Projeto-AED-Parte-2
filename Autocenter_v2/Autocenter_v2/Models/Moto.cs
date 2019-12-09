using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Moto:Veiculo
    {
        public int cilindradas;

        public Moto() { }

        public Moto(string marca, string modelo, string placa, string cor, int cilindradas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.cilindradas = cilindradas;
        }
        public int getCilindradas() { return cilindradas; }
        public void setCilindradas(int cl) { cilindradas = cl; }
    }
}
