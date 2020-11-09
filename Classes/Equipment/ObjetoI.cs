
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
                                                //utilizar interfaces que ya existen
    public abstract class ObjetoI
    {
        private string nombreObjeto;

        private string tipoObjeto;

        private int damage;

        public string NombreObjeto { get => nombreObjeto; set => nombreObjeto = value; }
        public string TipoObjeto { get => tipoObjeto; set => tipoObjeto = value; }
        public int Damage { get => damage; set => damage = value; }
    }
}
