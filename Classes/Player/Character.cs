using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public abstract partial class Character : IDescribable // sirve de plantilla pero yo no lo instancio porque no tiene representación en el juego
    {
        private String name;
        private int level;
        private int experience;

        private Races race;

        public enum Races { Cleric, Fighter, Rouge, Wizard }

        //enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat}

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public Races Race { get => race; set => race = value; }

        //private Enum race; //Como se tiene arriba es más estricto
        //public Enum Race { get => race; set => race = value; }


        public abstract String Taunt(); // sólo dentro de una clase abstract, sobreescribir un método, redefinir

        //obliga que las clases también tenga esto, si no, no deja
        public virtual String ShowCharacter() // no abstractos pero se pueden sobreescribir
        { // aquí en minúscula pues está dentro de la clase
            return "Name: " + name + " level " + level + " XP: " + experience;
        }

        public string ShowInformation()
        {
            return "This is a lever " + level + " character ";
        }

        public override string ToString()
        {
            return this.Name + ", Raza: " + this.Race;
        }

    }
}
