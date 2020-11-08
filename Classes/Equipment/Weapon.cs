using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
                                                //utilizar interfaces que ya existen
    public abstract class Weapon : IDescribable
    {
        private string nombreArma;

        private int damage;

        private string descripcion;

        public string NombreArma { get => nombreArma; set => nombreArma = value; }

        public int Damage { get => damage; set => damage = value; }
        public string Descripcion
        {
            get
            {
                return String.Format("Esta {0} tiene un daño de {1} puntos de ataque.", this.NombreArma, this.Damage);
            }
        }

        public int Attack()
        {
            damage = new Random().Next(1, 8);
            return damage;
        }

        public string ShowInformation()
        {
            return "This Weapon with "+ damage +" damage";
        }

        
    }
}
