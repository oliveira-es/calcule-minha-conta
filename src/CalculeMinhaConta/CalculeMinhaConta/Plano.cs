using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeMinhaConta
{
    public class Plano
    {
        public string Nome { get; set; }

        public decimal ValorParaFixo { get; set; }

        public decimal ValorParaCelular { get; set; }

        public decimal ValorParaInterurbano { get; set; }

        public decimal ValorAssinatura { get; set; }

        public Plano(   string nome, 
                        decimal valorParaFixo, 
                        decimal valorParaCelular, 
                        decimal valorParaInterurbano,
                        decimal valorAssinatura)
        {
            this.Nome = nome;
            this.ValorParaFixo = valorParaFixo;
            this.ValorParaCelular = valorParaCelular;
            this.ValorParaInterurbano = valorParaInterurbano;
            this.ValorAssinatura = valorAssinatura;
        }

        public Conta CalcularConta(Consumo consumo)
        {
            var conta = new Conta();

            var servicos = new List<Servico>();

            servicos.Add(new Servico("Assinatura", 1, this.ValorAssinatura));
            servicos.Add(new Servico("Ligações para fixo", consumo.MinutosParaFixo, this.ValorParaFixo));
            servicos.Add(new Servico("Ligações para cel.", consumo.MinutosParaCelular, this.ValorParaCelular));
            servicos.Add(new Servico("Ligações para int;", consumo.MinutosParaInterurbano, this.ValorParaInterurbano));

            conta.Total = servicos.Sum(s => s.ObterTotal());

            return conta;
        }
    }

    public class Servico
    {
        public string Nome { get; set; }
        
        public int Quantidade { get; set; }

        public decimal Valor { get; set; }

        public Servico(string nome, int quantidae, decimal valor)
        {
            Nome = nome;
            Quantidade = quantidae;
            Valor = valor;
        }

        public decimal ObterTotal()
        {
            return this.Valor * this.Quantidade ;
        }
    }
}
