using System;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            CHeroe exploradora = new CHeroe();
            CAEspada espada = new CEspada();

            Console.WriteLine("Ataque de exploradora con : " + exploradora.Atacar(espada) + " puntos de golpe");

            CADecorator hechizoataque = new CHechizo1(espada);
            CADecorator hechizoataque1 = new CHechizo1(hechizoataque);

            Console.WriteLine("Ataque de exploradora con : " + exploradora.Atacar(hechizoataque1) + " puntos de golpe");
        }
    }
}
