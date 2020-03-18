using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public class CHechizo1 : CADecorator
    {
        public CHechizo1(CAEspada espada) : base(espada) { }

        public override int Ataque()
        {
            return base.Ataque() + 10;
        }
    }
}