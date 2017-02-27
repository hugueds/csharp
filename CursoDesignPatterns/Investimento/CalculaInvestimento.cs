namespace CursoDesignPatterns
{
    public class CalculaInvestimento
    {
        public void calculaInvestimento(Orcamento orcamento, Investimento investimento)
        {           

            double lucro = investimento.Investir(orcamento);

            lucro *= 0.75;

            System.Console.WriteLine("O lucro é de: " + lucro);

        }
    }
}