using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Moto:Veiculo
    {
        public int cilindradas;

        public Moto() { }

        public Moto(int cilindradas)
        {
            this.cilindradas = cilindradas;
        }
        public int getCilindradas() { return cilindradas; }
        public void setCilindradas(int cl) { cilindradas = cl; }
    }
}
