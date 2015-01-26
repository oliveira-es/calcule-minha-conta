using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeMinhaConta.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prototipação de código
            //      Simule o máximo possível

            var consumo = new Consumo("Denis", 1, 2, 3);

            var plano = new Plano("Vivo Smart", 0.10m, 0.35m, 0.75m, 30m);

            //var promocao = new Promocao("Fale 30", 0.05m, 0.25m, 0.60m);

            //plano.AdicionarPromocao(promocao);

            var conta = plano.CalcularConta(consumo);

            Console.WriteLine(conta.Total);

            Console.ReadLine();
        }
    }
}
