using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspitZadatak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite bilo koji broj koji zelite: ");
            int a =  Convert.ToInt32(Console.ReadLine());
            if(a % 4 == 0 )
            {
                Console.WriteLine("broj je djeljiv sa 4");
            }
            if (a % 6 == 0)
            {
                Console.WriteLine("broj je djeljiv sa 6");
            }
            if (a % 4 == 0 && a % 6 == 0)
            {
                Console.WriteLine("broj je djeljiv sa 4 i sa 6");
            }
            if (a % 4 != 0 && a % 6 != 0)
            {
                Console.WriteLine("broj nije djeljiv sa 4 ni sa 6");
            }
            Console.ReadKey();
        }
    }
}
