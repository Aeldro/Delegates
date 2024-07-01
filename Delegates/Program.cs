namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMoney money = ShowDollar;
            Console.WriteLine(money(10));
            money = ShowEuro;
            Console.WriteLine(money(10));
        }

        public delegate string ShowMoney(int x);
        public static string ShowDollar(int x)
        {
            return x.ToString() + "$";
        }
        public static string ShowEuro(int x)
        {
            return x.ToString() + "€";
        }
    }
}

