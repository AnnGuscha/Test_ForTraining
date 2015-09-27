using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ForTraining
{
    internal enum Discount
    {
        noDiscount,
        Type1,
        Type2,
        Type3
    }

    internal class Buy: IComparable<Buy>
    {
        private int day;       
        private int count;

        private static int month;
        private static int price;

        private Discount discount;

        private static int transportationСosts;

        public static int Month
        {
            get { return month; }
            set { month = value; }
        }

        public static int Price
        {
            get { return price; }
            set { price = value; }
        }

        public static int TransportationСosts
        {
            get { return transportationСosts; }
            set { transportationСosts = value; }
        }

        private int percent;
        private int costBonusItem;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public Discount Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public Buy(int day, int count)
        {
            this.day = day;
            this.count = count;
            this.discount = Discount.noDiscount;
        }

        public Buy(int day, int count, Discount discountType)
        {
            this.day = day;
            this.count = count;          
            if (discountType == Discount.Type2)
            {
                this.discount = discountType;
            }
        }

        public Buy (int day,  int count, Discount discountType, int discount )
        {
            this.day = day;
            this.count = count;
            if ( discountType == Discount.Type1 )
            {
                this.percent = discount;
            }
            else if ( discountType == Discount.Type3 )
            {
                this.costBonusItem = discount;
            }
            this.discount = discountType;
        }

        public int Cost()
        {
            int cost=0;
            cost = price*count;
            switch (discount)
            {
                case Discount.Type1:
                {
                    cost = cost*(1 - percent/100);
                }
                    break;
                case Discount.Type2:
                {
                    cost = cost - transportationСosts;                     
                }
                    break;
                case Discount.Type3:
                {
                    cost = cost - costBonusItem;
                }
                    break;
            }
            return cost;
        }

        public int CompareTo ( Buy obj )
        {
            if ( obj.Day<this.Day)
                return 1;
            else if (obj.Day>this.Day)
            {
                return -1;
            }
            else
                return 0;
        }

        public override string ToString()
        {
            return string.Format("День: {0}, Кол-во: {1}, Скидка: {2}, Общая ст-ть: {3}", Day, Count, Discount, Cost());
        }
    }
}
