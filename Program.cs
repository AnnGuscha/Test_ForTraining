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

            Buy.TransportationСosts = 20;
            Buy.Price = 300;
            Buy.Month = 3;

            items.Add(new Buy(5,3,Discount.Type1, 20));
            items.Add ( new Buy ( 5, 2, Discount.Type1, 10 ) );
            items.Add ( new Buy ( 7, 3,  Discount.Type2) );
            items.Add ( new Buy ( 25, 5, Discount.Type1, 5 ) );
            items.Add ( new Buy ( 1,  3, Discount.Type3, 300) );
            items.Add ( new Buy ( 10,  2, Discount.Type2) );
            items.Add ( new Buy ( 3,  4, Discount.Type1, 20 ) );
            items.Add ( new Buy (11,  6,  Discount.Type1, 5 ) );
            items.Add ( new Buy (  27,  2,  Discount.Type3, 300 ) );
            items.Add ( new Buy ( 1,  3,  Discount.Type3, 200 ) );
            items.Add ( new Buy ( 10,  2,  Discount.Type2 ) );
            items.Add ( new Buy ( 22,  4, Discount.Type1, 15 ) );

            items.Sort();

            Console.WriteLine("Цена 1 товара: " + Buy.Price + " бел. руб.");
            Console.WriteLine ( "Текущий месяц: " + Buy.Month);

            int countBuy=0;
            foreach (var item in items)
            {
                if (item.Day == 10)
                    countBuy++;
                Console.WriteLine(item.ToString());
            }

            if (countBuy > 0)
            {
                Console.WriteLine("Покупок 10-го числа: " + countBuy);
            }
            else
            {
                Console.WriteLine ( "10-го числа не совершено ни одной покупки." );
            }

            Console.ReadKey();
        }
    }
}
