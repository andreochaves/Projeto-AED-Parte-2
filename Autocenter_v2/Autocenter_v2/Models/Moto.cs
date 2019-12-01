using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Moto:Veiculo
    {
        private int cilindradas;

        public Moto(int cilindradas)
        {
            this.cilindradas = cilindradas;
        }
    }
}
