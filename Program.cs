using System;
using GameEquipmentInterfaceDemo.Models;

namespace GameEquipmentInterfaceDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sword sword = new Sword("MasterBlade");

            sword.Equip();
            sword.TakeDamage(15);
            sword.Sell();
        }
    }
}