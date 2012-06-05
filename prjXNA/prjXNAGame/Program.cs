using System;

namespace prjXNAGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (ZombieHigh game = new ZombieHigh())
            {
                game.Run();
            }
        }
    }
}

