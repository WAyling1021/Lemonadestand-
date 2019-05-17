using System;
namespace LemonadeStand
{
    public class Player
    {
        //member variables (Has A)
        public string Name;
        public double Money;
        public Inventory myInventory;



        // constructor (Spawner)
        public Player()
        {
            Console.WriteLine("Please enter your name: ");
            Name = Console.ReadLine();
            Money = 20;
            myInventory = new Inventory(0, 0, 0, 0);
        }


        // member methods



    }
}
