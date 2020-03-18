using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public abstract class CADecorator : CAEspada
    {
        protected CAEspada _espada;

        public CADecorator(CAEspada component)
        {
            this._espada = component;
        }

        public void SetComponent(CAEspada component)
        {
            this._espada = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public override int Ataque()
        {
            if (this._espada != null)
            {
                return this._espada.Ataque();
            }
            else
            {
                return 0;
            }
        }
    }
}