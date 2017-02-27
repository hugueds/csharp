using System;

namespace CursoDesignPatterns
{
    public class Conservador : Investimento
    {
        public double Investir(Orcamento orcamento)
        {
            Console.WriteLine("Tipo de investimento: Conservador");
            Console.WriteLine("Investido: " +  orcamento.Valor);
            return orcamento.Valor * 0.08;
        }

    }
}