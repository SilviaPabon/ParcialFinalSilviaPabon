using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Rouge : Character
    {
        public override String Taunt() //override para permitir la sobreescritura
        {
            return "By me";
        }
    }
}
