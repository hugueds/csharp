namespace CursoDesignPatterns
{
    public class Conta
    {
        private ushort number;
        private double money;

        public Conta (ushort number, double money)
        {
            this.number = number;
            this.money = money;
        }

        public void getMoney(){
            System.Console.WriteLine(this.money);
        }

        public void print()
        {
            System.Console.WriteLine("printing");
        }
    }
}