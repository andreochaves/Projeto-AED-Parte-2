using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using Autocenter_v2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    class MotoController
    {
        public static bool cadastrarMoto()
        {
            bool motoCadastrada = false;
            Console.WriteLine("Marca da Moto: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Modelo da Moto: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Placa da Moto: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Cor da Moto: ");
            string cor = Console.ReadLine();
            Console.WriteLine("Cilindradas da Moto: ");
            int cilindradas = int.Parse(Console.ReadLine());

            Moto moto = new Moto();
            moto = new Moto(marca, modelo, placa, cor, cilindradas);


            return motoCadastrada;
        }
    }
}
