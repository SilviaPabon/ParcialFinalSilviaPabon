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

        private List<ObjetoI> armas = new List<ObjetoI>();

        private List<ObjetoI> inventario = new List<ObjetoI>();

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public Races Race { get => race; set => race = value; }
        public List<ObjetoI> Armas { get => armas; set => armas = value; }
        public List<ObjetoI> Inventario { get => inventario; set => inventario = value; }

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

        public void AddObjetos(ObjetoI myinventary)
        {
            Inventario.Add(myinventary);
        }

        public int SumarAttack()
        {
            int sumatoria = 0;

            foreach (Weapon w in armas)
            {
                sumatoria += w.Damage;
            }

            return sumatoria;
        }

        public IEnumerator<ObjetoI> GetEnumerator()
        {
            return Armas.GetEnumerator();
        }

        public IEnumerator<ObjetoI> GetEnumerator2()
        {
            return Inventario.GetEnumerator();
        }


    }
}
