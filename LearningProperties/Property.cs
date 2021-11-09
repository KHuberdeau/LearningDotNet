using System;

namespace LearningProperties
{
    class Property
    {
        class Player
        {
            public bool isAlive = true;
            int health = 100;

            public void Hit()
            {
                Random r = new Random();
                health -= r.Next(5, 50);
            }

            public void CheckDeath()
            {
                if (health <= 0)
                    isAlive = false;
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                player.CheckDeath();
                Console.WriteLine("Is player alive: " + player.isAlive);
            }
        }
    }
}
