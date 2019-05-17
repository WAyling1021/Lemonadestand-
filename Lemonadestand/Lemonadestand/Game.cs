using System;
namespace LemonadeStand
{
    public class Game
    {
        //member variables (Has A)
        public Player player;

        // constructor (Spawner)
        public Game()
        {
            player = new Player();
        }

        // member methods
        public void RunGame()
        {
            UI.DisplayInventory(player.myInventory);
            UI.DisplayName(player);
            Console.ReadLine();

        }






    }
}






