using System;

namespace GameEquipmentInterfaceDemo.Interfaces
{
    interface IItem
    {
        string Name { get; set; }
        int GoldValue { get; set; }
        void Equip();
        void Sell();
    }

    interface IDamageable
    {
        int Durability { get; set; }
        void TakeDamage(int _amount);
    }
}