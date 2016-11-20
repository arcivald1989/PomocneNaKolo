using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Ksiazka book1 = new Ksiazka();
            book1.UstawAutoraITytul("Henryk Sienkiewicz", "Krzyzacy");
            book1.UstawIloscStron(200);
            Console.WriteLine(book1.PodajCene());

            Czasopismo cz1 = new Czasopismo("Wyborcza", 234);
            cz1.WypiszInfo();
            Console.ReadKey();
        }
    }
}
