using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Veiculo
    {
        public string Modelo;
        public string fabricante;
        public int ano;
        public string cor;
        public int numero_portas;
        public string placa;

        public virtual void print()
        {
            Console.Write("Undefined type.");
        }
    }
}
