using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Carro:Veiculo
    {
        private float cavalos;
        private float torqueMotor;

        public float getCavalos() { return cavalos; }
        public float getTorqueMotor() { return torqueMotor; }
        public void setCavalos(float cav) { this.cavalos = cav; }
        public void setTorqueMotor(float torqueM) { this.torqueMotor = torqueM; }
        public Carro() { }
        public Carro(int cavalos, float torqueMotor)
        {
            this.cavalos = cavalos;
            this.torqueMotor = torqueMotor;
        }
    }
}
