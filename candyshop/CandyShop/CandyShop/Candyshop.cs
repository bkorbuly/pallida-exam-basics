using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Candyshop
    {
        int sugar;
        int candies;
        int lollipops;
        double money;
        double sugarprice = 0.1 ;
        List<Sweet> sweets = new List<Sweet>();

        public Candyshop(int sugar)
        {
            this.sugar = sugar;
        }

        public void Createsweets(Candie candie)
        {
            sweets.Add(candie);
            sugar -= candie.sugarNeed;
            ++candies;
        }

        public void Createsweets(Lollipop lollipop)
        {
            sweets.Add(lollipop);
            sugar -= lollipop.sugarNeed;
            ++lollipops;
        }

        public void Raise(double percentage)
        {
            foreach(Sweet sweet in sweets)
            {
                sweet.price = sweet.price * (1+(percentage / 100));
            }
        }

        public void Sellsweets(Candie candie, int quantity)
        {
            if (quantity < candies)
            {
                candies -= quantity;
                money += candie.price * quantity;
            }
            else
            {
                Console.WriteLine("Can not sell more candies then the candishop has in inventory");
            }
        }

        public void Sellsweets(Lollipop lollipop, int quantity)
        {
            if (quantity < lollipops)
            {
                lollipops -= quantity;
                money += lollipop.price * quantity;
            }
            else
            {
                Console.WriteLine("Can not sell more lollipopes then the candishop has in inventory");
            }
        }

        public void BuySugar(int amount)
        {
            if (amount * sugarprice < money)
            {
                sugar += amount;
                money -= (amount * sugarprice);
            }
            else
            {
                Console.WriteLine("Out of money. Go to the bank for loan");
            }
        }

        public void Printout()
        {
            Console.WriteLine("Inventories: {0} candies, {1} lollipopes, Money: {2}, Sugar: {3}gr.", candies, lollipops, money, sugar);
        }


    }
}
