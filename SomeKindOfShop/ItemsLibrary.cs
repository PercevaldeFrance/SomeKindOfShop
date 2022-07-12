using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeKindOfShop
{
    public class ItemsLibrary
    {
        public abstract class Cloth :Item
        {
            public int Armor { get; set; }
        }
        public abstract class Weapon: Item
        {
            public int Damage { get; set; }
        }
        public abstract class Meal : Item 
        {
            public int Tastyness { get; set; }
        }
        
        public abstract class Item
        {
            public int price;
            public int weight;
        }

        public class Shoes : Cloth
        {
            public Shoes()
            {
                price = 25;
                Armor = 10;
            }
        }
        public class Cape : Cloth
        {
            public Cape()
            {
                price = 30;
                Armor = 10;
                
            }
        }
        public class Pants : Cloth
        {
            public Pants()
            {
                price = 15;
                Armor = 10;
            }
        }
        public class Sword : Weapon
        {
            public Sword()
            {
                price = 50;
                Damage = 25;
            }
        }
        public class Bow : Weapon
        {
            public Bow()
            {
                price = 40;
                Damage = 20;
            }
        }
        public class Axe : Weapon
        {
            public Axe()
            {
                price = 60;
                Damage = 50;
            }
        }
        public class Potion : Meal
        {
            public Potion()
            {
                price = 5;
                Tastyness = 2;
            }
        }
        public class Bread : Meal
        {
            public Bread()
            {
                price = 1;
                Tastyness = 10;
            }
        }
        public class Gluwein : Meal
        {            
            public Gluwein()
            {
                price = 10;
                Tastyness = 50;
            }
        }
    }
}
