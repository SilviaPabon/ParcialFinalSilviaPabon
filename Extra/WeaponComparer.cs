using FirstFantasy.Classes.Equipment;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FirstFantasy.Extra
{
    class WeaponComparer : IComparer<Weapon> //comparador de armas
    {
        public int Compare(Weapon x, Weapon y) 
        {
            return x.Damage.CompareTo(y.Damage);
        }
    }
}
