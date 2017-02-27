using System;

namespace CursoDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {         
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            Investimento cons = new Conservador();
            Investimento moder = new Moderado();
            Investimento arroj = new Arrojado();

            Orcamento grana = new Orcamento(10000.0);

            CalculadorDeImpostos calculator = new CalculadorDeImpostos();
            CalculaInvestimento calcInv = new CalculaInvestimento();

            calculator.RealizaCalculo(grana, iccc);
            calcInv.calculaInvestimento(grana, arroj);

        }
    }
}

