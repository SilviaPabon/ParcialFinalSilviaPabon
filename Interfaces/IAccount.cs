using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Interfaces
{
    interface IAccount
    {
        public bool Register(string name, int creditCard);
        // no necesito saber cómo trabaja register en su interior
    }
}
