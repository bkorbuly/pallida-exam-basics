using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var candyshop = new Candyshop(300);
            var lollipop = new Lollipop();
            candyshop.Createsweets(new Lollipop());
            candyshop.Createsweets(new Lollipop());
            candyshop.Createsweets(new Candie());
            candyshop.Createsweets(new Candie());
            candyshop.Sellsweets(new Candie(), 1);
            candyshop.Raise(5);
            Console.WriteLine(lollipop.price);
            candyshop.Sellsweets(new Lollipop(), 1);
            candyshop.BuySugar(1000);
            candyshop.Printout();
            Console.ReadLine();
        }
    }
}
