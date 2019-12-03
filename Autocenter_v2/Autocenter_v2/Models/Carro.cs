using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Carro:Veiculo
    {
        public int Cavalos { get; set; }
        public float TorqueMotor { get; set; }

        public Carro() { }
        public Carro(int cavalos, float torqueMotor)
        {
            this.cavalos = cavalos;
            this.torqueMotor = torqueMotor;
        }
    }
}
