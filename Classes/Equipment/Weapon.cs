using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
                                                //utilizar interfaces que ya existen
    public abstract class Weapon : IDescribable
    {
        private int damage;

        public int Damage { get => damage; set => damage = value; }

        public Weapon(int damage)
        {
            this.damage = damage;
        }

        protected Weapon()
        {
        }

        public string Attack()
        {
            int ataque = new Random().Next(0, 8);
            return "El ataque del" + ataque;
        }

        public string ShowInformation()
        {
            return "This Weapon with "+ damage +" damage";
        }

        public int CompareTo(Weapon obj) // implementación método de la interfaz comparable
        {
            return damage.CompareTo(obj.Damage); //criterio de comparación
        }
    }
}
