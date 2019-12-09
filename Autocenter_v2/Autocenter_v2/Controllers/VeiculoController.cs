using Autocenter_v2.DAO;
using Autocenter_v2.Models;
using Autocenter_v2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autocenter_v2.Controllers
{
    public static class VeiculoController
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

            VeiculoDAO veiculoDAO = new VeiculoDAO();
            veiculoDAO.inserirCarro(carro);

            return carroCadastrado;
        }

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

            VeiculoDAO veiculoDAO = new VeiculoDAO();
            motoCadastrada = veiculoDAO.inserirMoto(moto);

            return motoCadastrada;
        }

    }
}
