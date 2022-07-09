using System;

namespace SomeKindOfShop
{
    interface IWearable
    {
        void Wear();
    }
    interface IDamageable
    {
        void Damage();
    }
    public class Items
    {
        public int price;
        public int armor;
        public int speed;
        public int damage;
    }

    public class Shoes : Items, IWearable 
    {
        public Shoes()
        {
            price = 25;
            armor = 3;
            speed = 20;
        }
    }
    class Cape : Items, IWearable
    {
        public Cape()
        {
            price = 30;
            armor = 10;
            speed = 2;
        }
    }
    class Pants : Items, IWearable
    {
        public Pants()
        {
            price = 15;
            armor = 10;
            speed = 10;
        }
    }
    class Sword : Items, IDamageable
    {
        public Sword()
        {
            price = 50;
            damage = 25;
        }
    }
    class Bow : Items, IDamageable
    {
        public Bow()
        {
            price = 40;
            damage = 20;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shoes shoes = new Shoes();
            Cape cape = new Cape();
            Pants pants = new Pants();
            Sword sword = new Sword();
            Bow bow = new Bow();

        }
    }
}
