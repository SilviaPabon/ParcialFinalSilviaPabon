using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
                                                //utilizar interfaces que ya existen
    public abstract class Armor : ObjetoI, IDescribable
    {

        

        private string descripcion;

        /*
        public string Descripcion
        {
            get
            {
                return String.Format("Esta {0} tiene un daño de {1} puntos de ataque.", this.NombreArmadura);
            }
        }
        */

        public string ShowInformation()
        {
            return "This Weapon with "+ " damage";
        }

        
    }
}
