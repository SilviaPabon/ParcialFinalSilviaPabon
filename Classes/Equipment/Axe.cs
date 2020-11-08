using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Axe : Weapon
    {
        private string nombreAxe = "Hacha";

        public string NombreAxe { get => nombreAxe; set => nombreAxe = value; }

        
    }
}
