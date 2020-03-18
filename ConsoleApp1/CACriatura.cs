using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public abstract class CACriatura
    {
        public int salud;
        public int ataque;
        public int defensa;

        public int Ataque()
        {
            return ataque;
        }
        public int Defensa()
        {
            return defensa;
        }

        public  int Salud()
        {
            return salud;
        }

    }
}