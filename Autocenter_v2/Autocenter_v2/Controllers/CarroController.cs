using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using Autocenter_v2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    class CarroController
    {
        public static bool cadastrarCarro()
        {
            bool carroCadastrado = false;
            Console.WriteLine("Marca do Carro: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Modelo do Carro: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Placa do Carro: ");
            string placa = Console.ReadLine();
            Console.WriteLine("Cor do Carro: ");
            string cor = Console.ReadLine();
            Console.WriteLine("Cavalos do Carro: ");
            float cavalos = float.Parse(Console.ReadLine());
            Console.WriteLine("Torque do Motor do Carro: ");
            float torqueMotor = float.Parse(Console.ReadLine());

            Carro carro = new Carro();
            carro = new Carro(marca, modelo, placa, cor, cavalos, torqueMotor);

            return carroCadastrado;
        }
    }
}
