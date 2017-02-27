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

            Orcamento grana = new Orcamento(10000.0);

            CalculadorDeImpostos calculator = new CalculadorDeImpostos();

            calculator.RealizaCalculo(grana, iccc);

        }
    }
}

