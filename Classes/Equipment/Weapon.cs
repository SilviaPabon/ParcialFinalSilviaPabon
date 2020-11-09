
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
                                                //utilizar interfaces que ya existen
    public abstract class Weapon : ObjetoI
    {

        private int damage;

        private string descripcion;

        public int Damage { get => damage; set => damage = value; }
        public string Descripcion
        {
            get
            {
                return String.Format("Esta {0} tiene un daño de {1} puntos de ataque.", this.NombreObjeto, this.Damage);
            }
        }

        public int Attack()
        {
            damage = new Random().Next(1, 8);
            return damage;
        }

        
    }
}
