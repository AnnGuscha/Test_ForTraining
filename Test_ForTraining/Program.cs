using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining
{
    class Program
    {
        static void Main ( string[] args )
        {
            List<Buy> items = new List<Buy>();

            items.Add(new Buy(0,5,3,2,300,Discount.Type1, 20));
            items.Add ( new Buy ( 0, 5, 3, 2, 300, Discount.Type1, 10 ));
            items.Add ( new Buy ( 1, 7, 3, 1, 300, Discount.Type2, 20));
            items.Add ( new Buy ( 2, 25, 3, 5, 300, Discount.Type1, 5 ));
            items.Add ( new Buy ( 3, 1, 3, 3, 300, Discount.Type3, items[1]));
            items.Add ( new Buy ( 4, 13, 3, 2, 300, Discount.Type2, 20));
            items.Add ( new Buy ( 5, 3, 3, 4, 300, Discount.Type1, 20 ));
            items.Add ( new Buy ( 6, 11, 3, 6, 300, Discount.Type1, 5 ));
            items.Add ( new Buy ( 7, 27, 3, 2, 300, Discount.Type3, items[4]));
            items.Add ( new Buy ( 8, 1, 3, 3, 300, Discount.Type3, items[2]));
            items.Add ( new Buy ( 9, 10, 3, 2, 300, Discount.Type2, 20 ));
            items.Add ( new Buy ( 10, 22, 3, 4, 300, Discount.Type1, 15 ));

            items.Sort();

            int countBuy=0;
            foreach (var item in items)
            {
                if (item.Day == 10)
                    countBuy++;
                Console.WriteLine(item.ToString());
            }

            if (countBuy > 0)
            {
                Console.WriteLine("Покупок 10-го числа: "+countBuy);
            }
            else
            {
                Console.WriteLine ( "10-го числа не совершено ни одной покупки." );
            }

            Console.ReadKey();
        }
    }
}
