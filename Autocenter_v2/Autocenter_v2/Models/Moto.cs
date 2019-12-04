using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Models
{
    class Moto:Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto() { }

        public Moto(int cilindradas)
        {
            this.Cilindradas = cilindradas;
        }
        
    }
}
