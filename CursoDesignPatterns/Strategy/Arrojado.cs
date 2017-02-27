using System;

namespace CursoDesignPatterns
{
    public class Arrojado : Investimento
    {
        public double  Investir(Orcamento orcamento)
        {
            double perCent = 0;
            double  lucro = new Random().Next(101);

            if (lucro <= 20) perCent = 0.5; 
            else if( lucro > 20 && lucro < 50 ) perCent = 0.3;
            else perCent = 0.006;

            Console.WriteLine("Tipo de investimento: Arrojado");
            Console.WriteLine("Investido: " + orcamento.Valor);
            return orcamento.Valor * perCent;
        }
}
}