
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Potion : ObjetoI
    {

        public string Descripcion
        {
            get
            {
                return String.Format("Esta {0} tiene un daño de {1} puntos de ataque.", this.NombreObjeto, this.Damage);
            }
        }
    }
}
