using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Caminhao : Veiculo
    {
        public int numero_eixos;
        public double peso_maximo_carga;
        public double altura_carroceria;

        public override void print()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Modelo: {0}", Modelo);
            Console.WriteLine("Fabricante: {0}", fabricante);
            Console.WriteLine("Ano: {0}", ano);
            Console.WriteLine("Cor: {0}", cor);
            Console.WriteLine("Numero de Portas: {0}", numero_portas);
            Console.WriteLine("Numero de Eixos: {0}", numero_eixos);
            Console.WriteLine("Peso maximo da carga: {0}", peso_maximo_carga);
            Console.WriteLine("Altura da carroceria: {0}", altura_carroceria);
            Console.WriteLine("------------------------");
        }
    }
}
