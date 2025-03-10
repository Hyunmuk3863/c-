using System.Formats.Asn1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region p50
            Console.WriteLine("Hello, World!");
            long a = -500_000_000_000;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30_000;
            ushort d = 60_000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -10_000_000;
            uint f = 300_000_000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -500_000_000_000;
            ulong h = 2_000_000_000_000_000_000;

            Console.WriteLine($"g={g},h={h}");



            #endregion
        }
    }
}
