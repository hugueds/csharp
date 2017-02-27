using System;

namespace CursoDesignPatterns
{
    public class Moderado : Investimento
    {
        public double Investir(Orcamento orcamento)
        {
            double perCent = 0;
            bool lucro = new Random().Next(101) > 50;

            if (!lucro) perCent = 0.025; 
            else perCent = 0.007;

            Console.WriteLine("Tipo de investimento: Moderado");
            Console.WriteLine("Investido: " + orcamento.Valor);
            return orcamento.Valor * perCent;
        }
    }
}