using System;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            CACriatura exploradora = new CExploradora(100, 20, 20);
            Console.WriteLine("La exploradora ataca con : " + exploradora.Ataque() + " puntos.");
        }
    }
}
