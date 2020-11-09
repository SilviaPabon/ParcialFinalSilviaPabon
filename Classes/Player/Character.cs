using FirstFantasy.Classes.Equipment;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Windows.Controls;

namespace FirstFantasy.Classes.Player
{
    public abstract partial class Character // sirve de plantilla pero yo no lo instancio porque no tiene representación en el juego
    {
        private String name;

        private Races race;
        public enum Races { Cleric, Fighter, Rouge, Wizard }

        private List<ObjetoI> armas = new List<ObjetoI>();

        private List<ObjetoI> inventario = new List<ObjetoI>();

        public string Name { get => name; set => name = value; }
        public Races Race { get => race; set => race = value; }
        public List<ObjetoI> Armas { get => armas; set => armas = value; }
        public List<ObjetoI> Inventario { get => inventario; set => inventario = value; }

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

        public IEnumerator<ObjetoI> GetEnumerator()
        {
            return Armas.GetEnumerator();
        }

    }
}
