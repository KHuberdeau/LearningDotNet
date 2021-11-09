using System;

namespace LearningProperties
{
    class Property
    {
        class Player
        {
            public bool IsAlive
            {
                get { return health > 0;  }
            }
            int health = 100;

            public void Hit()
            {
                Random r = new Random();
                health -= r.Next(5, 50);
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine("Is player alive: " + player.IsAlive);
            }
        }
    }
}
