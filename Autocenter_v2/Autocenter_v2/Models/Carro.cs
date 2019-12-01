using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Carro:Veiculo
    {
        private int cavalos;
        private float torqueMotor;

        public Carro(int cavalos, float torqueMotor)
        {
            this.cavalos = cavalos;
            this.torqueMotor = torqueMotor;
        }
    }
}
