using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenSedmiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Console.WriteLine(x);
            Kocka y = new Kocka();
            Console.WriteLine(y);
            Kvadar z = new Kvadar();
            Console.WriteLine(z);


            Console.ReadKey();

        }
    }
}
