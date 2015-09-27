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
        private int id;
        private int day;
        private int month;
        private int count;
        private int price;

        private Discount discount;

        private int transportationСosts;

        private int percent;
        private Buy bonusItem;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Discount Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public Buy(int id, int day, int month, int count, int price)
        {
            this.id = id;
            this.day = day;
            this.month = month;
            this.count = count;
            this.price = price;
            this.discount = Discount.noDiscount;
        }

        public Buy ( int id, int day, int month, int count, int price, Discount discountType, int discount )
        {
            this.id = id;
            this.day = day;
            this.month = month;
            this.count = count;
            this.price = price;
            this.discount = discountType;
            if ( discountType == Discount.Type1 )
            {
                this.percent = discount;
            }
            else if( discountType == Discount.Type2 )
            {
                this.transportationСosts = discount;
            }
        }

        public Buy(int id, int day, int month, int count, int price, Discount discountType, Buy bonusItem)
        {
            this.id = id;
            this.day = day;
            this.month = month;
            this.count = count;
            this.price = price;
            this.discount = discountType;
            if (discountType == Discount.Type3)
            {
                this.bonusItem = bonusItem;
            }
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
                    cost = cost - bonusItem.price;
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
            return string.Format("День: {0}, Месяц: {1}, Кол-во: {2}, Цена: {3}, Скидка: {4}, Общая ст-ть: {5}", Day, Month, Count, Price, Discount, Cost());
        }
    }
}
