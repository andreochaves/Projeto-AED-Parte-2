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
        public Carro(string marca, string modelo, string placa, string cor,float cavalos, float torqueMotor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.cavalos = cavalos;
            this.torqueMotor = torqueMotor;
        }
    }
}
