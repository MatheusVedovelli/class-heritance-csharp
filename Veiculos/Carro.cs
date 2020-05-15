using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Carro : Veiculo
    {
        public int capacidadePortaMala;
        public bool bagageiro;
        public int acentos;

        public override void print()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Modelo: {0}", Modelo);
            Console.WriteLine("Fabricante: {0}", fabricante);
            Console.WriteLine("Ano: {0}", ano);
            Console.WriteLine("Cor: {0}", cor);
            Console.WriteLine("Numero de Portas: {0}", numero_portas);
            Console.WriteLine("Capacidade do Porta Mala: {0}", capacidadePortaMala);
            Console.WriteLine("Bagageiro: {0}", bagageiro ? "Sim" : "Não");
            Console.WriteLine("Numero de Acentos: {0}", acentos);
            Console.WriteLine("------------------------");
        }
    }
}
