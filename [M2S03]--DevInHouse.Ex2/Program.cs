namespace _M2S03___DevInHouse.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(5, 6));
            Console.WriteLine(Somar(5, 6,10));




        }
        public static int Somar(double x, double y)
        {
            return (int)(x + y);
        }

        public static int Somar(double x, double y, double z)
        {
            return (int)(x + y + z);
        }
    }
}