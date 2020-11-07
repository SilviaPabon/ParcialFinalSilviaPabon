using FirstFantasy.Classes.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Cleric : Character
    {
        
        private Weapon myWeaponC;
        public Cleric()
        {
        }

        public Weapon MyWeaponC { get => myWeaponC; set => myWeaponC = value; }

        public Cleric(string name)
        {
            this.Name = name;
        }

        // sobre escribir un método, implementar el método
        // para sobreescribir en otros @override
        public override String Taunt() //override para permitir la sobreescritura
        {
            return "God bless you";
        }


    }
}
