namespace Div_E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int numero = int.Parse(Console.ReadLine());

            bool rtaParse = int.TryParse(Console.ReadLine(), out int resultado);

            if (rtaParse)
            {
                Console.WriteLine("Funciono el parseo");
            }
            else
            {
                Console.WriteLine("No Funciono el parseo");
            }

            Console.WriteLine(resultado);
        }
    }
}
