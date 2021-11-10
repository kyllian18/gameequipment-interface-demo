using System;
using GameEquipmentInterfaceDemo.Interfaces;

namespace GameEquipmentInterfaceDemo.Models
{
    public class Sword : IItem, IDamageable
    {
        public string Name { get; set; }
        public int GoldValue { get; set; }
        public int Durability { get; set; }

        public Sword(string _name)
        {
            Name = _name;
            GoldValue = 100;
            Durability = 100;
        }

        public void Equip()
        {
            Console.WriteLine($"{Name} is equipped");
        }

        public void Sell()
        {
            Console.WriteLine($"{Name} is sold for {GoldValue} imaginary dollars!");
        }

        public void TakeDamage(int _amountOfDamage)
        {
            Durability -= _amountOfDamage;
            Console.WriteLine($"{Name} damaged by {_amountOfDamage}. It now has a durability of {Durability}");
        }
    }
}