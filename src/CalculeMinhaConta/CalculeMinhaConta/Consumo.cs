using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeMinhaConta
{
    public class Consumo
    {
        public string Usuario { get; set; }

        public int MinutosParaFixo { get; set; }

        public int MinutosParaCelular { get; set; }

        public int MinutosParaInterurbano { get; set; }

        public Consumo( string usuario, 
                        int minutosParaFixo, 
                        int minutosParaCelular, 
                        int minutosParaInterurbano)
        {
            // TODO: Complete member initialization
            this.Usuario = usuario;
            this.MinutosParaFixo = minutosParaFixo;
            this.MinutosParaCelular = minutosParaCelular;
            this.MinutosParaInterurbano = minutosParaInterurbano;
        }
    }
}
