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

        public void Rise(double percentage)
        {
            foreach(Sweet sweet in sweets)
            {
                sweet.price = sweet.price * (percentage / 100);
            }
        }


    }
}
