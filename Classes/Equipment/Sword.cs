using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Sword : Weapon, IDescribable
    {
        public Sword()
        {
        }

        public Sword(int damage) : base(damage)
        {
        }

        public string ShowInformation()
        {

            return "This is a strange potion";
        }
    }
}
