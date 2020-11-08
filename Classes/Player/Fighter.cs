using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Fighter : Character
    {


        public override String ShowCharacter() // a diferencia de Java no se puede override cualquiera, para hacerlo aquí aunque no sea abstract
            // se le debe poner virtual en el método original
        {
            return "Remember my name" + Name.ToUpper() + " My Power " + Level ; // aquí si con Name, accedo por los getters y setters
        }
    }
}
