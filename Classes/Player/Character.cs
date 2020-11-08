using FirstFantasy.Classes.Equipment;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Windows.Controls;

namespace FirstFantasy.Classes.Player
{
    public abstract partial class Character : IDescribable // sirve de plantilla pero yo no lo instancio porque no tiene representación en el juego
    {
        private String name;
        private int level;
        private int experience;

        private Races race;

        public enum Races { Cleric, Fighter, Rouge, Wizard }

        private List<Weapon> armas = new List<Weapon>();

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public Races Race { get => race; set => race = value; }
        public List<Weapon> Armas { get => armas; set => armas = value; }


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

        public void AddArma(Weapon myWeapon)
        {
            Armas.Add(myWeapon);
        }

        public IEnumerator<Weapon> GetEnumerator()
        {
            return Armas.GetEnumerator();
        }

        


    }
}
