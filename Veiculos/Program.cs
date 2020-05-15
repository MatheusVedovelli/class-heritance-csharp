using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Program
    {
        public static List<Veiculo> vVehicle;

        static void CadastrarCarro()
        {
            Carro car = new Carro();
            Console.Write("Digite o modelo: ");
            car.Modelo = Console.ReadLine();
            Console.Write("Digite o fabricante: ");
            car.fabricante = Console.ReadLine();
            Console.Write("Digite o ano: ");
            car.ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a cor: ");
            car.cor = Console.ReadLine();
            Console.Write("Digite o numero de portas: ");
            car.numero_portas = int.Parse(Console.ReadLine());
            Console.Write("Digite a capacidade do porta malas: ");
            car.capacidadePortaMala = int.Parse(Console.ReadLine());
            Console.Write("Tem bagageiro? (S/N): ");
            string response = Console.ReadLine();
            car.bagageiro = response.ToUpper() == "S" ? true : false;
            Console.Write("Digite o numero de acentos: ");
            car.acentos = int.Parse(Console.ReadLine());
            vVehicle.Add(car);
            Console.Write("Carro cadastrado com sucesso!");
        }

        static void CadastrarCaminhao()
        {
            Caminhao truck = new Caminhao();
            Console.Write("Digite o modelo: ");
            truck.Modelo = Console.ReadLine();
            Console.Write("Digite o fabricante: ");
            truck.fabricante = Console.ReadLine();
            Console.Write("Digite o ano: ");
            truck.ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a cor: ");
            truck.cor = Console.ReadLine();
            Console.Write("Digite o numero de portas: ");
            truck.numero_portas = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de eixos: ");
            truck.numero_eixos = int.Parse(Console.ReadLine());
            Console.Write("Digite o peso maximo da carga: ");
            truck.peso_maximo_carga = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura da carroceria: ");
            truck.altura_carroceria = double.Parse(Console.ReadLine());
            vVehicle.Add(truck);
            Console.Write("Caminhao cadastrado com sucesso!");
        }

        static void Main(string[] args)
        {
            vVehicle = new List<Veiculo>();
            while(true)
            {
                Console.Write("1 - Cadastrar Carro\n2 - Cadastrar Caminhão\n3 - Consulta por placa\n4 - Consultar Caminhão por modelo/marca\n5 - Consultar Carro por cor\n6 - Exibir todos os Carros cadastrados\n7 - Exibir todos os Caminhões cadastrados\n0 - Sair\n");
                Console.Write("Escolha uma opção: ");
                int opt = int.Parse(Console.ReadLine());

                if (opt == 0)
                    break;

                switch(opt)
                {
                    case 1:
                        CadastrarCarro();
                        break;
                    case 2:
                        CadastrarCaminhao();
                        break;
                    case 3:
                        Console.Write("Digite a placa: ");
                        string placa = Console.ReadLine();

                        foreach(Veiculo vehicle in vVehicle)
                        {
                            if (vehicle.placa == placa)
                                vehicle.print();
                        }
                        break;
                    case 4:
                        Console.Write("Digite o modelo: ");
                        string modelo = Console.ReadLine();

                        foreach(Veiculo vehicle in vVehicle)
                        {
                            if (vehicle is Caminhao && vehicle.Modelo == modelo)
                                vehicle.print();
                        }
                        break;
                    case 5:
                        Console.Write("Digite a cor: ");
                        string cor = Console.ReadLine();

                        foreach (Veiculo vehicle in vVehicle)
                        {
                            if (vehicle is Carro && vehicle.cor == cor)
                                vehicle.print();
                        }
                        break;
                    case 6:
                        foreach (Veiculo vehicle in vVehicle)
                        {
                            if (vehicle is Carro)
                                vehicle.print();
                        }
                        break;
                    case 7:
                        foreach (Veiculo vehicle in vVehicle)
                        {
                            if (vehicle is Caminhao)
                                vehicle.print();
                        }
                        break;
                }
            }
        }
    }
}
