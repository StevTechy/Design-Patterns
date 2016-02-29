using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Goblin goblin = new Goblin();
            Console.WriteLine(goblin.GetDescription());
            goblin.MoveOnce();

            Bat bat = new Bat();
            Console.WriteLine(bat.GetDescription());
            bat.MoveOnce();

            Cockatrice cockatrice = new Cockatrice();
            Console.WriteLine(cockatrice.GetDescription());
            cockatrice.MoveOnce();
            //Using the Strategy Pattern I am able to easily use classes interchangeably at runtime
            cockatrice.ChangeMoveType(new Fly());
            cockatrice.MoveOnce();
           
            Console.ReadKey();
        }
    }
}
